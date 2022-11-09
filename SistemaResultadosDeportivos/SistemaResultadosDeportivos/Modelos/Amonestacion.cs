using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaResultadosDeportivos.Modelos
{
    public class Amonestacion
    {
        public int idDeporte { get; set; }
        public String nombreAmonestacion { get; set; }

        public Amonestacion(int idDeporte, string nombreAmonestacion)
        {
            this.idDeporte = idDeporte;
            this.nombreAmonestacion = nombreAmonestacion;
        }
    }
}
