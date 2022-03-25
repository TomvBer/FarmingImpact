using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using DatabaseEnd.Models;

namespace DatabaseEnd.Controller
{
    public class DropsController
    {

        public int DropId { get; set; }
        public Materials? Materials { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }
}
