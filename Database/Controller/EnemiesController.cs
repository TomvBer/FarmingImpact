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
    public class EnemiesController
    {

        public int EnemyId { get; set; }
        public string EnemyName { get; set; }
        public Drops? Drops { get; set; }
    }
}
