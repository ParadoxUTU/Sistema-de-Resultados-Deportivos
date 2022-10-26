using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaResultadosDeportivos.APIs
{
    internal class RespuestaRegistro
    {
        public bool exito { get; set; }

        public RespuestaRegistro(bool exito)
        {
            this.exito = exito;
        }
    }
}
