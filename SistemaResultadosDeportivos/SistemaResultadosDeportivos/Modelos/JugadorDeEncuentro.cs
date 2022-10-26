using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaResultadosDeportivos.Modelos
{
    public class JugadorDeEncuentro
    {
        public int idEncuentro { get; set; }
        public int idJugador { get; set; }
        public int puesto { get; set; }
        public int puntuacion { get; set; }
        public String nombreJugador { get; set; }
        public String pais { get; set; }

        public JugadorDeEncuentro(int idE, int idJ, int pue, int pun, string nJ, string pa)
        {
            idEncuentro = idE;
            idJugador = idJ;
            puesto = pue;
            puntuacion = pun;
            nombreJugador = nJ;
            pais = pa;
        }
    }
}
