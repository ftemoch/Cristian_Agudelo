namespace Clase12.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class llenarDatos : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO  TipoCliente (Id,Nombre,costoSuscripcion,duracionSbcEnMeses,porcDescuento) values (1,0,0,0,paga lo que lleva)");
            Sql("INSERT INTO  TipoCliente (Id,Nombre,costoSuscripcion,duracionSbcEnMeses,porcDescuento) values (2,1,0,0,paga lo que lleva)");
            Sql("INSERT INTO  TipoCliente (Id,Nombre,costoSuscripcion,duracionSbcEnMeses,porcDescuento) values (3,quincena1,90,3,15)");
            Sql("INSERT INTO  TipoCliente (Id,Nombre,costoSuscripcion,duracionSbcEnMeses,porcDescuento) values (4,anual,300,12,20)");
        }


    public override void Down()
        {
        }
    }
}
