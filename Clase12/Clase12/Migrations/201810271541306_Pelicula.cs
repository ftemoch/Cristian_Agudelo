namespace Clase12.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Pelicula : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Generoes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Nombre = c.String(),
                        Coartada = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "Genero_Id", c => c.Byte());
            CreateIndex("dbo.Movies", "Genero_Id");
            AddForeignKey("dbo.Movies", "Genero_Id", "dbo.Generoes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Genero_Id", "dbo.Generoes");
            DropIndex("dbo.Movies", new[] { "Genero_Id" });
            DropColumn("dbo.Movies", "Genero_Id");
            DropTable("dbo.Generoes");
        }
    }
}
