using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Models
{
    public class Mobs
    {
        public Mobs(Enemies enemies, Cooordinationcs[] cordinates)
        {
            Enemies = enemies;
            Cordinates = cordinates;
            this.isDefeated = false;
        }

        Enemies Enemies { get; set; }
        Cooordinationcs[] Cordinates { get; set; }
        bool isDefeated { get; set; }

    }
}
