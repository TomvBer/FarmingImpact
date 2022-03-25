namespace DatabaseEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Start : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Areas",
                c => new
                    {
                        AreaId = c.Int(nullable: false, identity: true),
                        AreaName = c.String(),
                        Region_RegionId = c.Int(),
                    })
                .PrimaryKey(t => t.AreaId)
                .ForeignKey("dbo.Regions", t => t.Region_RegionId)
                .Index(t => t.Region_RegionId);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        RegionId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.RegionId);
            
            CreateTable(
                "dbo.Drops",
                c => new
                    {
                        DropId = c.Int(nullable: false, identity: true),
                        Min = c.Int(nullable: false),
                        Max = c.Int(nullable: false),
                        Materials_MaterialId = c.Int(),
                    })
                .PrimaryKey(t => t.DropId)
                .ForeignKey("dbo.Materials", t => t.Materials_MaterialId)
                .Index(t => t.Materials_MaterialId);
            
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        MaterialId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Rarity_RarityId = c.Int(),
                    })
                .PrimaryKey(t => t.MaterialId)
                .ForeignKey("dbo.Rarities", t => t.Rarity_RarityId)
                .Index(t => t.Rarity_RarityId);
            
            CreateTable(
                "dbo.Rarities",
                c => new
                    {
                        RarityId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.RarityId);
            
            CreateTable(
                "dbo.Enemies",
                c => new
                    {
                        EnemyId = c.Int(nullable: false, identity: true),
                        EnemyName = c.String(),
                        Drops_DropId = c.Int(),
                    })
                .PrimaryKey(t => t.EnemyId)
                .ForeignKey("dbo.Drops", t => t.Drops_DropId)
                .Index(t => t.Drops_DropId);
            
            CreateTable(
                "dbo.Mobs",
                c => new
                    {
                        MobsId = c.Int(nullable: false, identity: true),
                        X = c.Double(nullable: false),
                        Y = c.Double(nullable: false),
                        EnemyID_EnemyId = c.Int(),
                        Region_RegionId = c.Int(),
                    })
                .PrimaryKey(t => t.MobsId)
                .ForeignKey("dbo.Enemies", t => t.EnemyID_EnemyId)
                .ForeignKey("dbo.Regions", t => t.Region_RegionId)
                .Index(t => t.EnemyID_EnemyId)
                .Index(t => t.Region_RegionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Mobs", "Region_RegionId", "dbo.Regions");
            DropForeignKey("dbo.Mobs", "EnemyID_EnemyId", "dbo.Enemies");
            DropForeignKey("dbo.Enemies", "Drops_DropId", "dbo.Drops");
            DropForeignKey("dbo.Drops", "Materials_MaterialId", "dbo.Materials");
            DropForeignKey("dbo.Materials", "Rarity_RarityId", "dbo.Rarities");
            DropForeignKey("dbo.Areas", "Region_RegionId", "dbo.Regions");
            DropIndex("dbo.Mobs", new[] { "Region_RegionId" });
            DropIndex("dbo.Mobs", new[] { "EnemyID_EnemyId" });
            DropIndex("dbo.Enemies", new[] { "Drops_DropId" });
            DropIndex("dbo.Materials", new[] { "Rarity_RarityId" });
            DropIndex("dbo.Drops", new[] { "Materials_MaterialId" });
            DropIndex("dbo.Areas", new[] { "Region_RegionId" });
            DropTable("dbo.Mobs");
            DropTable("dbo.Enemies");
            DropTable("dbo.Rarities");
            DropTable("dbo.Materials");
            DropTable("dbo.Drops");
            DropTable("dbo.Regions");
            DropTable("dbo.Areas");
        }
    }
}
