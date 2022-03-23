using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Database.Models
{
    public class Area
    {
       public Region? Region { get; set; }
        public int AreaId { get; set; }
        public string AreaName { get; set; }
    }
}
