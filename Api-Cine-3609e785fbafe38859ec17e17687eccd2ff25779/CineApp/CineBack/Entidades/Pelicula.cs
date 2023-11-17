﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Entidades
{
    public class Pelicula
    {
        public string Descripcion { get; set; }
        public int IdTipoPelicula { get; set; }
        public int IdIdioma { get; set; }
        public int IdTipoPublico { get; set; }
        public int Subtitulada { get; set; }
        public int IdDirector { get; set; }

        public int IdPelicula { get; set; }

        public Pelicula()
        {
            Descripcion = string.Empty;
            IdTipoPelicula = 0;
            IdIdioma = 0;
            IdTipoPelicula = 0;
            Subtitulada = 0;
            IdDirector = 0;
        }
        public Pelicula(string des,int tipo_pel,int idioma,int tipo_pub,int sub,int dir)
        {
            Descripcion =des;
            IdTipoPelicula =tipo_pel;
            IdIdioma =idioma;
            IdTipoPelicula =tipo_pub;
            Subtitulada =sub;
            IdDirector =dir;
        }
    }
}