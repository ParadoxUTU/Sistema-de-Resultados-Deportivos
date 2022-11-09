using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaResultadosDeportivos.Modelos
{
    public class Notificacion
    {
        public String dirCorreo { get; set; }
        public String descripcion { get; set; }

        public Notificacion(string dirCorreo, string descripcion)
        {
            this.dirCorreo = dirCorreo;
            this.descripcion = descripcion;
        }
    }
}
