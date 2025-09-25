using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamaniClinic.Application.DTOs
{
    public class BlogDto
    {
        public DateTime CreatedDate { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }

        public string FullDescription { get; set; }

        public string ImageUrl { get; set; }
    }
}
