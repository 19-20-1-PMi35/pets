namespace pets.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImageField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblAnimal", "image", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblAnimal", "image");
        }
    }
}
