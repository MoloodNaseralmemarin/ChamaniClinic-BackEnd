using ChamaniClinic.Application.DTOs;
using ChamaniClinic.Application.Interfaces;
using ChamaniClinic.Domain.Interfaces;


namespace ChamaniClinic.Application.Services
{
    public class CertificateManager:ICertificateManager
    {
        private readonly ICertificateRepository _repository;

        public CertificateManager(ICertificateRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<CertificateDto>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Select(b => new CertificateDto
            {

                Title = b.Title,
                ImageUrl = b.ImageUrl
            });
        }
    }
}
