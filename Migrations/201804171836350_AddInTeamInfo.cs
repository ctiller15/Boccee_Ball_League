namespace Boccee_Ball_League.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInTeamInfo : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TeamGames", "Team_ID", "dbo.Teams");
            DropForeignKey("dbo.TeamGames", "Game_ID", "dbo.Games");
            DropIndex("dbo.TeamGames", new[] { "Team_ID" });
            DropIndex("dbo.TeamGames", new[] { "Game_ID" });
            AddColumn("dbo.Games", "Team_ID", c => c.Int());
            AddColumn("dbo.Teams", "Game_ID", c => c.Int());
            CreateIndex("dbo.Games", "HomeTeamID");
            CreateIndex("dbo.Games", "AwayTeamID");
            CreateIndex("dbo.Games", "Team_ID");
            CreateIndex("dbo.Teams", "Game_ID");
            AddForeignKey("dbo.Games", "Team_ID", "dbo.Teams", "ID");
            AddForeignKey("dbo.Games", "AwayTeamID", "dbo.Teams", "ID");
            AddForeignKey("dbo.Games", "HomeTeamID", "dbo.Teams", "ID");
            AddForeignKey("dbo.Teams", "Game_ID", "dbo.Games", "ID");
            DropTable("dbo.TeamGames");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TeamGames",
                c => new
                    {
                        Team_ID = c.Int(nullable: false),
                        Game_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Team_ID, t.Game_ID });
            
            DropForeignKey("dbo.Teams", "Game_ID", "dbo.Games");
            DropForeignKey("dbo.Games", "HomeTeamID", "dbo.Teams");
            DropForeignKey("dbo.Games", "AwayTeamID", "dbo.Teams");
            DropForeignKey("dbo.Games", "Team_ID", "dbo.Teams");
            DropIndex("dbo.Teams", new[] { "Game_ID" });
            DropIndex("dbo.Games", new[] { "Team_ID" });
            DropIndex("dbo.Games", new[] { "AwayTeamID" });
            DropIndex("dbo.Games", new[] { "HomeTeamID" });
            DropColumn("dbo.Teams", "Game_ID");
            DropColumn("dbo.Games", "Team_ID");
            CreateIndex("dbo.TeamGames", "Game_ID");
            CreateIndex("dbo.TeamGames", "Team_ID");
            AddForeignKey("dbo.TeamGames", "Game_ID", "dbo.Games", "ID", cascadeDelete: true);
            AddForeignKey("dbo.TeamGames", "Team_ID", "dbo.Teams", "ID", cascadeDelete: true);
        }
    }
}
