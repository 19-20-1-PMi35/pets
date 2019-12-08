namespace pets.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class normalDB : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Animal", "sex", c => c.String(nullable: false));
            AlterColumn("dbo.Order", "surname", c => c.String(nullable: false));
            AlterColumn("dbo.Order", "pnone", c => c.String(nullable: false));
            AlterColumn("dbo.Size", "size", c => c.String(nullable: false));
            AlterColumn("dbo.Types", "type", c => c.String(nullable: false)); 
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Types", "type", c => c.String());
            AlterColumn("dbo.Size", "size", c => c.String());
            AlterColumn("dbo.Order", "pnone", c => c.String());
            AlterColumn("dbo.Order", "surname", c => c.String());
            AlterColumn("dbo.Animal", "sex", c => c.String());
        }
    }
}
