using ChamaniClinic.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamaniClinic.Domain.Entities.Blogs
{
    public class Blog:BaseEntity
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }

        public string FullDescription { get; set; }

        public string ImageUrl { get; set; }
    }
}
