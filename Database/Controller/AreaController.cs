﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using DatabaseEnd.Models;

namespace DatabaseEnd.Controller
{
    public class AreaController
    {

        public int AreaId { get; set; }
        public Region? Region { get; set; }

        public string AreaName { get; set; }
    }
}
