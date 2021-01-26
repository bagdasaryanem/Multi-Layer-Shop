using System;
using System.Collections.Generic;
using System.Text;

namespace MultiLayerApp.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        IProductRepository Product { get; }
        IShoppingCartRepository ShoppingCart { get; }
        IAppUserRepository AppUser { get; }
        IOrderHeaderRepository OrderHeader { get; }

        void Save();
    }
}
