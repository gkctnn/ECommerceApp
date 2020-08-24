using ECommerceApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceApp.Entities.Domain.Catalog
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public bool Deleted { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
    }
}
