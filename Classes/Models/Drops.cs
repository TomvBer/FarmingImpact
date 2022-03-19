using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Models
{
    public class Drops
    {
        Materials Materials { get; set; }
        int Min { get; set; }
        int Max { get; set; }
        public Drops(Materials material, int min, int max) { Materials = material; Min = min; Max = max; }

    }
}
