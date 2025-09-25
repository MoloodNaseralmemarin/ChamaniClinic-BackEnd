
using ChamaniClinic.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamaniClinic.Domain.Entities.Services
{
    public class Service:BaseEntity
    {
        public string Title {  get; set; }
        public string Description { get; set; }
    }
}
