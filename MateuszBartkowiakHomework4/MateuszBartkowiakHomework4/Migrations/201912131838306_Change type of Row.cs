namespace MateuszBartkowiakHomework4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangetypeofRow : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OrderTickets", "Row", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrderTickets", "Row", c => c.Int(nullable: false));
        }
    }
}
