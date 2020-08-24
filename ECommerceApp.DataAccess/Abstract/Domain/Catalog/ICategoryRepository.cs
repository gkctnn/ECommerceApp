using ECommerceApp.Core.Abstract;
using ECommerceApp.Entities.Domain.Catalog;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceApp.DataAccess.Abstract.Domain.Catalog
{
    public interface ICategoryRepository : IRepository<Category>
    {
    }
}
