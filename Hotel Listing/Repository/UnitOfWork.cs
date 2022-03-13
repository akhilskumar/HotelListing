using Hotel_Listing.Data;
using Hotel_Listing.DataEntity;
using Hotel_Listing.IRepository;
using System;
using System.Threading.Tasks;

namespace Hotel_Listing.Repository
{
    public class UnitOfWork : IUnitofWork
    {
        private readonly DataContext _context;
        private IGenericRepository<Country> _countries;
        private IGenericRepository<Hotel> _hotels;
        

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }
        public IGenericRepository<Country> Countries => _countries ??=new GenericRepository<Country>(_context);

        public IGenericRepository<Hotel> Hotels => _hotels ??=new GenericRepository<Hotel>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool v)
        {
            throw new NotImplementedException();
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
