using ChamaniClinic.Domain.Entities.Blogs;
using ChamaniClinic.Domain.Interfaces;
using ChamaniClinic.Infrastructure.DBContext;

namespace ChamaniClinic.Infrastructure.Repositories
{
    public class BlogRepository : GenericRepository<Blog>, IBlogRepository
    {
        public BlogRepository(ChamaniClinicDBContext context) : base(context)
        {
        }
    }
}
