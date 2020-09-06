namespace MateuszBartkowiakHomework4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ClientId);
            
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        FilmId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Type = c.String(nullable: false),
                        YearOfProduction = c.Int(nullable: false),
                        MinAge = c.Int(nullable: false),
                        Is3D = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.FilmId);
            
            CreateTable(
                "dbo.OrderTickets",
                c => new
                    {
                        OrderTIcketId = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        FilmId = c.Int(nullable: false),
                        TicketId = c.Int(nullable: false),
                        Day = c.DateTime(nullable: false),
                        Time = c.DateTime(nullable: false),
                        Row = c.Int(nullable: false),
                        Place = c.Int(nullable: false),
                        Vip = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.OrderTIcketId)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Films", t => t.FilmId, cascadeDelete: true)
                .ForeignKey("dbo.Tickets", t => t.TicketId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.FilmId)
                .Index(t => t.TicketId);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        TicketId = c.Int(nullable: false, identity: true),
                        Discount = c.String(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TicketId);
            
            CreateTable(
                "dbo.UserLogins",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderTickets", "TicketId", "dbo.Tickets");
            DropForeignKey("dbo.OrderTickets", "FilmId", "dbo.Films");
            DropForeignKey("dbo.OrderTickets", "ClientId", "dbo.Clients");
            DropIndex("dbo.OrderTickets", new[] { "TicketId" });
            DropIndex("dbo.OrderTickets", new[] { "FilmId" });
            DropIndex("dbo.OrderTickets", new[] { "ClientId" });
            DropTable("dbo.UserLogins");
            DropTable("dbo.Tickets");
            DropTable("dbo.OrderTickets");
            DropTable("dbo.Films");
            DropTable("dbo.Clients");
        }
    }
}
