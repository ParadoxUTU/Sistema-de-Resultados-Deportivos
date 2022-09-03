using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaResultadosDeportivos.Grafica
{
    public class IDyPosicion
    {
        public int id { get; set; }
        public int posicion { get; set; }

        public IDyPosicion(int i, int p)
        {
            id = i;
            posicion = p;
        }
    }
}
