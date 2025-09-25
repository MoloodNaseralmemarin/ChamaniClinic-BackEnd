using ChamaniClinic.Domain.Entities.Blogs;
using ChamaniClinic.Domain.Entities.Certificates;
using ChamaniClinic.Domain.Entities.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamaniClinic.Infrastructure.DBContext
{
    public class ChamaniClinicDBContext: DbContext
    {
        public ChamaniClinicDBContext(DbContextOptions<ChamaniClinicDBContext> options) : base(options)
        {
           
        }

        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Certificate> Certificates { get; set; }
    }
}
