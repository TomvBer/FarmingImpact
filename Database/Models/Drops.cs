using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Database.Models
{
    public class Drops
    {
        public int DropId { get; set; }
        public Materials? Materials { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }
}
