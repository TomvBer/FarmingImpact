﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace DatabaseEnd.Models
{
    public class Drops
    {
        [Key]
        public int DropId { get; set; }
        public Materials? Materials { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }
}
