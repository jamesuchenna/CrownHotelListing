using CrownHotelListing.Core.Interfaces;
using CrownHotelListing.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrownHotelListing.Infrastructure.Repositories
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        IGenericRepository<Country> _countries;
        IGenericRepository<Hotel> _hotels;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public IGenericRepository<Country> Countries => _countries ??= new GenericRepository<Country>(_context);

        public IGenericRepository<Hotel> Hotels => _hotels ??= new GenericRepository<Hotel>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
