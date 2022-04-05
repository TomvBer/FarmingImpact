using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace DatabaseEnd.Models
{
    public class Area
    {
        [Key]
        public int AreaId { get; set; }
        public Region? Region { get; set; }

        public string AreaName { get; set; }
    }
}
