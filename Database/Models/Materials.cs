using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Database.Models
{
    public class Materials
    {
        public int MaterialId { get; set; }
        public string Name { get; set; }
        public Rarity? Rarity { get; set; }
    }
}
