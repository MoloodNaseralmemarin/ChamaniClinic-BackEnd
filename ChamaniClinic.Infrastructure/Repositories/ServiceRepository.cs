using ChamaniClinic.Domain.Entities.Services;
using ChamaniClinic.Domain.Interfaces;
using ChamaniClinic.Infrastructure.DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamaniClinic.Infrastructure.Repositories
{
    public class ServiceRepository : GenericRepository<Service>, IServiceRepository
    {
        public ServiceRepository(ChamaniClinicDBContext context) : base(context)
        {
        }
    }
}
