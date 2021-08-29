using CarRentalManagement.Server.Data;
using CarRentalManagement.Server.IRepository;
using CarRentalManagement.Server.Models;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Make> _makesRepository;
        private IGenericRepository<Model> _modelRepository;
        private IGenericRepository<Vehicle> _vehicleRepository;
        private IGenericRepository<Booking> _bookingRepository;
        private IGenericRepository<Colour> _colourRepository;
        private IGenericRepository<Customer> _customerRepository;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<Make> MakesRepository => _makesRepository ?? new GenericRepository<Make>(_context);
        public IGenericRepository<Model> ModelRepository => _modelRepository ?? new GenericRepository<Model>(_context);
        public IGenericRepository<Vehicle> VehicleRepository => _vehicleRepository ?? new GenericRepository<Vehicle>(_context);
        public IGenericRepository<Booking> BookingRepository => _bookingRepository ?? new GenericRepository<Booking>(_context);
        public IGenericRepository<Colour> ColourRepository => _colourRepository ?? new GenericRepository<Colour>(_context);
        public IGenericRepository<Customer> CustomerRepository => _customerRepository ?? new GenericRepository<Customer>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this); // to remove it from memory after it's used
        }

        public async Task Save(HttpContext httpContext)
        {
            //var user = httpContext.User.Identity.Name;
            var userId = httpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = await _userManager.FindByIdAsync(userId);

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified
                         || q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user.UserName;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user.UserName;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}
