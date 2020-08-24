using ECommerceApp.Core.EntityFramework;
using ECommerceApp.DataAccess.Abstract.Order;
using ECommerceApp.Entities.Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceApp.DataAccess.EntityFramework.Order
{
    public class ShoppingCartItemRepository : RepositoryEF<ShoppingCartItem, AppDbContext>, IShoppingCartItemRepository
    {
        public ShoppingCartItemRepository(AppDbContext context) : base(context)
        {
        }
    }
}
