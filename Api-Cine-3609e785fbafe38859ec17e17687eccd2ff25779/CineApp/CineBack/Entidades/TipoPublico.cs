﻿namespace CineBack.Entidades
{
    public class TipoPublico
    {
        public int IdTipoPublico { get; set; }
        public string Descripcion { get; set; }
        public override string ToString()
        {
            return Descripcion;
        }
        public TipoPublico(int id, string desc)
        {
            IdTipoPublico = id;
            Descripcion = desc;
        }
    }
}
