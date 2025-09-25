using ChamaniClinic.Domain.Entities.Blogs;
using ChamaniClinic.Domain.Entities.Certificates;
using ChamaniClinic.Domain.Interfaces;
using ChamaniClinic.Infrastructure.DBContext;

namespace ChamaniClinic.Infrastructure.Repositories
{
    public class CertificateRepository : GenericRepository<Certificate>, ICertificateRepository
    {
        public CertificateRepository(ChamaniClinicDBContext context) : base(context)
        {
        }
    }
}
