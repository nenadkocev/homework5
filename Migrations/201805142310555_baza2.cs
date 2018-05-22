namespace d5.Migrations
{
    using d5.Models;
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class baza2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FriendModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        MestoNaZiveenje = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
           
        }
        
        public override void Down()
        {
            DropTable("dbo.FriendModels");
        }
    }
}
