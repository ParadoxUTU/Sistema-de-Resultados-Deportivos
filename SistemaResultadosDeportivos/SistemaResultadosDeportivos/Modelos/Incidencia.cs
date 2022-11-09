using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaResultadosDeportivos.Modelos
{
    public class Incidencia
    {
        public int idIncidencia { get; set; }
        public string tipoIncidencia { get; set; }
        public int minuto { get; set; }
        public int segundo { get; set; }

        public int idEquipo { get; set; }
        public int idJugador1 { get; set; }
        public int idJugador2 { get; set; }

        public Incidencia(int idIncidencia, string tipoIncidencia, int minuto, int segundo, int idEquipo, int idJugador1, int idJugador2)
        {
            this.idIncidencia = idIncidencia;
            this.tipoIncidencia = tipoIncidencia;
            this.minuto = minuto;
            this.segundo = segundo;
            this.idEquipo = idEquipo;
            this.idJugador1 = idJugador1;
            this.idJugador2 = idJugador2;
        }
    }
}
