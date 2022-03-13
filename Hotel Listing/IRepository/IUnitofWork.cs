using Hotel_Listing.DataEntity;
using System;
using System.Threading.Tasks;

namespace Hotel_Listing.IRepository
{
    public interface IUnitofWork : IDisposable
    {
        IGenericRepository<Country> Countries{get;}
        IGenericRepository<Hotel> Hotels{get;}
        Task Save();
    }
}
