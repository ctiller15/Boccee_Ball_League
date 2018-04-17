namespace Boccee_Ball_League.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyHomeAwayIDs : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Games", "Team_ID", "dbo.Teams");
            DropForeignKey("dbo.Games", "AwayTeamID", "dbo.Teams");
            DropForeignKey("dbo.Games", "HomeTeamID", "dbo.Teams");
            DropForeignKey("dbo.Teams", "Game_ID", "dbo.Games");
            DropIndex("dbo.Games", new[] { "HomeTeamID" });
            DropIndex("dbo.Games", new[] { "AwayTeamID" });
            DropIndex("dbo.Games", new[] { "Team_ID" });
            DropIndex("dbo.Teams", new[] { "Game_ID" });
            CreateTable(
                "dbo.TeamGames",
                c => new
                    {
                        Team_ID = c.Int(nullable: false),
                        Game_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Team_ID, t.Game_ID })
                .ForeignKey("dbo.Teams", t => t.Team_ID, cascadeDelete: true)
                .ForeignKey("dbo.Games", t => t.Game_ID, cascadeDelete: true)
                .Index(t => t.Team_ID)
                .Index(t => t.Game_ID);
            
            DropColumn("dbo.Games", "Team_ID");
            DropColumn("dbo.Teams", "Game_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teams", "Game_ID", c => c.Int());
            AddColumn("dbo.Games", "Team_ID", c => c.Int());
            DropForeignKey("dbo.TeamGames", "Game_ID", "dbo.Games");
            DropForeignKey("dbo.TeamGames", "Team_ID", "dbo.Teams");
            DropIndex("dbo.TeamGames", new[] { "Game_ID" });
            DropIndex("dbo.TeamGames", new[] { "Team_ID" });
            DropTable("dbo.TeamGames");
            CreateIndex("dbo.Teams", "Game_ID");
            CreateIndex("dbo.Games", "Team_ID");
            CreateIndex("dbo.Games", "AwayTeamID");
            CreateIndex("dbo.Games", "HomeTeamID");
            AddForeignKey("dbo.Teams", "Game_ID", "dbo.Games", "ID");
            AddForeignKey("dbo.Games", "HomeTeamID", "dbo.Teams", "ID");
            AddForeignKey("dbo.Games", "AwayTeamID", "dbo.Teams", "ID");
            AddForeignKey("dbo.Games", "Team_ID", "dbo.Teams", "ID");
        }
    }
}
