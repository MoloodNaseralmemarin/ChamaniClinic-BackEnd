using ChamaniClinic.Application.DTOs;
using ChamaniClinic.Domain.Entities.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamaniClinic.Application.Interfaces
{
    public interface IServiceManager
    {
        Task<IEnumerable<ServiceDto>> GetAllAsync();
    }
}
