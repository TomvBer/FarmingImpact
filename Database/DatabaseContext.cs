using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.Entity;
using Database.Models;

namespace Database;
public class DatabaseContext : DbContext
{
    public DbSet<Area> Areas { get; set; }
    public DbSet<Coordination> Coordinations { get; set; }
    public DbSet<Drops> Drops { get; set; }
    public DbSet<Enemies> Enemies { get; set; }
    public DbSet<Materials> Materials { get; set; }
    public DbSet<Mobs> Mobs { get; set; }
    public DbSet<Rarity> Rarities { get; set; }
    public DbSet<Region> Regions { get; set; }

    private readonly SqlConnectionStringBuilder builder = new();
    private SqlConnection Connection { get; set; }
    public DatabaseContext() : base()
    {

        builder.DataSource = @"(localdb)\MSSQLLocalDB";
        builder.InitialCatalog = "FarmingImpact";


        Connection = new(builder.ConnectionString);
    }

}






///// <summary>
/////      public DbConnection()
//{
//    builder.DataSource = env.DataSource();
//    builder.UserID = env.UserID();
//    builder.Password = env.Password();
//    builder.InitialCatalog = env.InitialCatalog();
//}

///// </summary>



//        {
//            // Seed gebruiker
//            Gebruiker gebruiker = new Gebruiker { ID = 5, Voornaam = "TestGebruiker", Achternaam = "Testje", Tussenvoegsel = "test", Geboortedatum = new DateTime(1999, 5, 8), Woonplaats = "Urk", Postcode = "8321SC", Huisnummer = "58", Straatnaam = "Gammels", Gebruikersnaam = "SeedData", Telefoonnummer = "0681718097", Toevoeging = "123" };
//            modelBuilder.Entity<Gebruiker>().HasData(gebruiker);

//            // Init locaties
//            Locatie loc1 = new(52.434, 4.8649) { Id = 1 };
//            Locatie loc2 = new(51.3, 5) { Id = 2 };
//            Locatie loc3 = new(50.9, 4.8) { Id = 3 };
//            Locatie loc4 = new(51.5, 4.7) { Id = 4 };
//            Locatie loc5 = new(51, 5.3) { Id = 5 };
//            Locatie loc6 = new(51.9, 4.7) { Id = 6 };
//            Locatie loc7 = new(51.2, 5.5) { Id = 7 };


//            // Add them to the modelbuilder
//            modelBuilder.Entity<Locatie>().HasData(
//                loc1,
//                loc2,
//                loc3,
//                loc4,
//                loc5,
//                loc6,
//                loc7
//            );

//            // Anonymous classes for Melding, EF Core can't handle foreign keys properly
//            modelBuilder.Entity<Melding>().HasData(
//                new { Id = 1, Category = Models.Enums.Category.Overig, Omschrijving = "Fietser omgevallen", Datum = new DateTime(2021, 3, 3), LocatieId = loc1.Id, GebruikerID = gebruiker.ID },
//                new { Id = 2, Category = Models.Enums.Category.Overig, Omschrijving = "Auto ongeluk", Datum = new DateTime(2021, 4, 16), LocatieId = loc2.Id, GebruikerID = gebruiker.ID },
//                new { Id = 3, Category = Models.Enums.Category.Diefstal, Omschrijving = "Spullen gestolen", Datum = new DateTime(2021, 1, 10), LocatieId = loc3.Id, GebruikerID = gebruiker.ID },
//                new { Id = 4, Category = Models.Enums.Category.Overig, Omschrijving = "Boom omgevallen op burger", Datum = new DateTime(2021, 3, 6), LocatieId = loc4.Id, GebruikerID = gebruiker.ID },
//                new { Id = 5, Category = Models.Enums.Category.Mishandeling, Omschrijving = "Eenden verdronken in het water door jongen", Datum = new DateTime(2021, 12, 3), LocatieId = loc5.Id, GebruikerID = gebruiker.ID }
//            );



//            // Anonymous classes for Melding, EF Core can't handle foreign keys properly
//            modelBuilder.Entity<Wijk>().HasData(
//                new { Id = 1, Name = "Zaadwijk", LeftCornerId = loc6.Id, RightCornerId = loc7.Id }
//            );
//        }
//    }
//}

//}