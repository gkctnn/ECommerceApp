using ECommerceApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceApp.Entities.Domain.Catalog
{
    public class Category : IEntity
    {
        #region Properties
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Published { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
        public int Id { get; set; }
        public bool Deleted { get; set; }
        #endregion
    }
}
