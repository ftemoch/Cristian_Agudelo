﻿using Clase12.Migrations;
using Clase12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clase12.ViewModels
{
    public class NewMovieViewModel
    {


        public IEnumerable<Genero> Generos { get; set; }

       
        public Movie Movie { get; set; }

    }
}