namespace Clase12.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creacioncliente : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoClientes",
                c => new
                    {
                        id = c.Byte(nullable: false),
                        Nombre = c.String(),
                        costoSuscripcion = c.Short(nullable: false),
                        duracionSbcEnMeses = c.Byte(nullable: false),
                        porcDescuento = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Clientes", "estaInscritoRevista", c => c.Boolean(nullable: false));
            AddColumn("dbo.Clientes", "idTipoCliente", c => c.Byte(nullable: false));
            AddColumn("dbo.Clientes", "TipoCliente_id", c => c.Byte());
            CreateIndex("dbo.Clientes", "TipoCliente_id");
            AddForeignKey("dbo.Clientes", "TipoCliente_id", "dbo.TipoClientes", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clientes", "TipoCliente_id", "dbo.TipoClientes");
            DropIndex("dbo.Clientes", new[] { "TipoCliente_id" });
            DropColumn("dbo.Clientes", "TipoCliente_id");
            DropColumn("dbo.Clientes", "idTipoCliente");
            DropColumn("dbo.Clientes", "estaInscritoRevista");
            DropTable("dbo.TipoClientes");
        }
    }
}
