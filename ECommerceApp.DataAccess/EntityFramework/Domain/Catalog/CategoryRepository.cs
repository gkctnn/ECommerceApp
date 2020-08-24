using ECommerceApp.Core.EntityFramework;
using ECommerceApp.DataAccess.Abstract.Domain.Catalog;
using ECommerceApp.Entities.Domain.Catalog;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceApp.DataAccess.EntityFramework.Domain.Catalog
{
    public class CategoryRepository : RepositoryEF<Category, AppDbContext>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
