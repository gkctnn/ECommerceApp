using ECommerceApp.Core.EntityFramework;
using ECommerceApp.DataAccess.Abstract.Domain.Catalog;
using ECommerceApp.Entities.Domain.Catalog;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceApp.DataAccess.EntityFramework.Domain.Catalog
{
    public class ProductRepository : RepositoryEF<Product, AppDbContext>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}
