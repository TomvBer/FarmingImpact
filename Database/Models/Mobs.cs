﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Database.Models
{
    public class Mobs
    {
        public int MobsId { get; set; }
        public Enemies? EnemyID{ get; set; }
        public Region? Region { get; set; }
    }
}
