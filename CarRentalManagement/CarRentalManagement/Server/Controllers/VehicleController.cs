using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Server.Data;
using CarRentalManagement.Shared.Domain;
using CarRentalManagement.Server.IRepository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace CarRentalManagement.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment; //this will give us access to our static folders (wwwroot for example)
        private readonly IHttpContextAccessor _httpContextAccessor;

        public VehicleController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet]
        public async Task<IActionResult> GetVehicles()
        {
            var vehicle = await _unitOfWork.VehicleRepository.GetAll(includes: q => q.Include(x => x.Make).Include(x => x.Model).Include(x => x.Colour));
            return Ok(vehicle);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVehicle(int id)
        {
            var vehicle = await _unitOfWork.VehicleRepository.Get(m => m.Id == id);

            if (vehicle == null)
                return NotFound();

            return Ok(vehicle);
        }

        [HttpGet("{id}/details")]
        public async Task<IActionResult> GetVehicleDetails(int id)
        {
            var vehicle = await _unitOfWork.VehicleRepository.Get(m => m.Id == id, 
                includes: q => q.Include(x => x.Make).Include(x => x.Model).Include(x => x.Colour).Include(x => x.Bookings));

            if (vehicle == null)
                return NotFound();

            return Ok(vehicle);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicle(int id, Vehicle vehicle)
        {
            if (id != vehicle.Id)
                return BadRequest();

            if (vehicle.Image != null)
            {
                vehicle.ImageName = CreateFile(vehicle.Image, vehicle.ImageName);
            }

            _unitOfWork.VehicleRepository.Update(vehicle);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await VehicleExists(id))
                    return NotFound();
                else
                    throw;
            }
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Vehicle>> PostVehicle(Vehicle vehicle)
        {
            if (vehicle.Image != null)
            {
                vehicle.ImageName = CreateFile(vehicle.Image, vehicle.ImageName);
            }

            await _unitOfWork.VehicleRepository.Insert(vehicle);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetVehicle", new { id = vehicle.Id }, vehicle);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
            if (!await VehicleExists(id))
                return NotFound();

            await _unitOfWork.VehicleRepository.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> VehicleExists(int id)
        {
            var vehicle = await _unitOfWork.VehicleRepository.Get(m => m.Id == id);
            return vehicle != null;
        }

        private string CreateFile(byte[] image, string name)
        {
            var url = _httpContextAccessor.HttpContext.Request.Host.Value;
            var path = $"{_webHostEnvironment.WebRootPath}\\uploads\\{name}";
            var fileStream = System.IO.File.Create(path);
            fileStream.Write(image, 0, image.Length);
            fileStream.Close();
            return $"https://{url}/uploads/{name}";
        }
    }
}
