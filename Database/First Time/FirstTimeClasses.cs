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
            Seedrarities = new Rarity[]
            {


            };
            SeedRegions = new Region[] {
               
            };


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
        #region   
        Rarity[] Seedrarities { get; set; }
        #endregion
        #region  
        Region[] SeedRegions { get; set; }

        #endregion
        #region  

        public Region[] SetStartRegions() {

            Region MondstRG = new Region
            {
                RegionId = 1,
                Name = "Mondstadt"
            };
            Region LiyueRG = new Region
            {
                RegionId = 2,
                Name = "Liyue"
            };
            Region RegionInazuma = new Region
            {
                RegionId = 3,
                Name = "Inzamuam"
            };
            Region[] regions = new Region[]{
                MondstRG, LiyueRG, LiyueRG
            };
            return regions;
        }
        public Rarity[] SetStartRarities()
        {


        }


        #endregion




    }
}

