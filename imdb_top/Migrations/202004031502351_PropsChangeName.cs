namespace imdb_top.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PropsChangeName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Release", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "Imdb", c => c.Single(nullable: false));
            AddColumn("dbo.Serials", "Release", c => c.Int(nullable: false));
            AddColumn("dbo.Serials", "Imdb", c => c.Single(nullable: false));
            DropColumn("dbo.Movies", "ReleaseYear");
            DropColumn("dbo.Movies", "ImdbRank");
            DropColumn("dbo.Serials", "ReleaseYear");
            DropColumn("dbo.Serials", "ImdbRank");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Serials", "ImdbRank", c => c.Single(nullable: false));
            AddColumn("dbo.Serials", "ReleaseYear", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "ImdbRank", c => c.Single(nullable: false));
            AddColumn("dbo.Movies", "ReleaseYear", c => c.Int(nullable: false));
            DropColumn("dbo.Serials", "Imdb");
            DropColumn("dbo.Serials", "Release");
            DropColumn("dbo.Movies", "Imdb");
            DropColumn("dbo.Movies", "Release");
        }
    }
}
