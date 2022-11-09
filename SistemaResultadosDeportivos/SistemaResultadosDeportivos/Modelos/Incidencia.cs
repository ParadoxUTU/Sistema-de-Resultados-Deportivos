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
        public String tipoIncidencia { get; set; }

        public Incidencia(int id, String tI)
        {
            idIncidencia = id;
            tipoIncidencia = tI;
        }
    }
}
