using Controller.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Models
{
   public  class Cooordinationcs
    {
        public Cooordinationcs(double x, double y, Regions region)
        {
            this.X = x;
            this.Y = y;
            this.Region = region;

        }

        double X { get; set; }
        double Y { get; set; }  
        Regions Region { get; set; }


    }
}
