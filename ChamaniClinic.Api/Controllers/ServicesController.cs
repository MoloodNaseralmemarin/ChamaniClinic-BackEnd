using ChamaniClinic.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ChamaniClinic.APi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public ServicesController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var services = await _serviceManager.GetAllAsync();
            return Ok(services);
        }
    }
}
