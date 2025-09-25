using ChamaniClinic.Application.DTOs;
using ChamaniClinic.Application.Interfaces;
using ChamaniClinic.Domain.Entities.Services;
using ChamaniClinic.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamaniClinic.Application.Services
{
    // Application/Services/ServiceManager.cs
    public class ServiceManager : IServiceManager
    {
        private readonly IServiceRepository _repository;

        public ServiceManager(IServiceRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ServiceDto>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Select(s => new ServiceDto
            {
                Title = s.Title,
                Description = s.Description
            });
        }


    }


}
