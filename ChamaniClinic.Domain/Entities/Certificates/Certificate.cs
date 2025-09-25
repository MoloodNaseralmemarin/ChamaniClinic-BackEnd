using ChamaniClinic.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamaniClinic.Domain.Entities.Certificates
{
    public class Certificate:BaseEntity
    {
        public string ImageUrl { get; set; }
        public string Title { get; set; }
    }
}
