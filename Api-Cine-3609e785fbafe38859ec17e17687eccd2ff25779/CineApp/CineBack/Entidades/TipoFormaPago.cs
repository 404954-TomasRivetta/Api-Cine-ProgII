﻿namespace CineBack.Entidades
{
    public class TipoFormaPago
    {
        public int id { get; set; }
        public string Descripcion { get; set; }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
