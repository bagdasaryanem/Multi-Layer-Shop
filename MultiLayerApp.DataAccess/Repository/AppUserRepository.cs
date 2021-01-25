using MultiLayerApp.DataAccess.Data;
using MultiLayerApp.DataAccess.Repository.IRepository;
using MultiLayerApp.Models;
using System.Linq;

namespace MultiLayerApp.DataAccess.Repository
{
    public class AppUserRepository : Repository<AppUser>, IAppUserRepository
    {
        private readonly ApplicationDbContext _db;

        public AppUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

    }
}