namespace imdb_top.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDateProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleaseYear", c => c.Int(nullable: false));
            AddColumn("dbo.Serials", "ReleaseYear", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "ReleaseDate");
            DropColumn("dbo.Serials", "ReleaseDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Serials", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Serials", "ReleaseYear");
            DropColumn("dbo.Movies", "ReleaseYear");
        }
    }
}
