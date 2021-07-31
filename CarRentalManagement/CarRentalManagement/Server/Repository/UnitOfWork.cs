using CarRentalManagement.Server.Data;
using CarRentalManagement.Server.IRepository;
using CarRentalManagement.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
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

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
