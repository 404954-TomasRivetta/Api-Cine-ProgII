using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Entidades
{
    public class Butaca
    {
        public int Fila { get; set; }
        public int Columna { get; set; }
        public int IdButaca { get; set; }
        public Butaca(int fila,int columna,int idFuncion,int idButaca)
        {
            Fila = fila;
            Columna = columna;
            IdButaca = idButaca;
        }

        public Butaca()
        {
                
        }
    }
}
