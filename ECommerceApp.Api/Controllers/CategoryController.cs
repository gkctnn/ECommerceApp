using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceApp.Business.Abstract.Domain.Catalog;
using ECommerceApp.Entities.Domain.Catalog;
using ECommerceApp.Business.ResponseModel.Domain.Catalog;
using ECommerceApp.Business.RequestModel.Domain.Catalog;

namespace ECommerceApp.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Category")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [Route("~/api/GetCategorys")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            CategoryResponse response = new CategoryResponse();

            response.Entities = await _categoryService.GetAllAsync();
            response.IsSuccess = true;
            response.EntitiesCount = response.Entities.Count();

            return Ok(response);
        }

        [Route("~/api/GetCategory")]
        [HttpGet("{id}")]
        public async Task<IActionResult> Index(int id)
        {
            CategoryResponse response = new CategoryResponse();

            response.Entity = await _categoryService.GetAsync(id);
            response.IsSuccess = true;

            return Ok(response);
        }

        [Route("~/api/AddCategory")]
        [HttpPost]
        public async Task<IActionResult> AddCategory([FromBody] CategoryRequest category)
        {
            CategoryResponse response = new CategoryResponse();

            await _categoryService.AddAsync(category.Entity);

            response.Entity = await _categoryService.GetAsync(category.Entity.Id);
            response.IsSuccess = true;

            return Ok(response);
        }

        [Route("~/api/UpdateCategory")]
        [HttpPut]
        public async Task<IActionResult> UpdateCategory([FromBody] CategoryRequest category)
        {
            CategoryResponse response = new CategoryResponse();

            var updated = await _categoryService.UpdateAsync(category.Entity, category.Entity.Id);

            if (updated == null)
            {
                response.HasError = true;
                response.Errors.Add("Category Does Not Exist!");

                return BadRequest(response);
            }
            response.Entity = updated;
            response.IsSuccess = true;

            return Ok(response);
        }

        [Route("~/api/DeleteCategory/{id}")]
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            CategoryResponse response = new CategoryResponse();

            var deleted = await _categoryService.DeleteAsync(_categoryService.GetAsync(id));

            if (deleted == null)
            {
                response.HasError = true;
                response.Errors.Add("Category Does Not Exist!");

                return BadRequest(response);
            }
            response.Entity = deleted;
            response.IsSuccess = true;

            return Ok(response);
        }

        protected override void Dispose(bool disposing)
        {
            _categoryService.Dispose();
            base.Dispose(disposing);
        }
    }
}
