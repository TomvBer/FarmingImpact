using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Database.Models;

namespace Database;
public class DatabaseConnector : DbContext {
    public DbSet<Area> Areas { get; set; }  
    public DbSet<Coordination> Coordinations { get; set; }
    public DbSet<Drops> Drops { get; set; }
    public DbSet<Enemies> Enemies { get; set; }
    public DbSet<Materials> Materials { get; set; }
    public DbSet<Mobs> Mobs { get; set; }
    public DbSet<Rarity> Rarities { get; set; }
    public DbSet<Region> Regions { get; set; }

    public string DbPath { get;}


}