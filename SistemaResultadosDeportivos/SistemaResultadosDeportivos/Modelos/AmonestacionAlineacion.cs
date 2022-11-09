using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaResultadosDeportivos.Modelos
{
    public class AmonestacionAlineacion
    {
        public int idEquipo { get; set; }
        public int idEncuentro { get; set; }
        public int idJugador { get; set; }
        public int idDeporte { get; set; }
        public String nombreAmonestacion { get; set; }
        public int minuto { get; set; }
        public int segundo { get; set; }

        public AmonestacionAlineacion(int idEquipo, int idEncuentro, int idJugador, int idDeporte, string nombreAmonestacion, int minuto, int segundo)
        {
            this.idEquipo = idEquipo;
            this.idEncuentro = idEncuentro;
            this.idJugador = idJugador;
            this.idDeporte = idDeporte;
            this.nombreAmonestacion = nombreAmonestacion;
            this.minuto = minuto;
            this.segundo = segundo;
        }
    }
}
