using BlazorLib.Data.Repositories;
using BlazorLib.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            return Ok(await _categoryRepository.GetAllCategories());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            return Ok(await _categoryRepository.GetCategory(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] Categories category)
        {
            if (category == null)
            {
                return BadRequest();
            }

            if (category.Name == string.Empty)
            {
                ModelState.AddModelError("Name", "Category name is empty");
            }

            if (!ModelState.IsValid)
                return BadRequest();

            var created = await _categoryRepository.InsertCategory(category);
            return Created("created", created);
        
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory([FromBody] Categories category)
        {
            if (category == null)
            {
                return BadRequest();
            }
            if (category.Name.Trim() == string.Empty)
            {
                ModelState.AddModelError("Name", "Category name is empty");
            }

            if (category.Name == string.Empty)
            {
                ModelState.AddModelError("Name", "Category name is empty");
            }

            if (!ModelState.IsValid)
                return BadRequest();

             await _categoryRepository.UpdateCategory(category);
            return NoContent(); //exito se regresa un 204
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            if (id == 0)
                return BadRequest();

            await _categoryRepository.DeleteCategory(id);
            return NoContent(); // success
        }

     
    }
}
