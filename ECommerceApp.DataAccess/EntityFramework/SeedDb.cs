using ECommerceApp.Entities.Domain.Catalog;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.DataAccess.EntityFramework
{
    public class SeedDb
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<AppDbContext>();

            context.Database.EnsureCreated();

            Category category = new Category
            {
                Name = "Category 1",
                Description = "Category Description 1",
                CreatedOnUtc = DateTime.Now,
                Deleted = false,
                DisplayOrder = 0,
                Published = true,
                UpdatedOnUtc = DateTime.Now
            };

            if (!context.Categories.Any())
            {
                context.Categories.Add(category);
            }

            context.SaveChanges();
        }
    }
}