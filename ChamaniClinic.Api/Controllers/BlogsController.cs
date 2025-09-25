using ChamaniClinic.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ChamaniClinic.APi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogsController : ControllerBase
    {
        private readonly IBlogManager _blogManager;

        public BlogsController(IBlogManager blogManager)
        {
            _blogManager = blogManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var blogs = await _blogManager.GetAllAsync();
            return Ok(blogs);
        }
    }
}
