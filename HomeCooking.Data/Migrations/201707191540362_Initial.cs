namespace HomeCooking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.recipes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Duration = c.Int(nullable: false),
                        Creator_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.users", t => t.Creator_Id, cascadeDelete: true)
                .Index(t => t.Creator_Id);
            
            CreateTable(
                "dbo.users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(unicode: false),
                        Password = c.String(unicode: false),
                        NickName = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.recipes", "Creator_Id", "dbo.users");
            DropIndex("dbo.recipes", new[] { "Creator_Id" });
            DropTable("dbo.users");
            DropTable("dbo.recipes");
        }
    }
}
