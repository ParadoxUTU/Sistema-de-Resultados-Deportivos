using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaResultadosDeportivos.AccesoADatos;

namespace SistemaResultadosDeportivos
{
    internal class LogicaUsuarios
    {
        private AccesoADatos.DatosUsuario dt;
        public string correoUsuario;
        public string username;
        public string contrasena;
        public short rol;

        public LogicaUsuarios(DatosUsuario dt, string correoUsuario, string username, string contrasena, short rol)
        {
            this.dt = dt;
            this.correoUsuario = correoUsuario;
            this.username = username;
            this.contrasena = contrasena;
            this.rol = rol;
        }

        public bool agregarUsuario()
        {
            return dt.agregarUsuario(correoUsuario, username, contrasena, rol);
        }

        public bool eliminarUsuario()
        {
            return dt.eliminarUsuario(correoUsuario);
        }
    }
}
