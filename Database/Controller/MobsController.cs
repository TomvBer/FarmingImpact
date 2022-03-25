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

    public class MobsController
    {

        public int MobsId { get; set; }
        public Enemies? EnemyID { get; set; }
        public Region? Region { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
    }
}