namespace pets.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class normnameoftables : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Animal", newName: "tblAnimal");
            RenameTable(name: "dbo.Order", newName: "tblOrder");
            RenameTable(name: "dbo.Size", newName: "tblSize");
            RenameTable(name: "dbo.Types", newName: "tblType");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.tblType", newName: "Types");
            RenameTable(name: "dbo.tblSize", newName: "Size");
            RenameTable(name: "dbo.tblOrder", newName: "Order");
            RenameTable(name: "dbo.tblAnimal", newName: "Animal");
        }
    }
}
