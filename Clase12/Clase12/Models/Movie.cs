using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Clase12.Models
{
    public class Movie
    {

        
        public byte Id { get; set; }
        public String Nombre { get; set; }

        public Genero genero { get; set; }

        public byte Idgenero { get; set; }

      

        
    }
}