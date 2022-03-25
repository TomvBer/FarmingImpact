using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace DatabaseEnd.Models
{
    public class Materials
    {
        [Key]
        public int MaterialId { get; set; }
        public string Name { get; set; }
        public Rarity? Rarity { get; set; }
    }
}
