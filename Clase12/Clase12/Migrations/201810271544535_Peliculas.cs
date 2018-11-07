namespace Clase12.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Peliculas : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Movies", new[] { "Genero_Id" });
            DropPrimaryKey("dbo.Movies");
            AlterColumn("dbo.Movies", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Movies", "Id");
            CreateIndex("dbo.Movies", "genero_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Movies", new[] { "genero_Id" });
            DropPrimaryKey("dbo.Movies");
            AlterColumn("dbo.Movies", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Movies", "ID");
            CreateIndex("dbo.Movies", "Genero_Id");
        }
    }
}
