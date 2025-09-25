using ChamaniClinic.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ChamaniClinic.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CertificatesController : Controller
    {
        private readonly ICertificateManager _certificateManager;
        public CertificatesController(ICertificateManager certificateManager)
        {
            _certificateManager = certificateManager;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var certificate = await _certificateManager.GetAllAsync();
            return Ok(certificate);
        }
    }
}
