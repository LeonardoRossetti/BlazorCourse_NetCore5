using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Server.Data;
using CarRentalManagement.Shared.Domain;

namespace CarRentalManagement.Server.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class MakesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MakesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Makes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Makes.ToListAsync());
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Make>>> GetMakes()
        {
            return await _context.Makes.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Make>> GetMake(int id)
        {
            var make = await _context.Makes.FindAsync(id);

            if (make == null)
                return NotFound();

            return make;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMake(int id, Make make)
        {
            if (id != make.Id)
                return BadRequest();

            _context.Entry(make);//.State == EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MakeExists(id))
                    return NotFound();
                else
                    throw;
            }
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Make>> PostMake(Make make)
        {
            _context.Makes.Add(make);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMake", new { id = make.Id }, make);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMake(int id)
        {
            var make = await _context.Makes.FindAsync(id);
            if (make == null)
                return NotFound();

            _context.Makes.Remove(make);

            await _context.SaveChangesAsync();

            return NoContent();
        }

        //[HttpDelete]
        //public async Task<>


        // GET: Makes/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var make = await _context.Makes
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (make == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(make);
        //}

        // GET: Makes/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        // POST: Makes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Name,Id,CreatedBy,DateCreated,DateUpdated,UpdatedBy")] Make make)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(make);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(make);
        //}

        // GET: Makes/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var make = await _context.Makes.FindAsync(id);
        //    if (make == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(make);
        //}

        // POST: Makes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Name,Id,CreatedBy,DateCreated,DateUpdated,UpdatedBy")] Make make)
        //{
        //    if (id != make.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(make);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!MakeExists(make.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(make);
        //}

        // GET: Makes/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var make = await _context.Makes
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (make == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(make);
        //}

        // POST: Makes/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var make = await _context.Makes.FindAsync(id);
        //    _context.Makes.Remove(make);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool MakeExists(int id)
        {
            return _context.Makes.Any(e => e.Id == id);
        }
    }
}
