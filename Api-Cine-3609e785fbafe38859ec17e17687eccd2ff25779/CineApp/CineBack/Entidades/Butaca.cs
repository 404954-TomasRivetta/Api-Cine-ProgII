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
        public int IdFuncion { get; set; } 
        public int IdButaca { get; set; }
        public int EstadoButaca { get; set; }
        public Butaca(int fila,int columna,int idFuncion,int idButaca)
        {
            Fila = fila;
            Columna = columna;
            IdFuncion = idFuncion;
            IdButaca = idButaca;
        }

        public Butaca()
        {
                
        }
    }
}
