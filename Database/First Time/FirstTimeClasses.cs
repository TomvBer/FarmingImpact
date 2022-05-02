using DatabaseEnd.Models;

namespace DatabaseEnd.First_Time
{
    public class FirstTimeClasses
    {
        static bool IsFirstTime;

        public FirstTimeClasses()
        {
            SeedSubAreas = new Area[]
            {

            };
            SeedDrops = new Drops[]
            {


            };
            SeedEnemies = new Enemies[]
            {


            };
            Seedmaterials = new Materials[]
            {


            };
            SeedMobs = new Mobs[]
            {

            };
            Seedrarities = SetStartRarities();
            SeedRegions = SetStartRegions();


        }

        #region
        Area[] SeedSubAreas { get; set; }

        #endregion


        #region   
        Drops[] SeedDrops { get; set; }
        #endregion
        #region    
        Enemies[] SeedEnemies { get; set; }
        #endregion
        #region   
        Materials[] Seedmaterials { get; set; }
        #endregion
        #region   
        Mobs[] SeedMobs { get; set; }
        #endregion
        //RaritySeedsDone
        #region   
        Rarity[] Seedrarities { get; set; }
        public Rarity[] SetStartRarities()
        {
            //Inserting standard rarity's 
            Rarity Normal = new Rarity { RarityId = 0, Name = "common" };
            Rarity Uncommon = new Rarity { RarityId = 1, Name = "Uncommon" };
            Rarity Rare = new Rarity { RarityId = 2, Name = "Rare" };
            Rarity Epic = new Rarity { RarityId = 3, Name = "Epic" };
            Rarity Legendary = new Rarity { RarityId = 4, Name = "Legendary" };
            //Creating array
            Rarity[] RarityList = new Rarity[] { Normal, Uncommon, Rare, Epic, Legendary };
            return RarityList;
        }
        #endregion

        //RegionSeedsDone
        #region
        Region[] SeedRegions { get; set; }
        public Region[] SetStartRegions()
        {

            Region MondstRG = new Region { RegionId = 1, Name = "Mondstadt" };
            Region LiyueRG = new Region { RegionId = 2, Name = "Liyue" };
            Region InazumaRG = new Region { RegionId = 3, Name = "Inzamuam" };
            Region[] regions = new Region[] { MondstRG, LiyueRG, InazumaRG };

            return regions;
        }
        #endregion
        #region  





        #endregion




    }
}

