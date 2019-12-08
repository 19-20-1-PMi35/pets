namespace pets.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class something : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tblAnimal", "image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblAnimal", "image", c => c.Binary());
        }
    }
}
