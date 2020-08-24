using ECommerceApp.Core.Abstract;
using ECommerceApp.Entities.Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceApp.DataAccess.Abstract.Order
{
    public interface IShoppingCartRepository : IRepository<ShoppingCart>
    {
    }
}
