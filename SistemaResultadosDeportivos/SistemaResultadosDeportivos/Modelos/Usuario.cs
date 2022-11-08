using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaResultadosDeportivos.Modelos
{
    public class Usuario
    {
        public String correo { get; set; }
        public String nombre { get; set; }
        public int rol { get; set; }
        public String contrasena { get; set; }

        public Usuario(String c, String n, int r, String co)
        {
            correo = c;
            nombre = n;
            rol = r;
            contrasena = co;
        }
    }
}