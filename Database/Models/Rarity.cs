using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace DatabaseEnd.Models
{
    public class Rarity
    {
        [Key]
        public int RarityId { get; set; }
        public string Name { get; set; }
    }
}
