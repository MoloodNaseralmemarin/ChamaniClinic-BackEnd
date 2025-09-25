using ChamaniClinic.Domain.Entities.Blogs;
using ChamaniClinic.Domain.Entities.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamaniClinic.Domain.Interfaces
{
    public interface IBlogRepository : IGenericRepository<Blog>
    {
    }
}
