namespace Boccee_Ball_League.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Hello : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        HomeScore = c.Int(nullable: false),
                        AwayScore = c.Int(nullable: false),
                        DateHappened = c.DateTime(nullable: false),
                        Notes = c.String(),
                        AwayTeam_ID = c.Int(),
                        HomeTeam_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Teams", t => t.AwayTeam_ID)
                .ForeignKey("dbo.Teams", t => t.HomeTeam_ID)
                .Index(t => t.AwayTeam_ID)
                .Index(t => t.HomeTeam_ID);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Mascot = c.String(),
                        Color = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TeamID = c.Int(nullable: false),
                        FullName = c.String(),
                        NickName = c.String(),
                        Number = c.Int(nullable: false),
                        ThrowingArm = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "HomeTeam_ID", "dbo.Teams");
            DropForeignKey("dbo.Games", "AwayTeam_ID", "dbo.Teams");
            DropIndex("dbo.Games", new[] { "HomeTeam_ID" });
            DropIndex("dbo.Games", new[] { "AwayTeam_ID" });
            DropTable("dbo.Players");
            DropTable("dbo.Teams");
            DropTable("dbo.Games");
        }
    }
}
