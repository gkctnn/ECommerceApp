using ECommerceApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceApp.Entities.Order
{
    public class ShoppingCartItem : IEntity
    {
        public int Id { get; set; }
        public bool Deleted { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
    }
}
