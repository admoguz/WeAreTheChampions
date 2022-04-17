namespace WeAreTheChampions.UI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Matches", "MatchTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Matches", "MatchTime", c => c.DateTime());
        }
    }
}
