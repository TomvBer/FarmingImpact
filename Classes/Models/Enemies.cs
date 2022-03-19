using Controller.Models;
using System.Collections.Generic;

namespace Controller.Models
{
    public class Enemies
    {
        string Name { get; set; }
        Drops[] Itemdrops { get; set; }
        public Enemies(string name, Drops[] itemdrops) { Name = name; Itemdrops = itemdrops; }
        public string GiveName() {
        return Name;
        }

    }
}