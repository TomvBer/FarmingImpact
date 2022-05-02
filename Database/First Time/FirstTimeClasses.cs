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

        //Drops can only be done after Enemies and materials are done, same case for mobs.
        #region   
        Drops[] SeedDrops { get; set; }
        #endregion
        //FirstTwoEnemiesDone, more will be added later for Testing, needs Controller for RegionID 
        #region    
        Enemies[] SeedEnemies { get; set; }
        public Enemies[] SetStartEnemies()
        {
            Enemies[] SeedEnemies = new Enemies[1];
            Enemies Slime = new Enemies
            {
                EnemyId = 0,
                EnemyName = "Slime"
            };
            Enemies Hilichurl = new Enemies
            {
                EnemyId = 1,
                EnemyName = "Hilichurl"
            };

            SeedEnemies[0] = Slime;
            SeedEnemies[1] = Hilichurl;
            return SeedEnemies;
        }
        #endregion

       //Slime&Hilichurl material added, needs Controller to finish rarityID
        #region   
        Materials[] Seedmaterials { get; set; }
        public Materials[] SetStartMaterials()
        {

            Materials Slime = new Materials() { MaterialId = 0, Name = "Slime Condensate" };
            Materials Slime2 = new Materials() { MaterialId = 1, Name = "Slime Secretion" };
            Materials Slime3 = new Materials() { MaterialId = 2, Name = "Slime Concentrate" };
            Materials Hilichurl1 = new Materials() { MaterialId = 3, Name = "Damaged Mask" };
            Materials Hilichurl2 = new Materials() { MaterialId = 4, Name = "Stained Mask" };
            Materials Hilichurl3 = new Materials() { MaterialId = 5, Name = "Omnious Mask" };

            Materials[] SeedMaterials = new Materials[5];
            SeedMaterials[0] = Slime;
            SeedMaterials[1] = Slime2;
            SeedMaterials[2] = Slime3;
            SeedMaterials[3] = Hilichurl1;
            SeedMaterials[4] = Hilichurl2;
            SeedMaterials[5] = Hilichurl3;
            return SeedMaterials;

        }
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



    }
}

