namespace Boccee_Ball_League.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeamIDs : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Games", name: "AwayTeam_ID", newName: "AwayTeamID");
            RenameColumn(table: "dbo.Games", name: "HomeTeam_ID", newName: "HomeTeamID");
            RenameIndex(table: "dbo.Games", name: "IX_HomeTeam_ID", newName: "IX_HomeTeamID");
            RenameIndex(table: "dbo.Games", name: "IX_AwayTeam_ID", newName: "IX_AwayTeamID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Games", name: "IX_AwayTeamID", newName: "IX_AwayTeam_ID");
            RenameIndex(table: "dbo.Games", name: "IX_HomeTeamID", newName: "IX_HomeTeam_ID");
            RenameColumn(table: "dbo.Games", name: "HomeTeamID", newName: "HomeTeam_ID");
            RenameColumn(table: "dbo.Games", name: "AwayTeamID", newName: "AwayTeam_ID");
        }
    }
}
