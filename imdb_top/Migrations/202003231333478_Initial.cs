namespace imdb_top.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        ImdbRank = c.Single(nullable: false),
                        GenreId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .Index(t => t.GenreId);
            
            CreateTable(
                "dbo.Serials",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                        Seasons = c.Int(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                        ImdbRank = c.Single(nullable: false),
                        GenreId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .Index(t => t.GenreId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Serials", "GenreId", "dbo.Genres");
            DropForeignKey("dbo.Movies", "GenreId", "dbo.Genres");
            DropIndex("dbo.Serials", new[] { "GenreId" });
            DropIndex("dbo.Movies", new[] { "GenreId" });
            DropTable("dbo.Serials");
            DropTable("dbo.Movies");
            DropTable("dbo.Genres");
        }
    }
}
