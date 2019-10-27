namespace pets.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animal",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        age = c.Int(nullable: false),
                        sex = c.String(),
                        sizeId = c.Int(nullable: false),
                        breed = c.String(),
                        description = c.String(),
                        typeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Size", t => t.sizeId, cascadeDelete: true)
                .ForeignKey("dbo.Types", t => t.typeId, cascadeDelete: true)
                .Index(t => t.sizeId)
                .Index(t => t.typeId);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        surname = c.String(),
                        pnone = c.String(),
                        animalId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Animal", t => t.animalId, cascadeDelete: true)
                .Index(t => t.animalId);
            
            CreateTable(
                "dbo.Size",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        size = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        type = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Animal", "typeId", "dbo.Types");
            DropForeignKey("dbo.Animal", "sizeId", "dbo.Size");
            DropForeignKey("dbo.Order", "animalId", "dbo.Animal");
            DropIndex("dbo.Order", new[] { "animalId" });
            DropIndex("dbo.Animal", new[] { "typeId" });
            DropIndex("dbo.Animal", new[] { "sizeId" });
            DropTable("dbo.Types");
            DropTable("dbo.Size");
            DropTable("dbo.Order");
            DropTable("dbo.Animal");
        }
    }
}
