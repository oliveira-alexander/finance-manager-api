using finance_manager_api.Category.DTOs;
using finance_manager_api.Category.Entities;
using finance_manager_api.Category.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace finance_manager_api.Category.Controllers
{
    [ApiController]
    [Route("category")]
    public class CategoryController : ControllerBase
    {
        public ICategoryService _service;

        public CategoryController(ICategoryService categoryService) {
            this._service = categoryService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCategoryDTO dto) {
            var category = await _service.Create(dto);
            return Ok(category);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] long id) {
            await _service.Delete(id);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Search([FromQuery] FilterCategoryDTO filter) {
            return Ok(await _service.Search(filter));
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateCategoryDTO dto) {
            return Ok(await _service.Update(dto));
        }
        

    }
}
