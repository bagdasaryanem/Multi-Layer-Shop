using MultiLayerApp.DataAccess.Data;
using MultiLayerApp.DataAccess.Repository.IRepository;
using MultiLayerApp.Models;
using System.Linq;

namespace MultiLayerApp.DataAccess.Repository
{
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderHeaderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(OrderHeader obj)
        {
            _db.Update(obj);
        }
    }
}