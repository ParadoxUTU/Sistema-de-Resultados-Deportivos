using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaResultadosDeportivos.Modelos
{
    public class Cambio
    {
        public int idCambio { get; set; }
        public int minuto { get; set; }
        public int idEncuentro { get; set; }
        public int idEquipo { get; set; }
        public int jugadorEntrante { get; set; }
        public int jugadorSaliente { get; set; }
        public int segundo { get; set; }

        public Cambio(int idCambio, int minuto, int idEncuentro, int idEquipo, int jugadorEntrante, int jugadorSaliente, int segundo)
        {
            this.idCambio = idCambio;
            this.minuto = minuto;
            this.idEncuentro = idEncuentro;
            this.idEquipo = idEquipo;
            this.jugadorEntrante = jugadorEntrante;
            this.jugadorSaliente = jugadorSaliente;
            this.segundo = segundo;
        }
    }
}
