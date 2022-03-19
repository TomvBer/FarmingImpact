using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using Controller.Enums;

namespace Controller.Models
{
    public class Materials
    {
        string Name { get; set; }
        Rarity Rarity { get; set; }

        public Materials(string name, Rarity rarity) { this.Name = name; this.Rarity = rarity; }
    }

}
