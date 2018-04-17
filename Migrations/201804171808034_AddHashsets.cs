namespace Boccee_Ball_League.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHashsets : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "Team_ID", c => c.Int());
            AddColumn("dbo.Teams", "Game_ID", c => c.Int());
            CreateIndex("dbo.Games", "Team_ID");
            CreateIndex("dbo.Teams", "Game_ID");
            AddForeignKey("dbo.Games", "Team_ID", "dbo.Teams", "ID");
            AddForeignKey("dbo.Teams", "Game_ID", "dbo.Games", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teams", "Game_ID", "dbo.Games");
            DropForeignKey("dbo.Games", "Team_ID", "dbo.Teams");
            DropIndex("dbo.Teams", new[] { "Game_ID" });
            DropIndex("dbo.Games", new[] { "Team_ID" });
            DropColumn("dbo.Teams", "Game_ID");
            DropColumn("dbo.Games", "Team_ID");
        }
    }
}
