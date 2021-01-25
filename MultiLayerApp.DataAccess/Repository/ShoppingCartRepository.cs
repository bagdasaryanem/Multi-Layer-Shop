using MultiLayerApp.DataAccess.Data;
using MultiLayerApp.DataAccess.Repository.IRepository;
using MultiLayerApp.Models;
using System.Linq;

namespace MultiLayerApp.DataAccess.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private readonly ApplicationDbContext _db;

        public ShoppingCartRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ShoppingCart obj)
        {
            _db.Update(obj);
        }
    }
}