using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clase12.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public bool estaInscritoRevista { get; set; }
        public TipoCliente TipoCliente { get; set; }
        public byte idTipoCliente { get; set; }

    }
}