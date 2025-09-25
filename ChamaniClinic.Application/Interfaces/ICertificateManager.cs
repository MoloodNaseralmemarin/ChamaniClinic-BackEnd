using ChamaniClinic.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamaniClinic.Application.Interfaces
{
    public interface ICertificateManager
    {
        Task<IEnumerable<CertificateDto>> GetAllAsync();
    }
}
