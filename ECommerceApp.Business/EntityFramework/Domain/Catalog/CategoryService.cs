using ECommerceApp.Business.Abstract.Domain.Catalog;
using ECommerceApp.DataAccess.Abstract.Domain.Catalog;
using ECommerceApp.DataAccess.EntityFramework;
using ECommerceApp.Entities.Domain.Catalog;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Business.EntityFramework.Domain.Catalog
{
    public class CategoryService : ICategoryService
    {
        ICategoryRepository _categoryRepository;
        protected AppDbContext _context;

        public CategoryService(AppDbContext context, ICategoryRepository categoryRepository)
        {
            _context = context;
            _categoryRepository = categoryRepository;
        }

        public Category Add(Category t)
        {
            throw new NotImplementedException();
        }

        public Task<Category> AddAsync(Category t)
        {
            return _categoryRepository.AddAsync(t);
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _categoryRepository.Dispose();
        }

        public Category Find(Expression<Func<Category, bool>> match)
        {
            throw new NotImplementedException();
        }

        public ICollection<Category> FindAll(Expression<Func<Category, bool>> match)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Category>> FindAllAsync(Expression<Func<Category, bool>> match)
        {
            throw new NotImplementedException();
        }

        public Task<Category> FindAsync(Expression<Func<Category, bool>> match)
        {
            return _categoryRepository.FindAsync(match);
        }

        public IQueryable<Category> FindBy(Expression<Func<Category, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Category>> FindByAsync(Expression<Func<Category, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Category Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Category>> GetAllAsync()
        {
            return _categoryRepository.GetAllAsync();
        }

        public IQueryable<Category> GetAllIncluding(params Expression<Func<Category, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetAsync(int id)
        {
            return _categoryRepository.GetAsync(id);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            return _categoryRepository.SaveAsync();
        }

        public Category Update(Category t, object key)
        {
            throw new NotImplementedException();
        }

        public Task<Category> UpdateAsync(Category t, object key)
        {
            throw new NotImplementedException();
        }

        public Category Delete(object key)
        {
            throw new NotImplementedException();
        }

        public Task<Category> DeleteAsync(object key)
        {
            return _categoryRepository.DeleteAsync(key);
        }
    }
}
