using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Database.Models
{
    public class Enemies
    {
        public int EnemyId { get; set; }
        public string EnemyName { get; set; }
        public Drops Drops { get; set; }
    }
}
