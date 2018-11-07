namespace Clase12.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Pelicula3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Idgenero", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Idgenero");
        }
    }
}
