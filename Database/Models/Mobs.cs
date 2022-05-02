using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace DatabaseEnd.Models
{
    public class Mobs
    {
        [Key]
        public int MobsId { get; set; }
        public Enemies? EnemyID { get; set; }
        public Region? RegionID { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
    }
}
