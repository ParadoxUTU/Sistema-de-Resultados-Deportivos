using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaResultadosDeportivos.Modelos;
using SistemaResultadosDeportivos.AccesoADatos;


namespace SistemaResultadosDeportivos
{
    internal class LogicaUsuarios
    {
        private DatosUsuario dt;

        public LogicaUsuarios()
        {
            dt = new DatosUsuario();
        }
        public Logica.RespuestaAutenticacion autenticar(String correo, String contrasena)
        {
            Usuario usuario = dt.getPorId(correo);
            Logica.RespuestaAutenticacion res;
            if (usuario != null && dt.testConexion(correo, contrasena))
            {
                dt.actualizarConexion(correo, contrasena);
                res = new Logica.RespuestaAutenticacion(true, usuario.rol);
            }
            else
            {
                res = new Logica.RespuestaAutenticacion(false, -1);
            }
            return res;
        }

        public bool registrarUsuario(String correo, String nombre, String contrasena, int rol)
        {
            return dt.agregarUsuario(correo, nombre, contrasena, rol);
        }
        public bool bajaUsuario(String correo)
        {
            return dt.eliminarUsuario(correo);
        }
    }
}
