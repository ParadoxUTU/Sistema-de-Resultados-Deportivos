/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaResultadosDeportivos
{
    internal class APIautenticacion
    {
        private LogicaUsuarios u = new LogicaUsuarios();
        public string username;
        public string contrasena;
        public string correoUsuario;
        public short rol;

        public APIautenticacion()
        {

        }
        public APIautenticacion(LogicaUsuarios u, string username, string contrasena, string correoUsuario, short rol)
        {
            this.u = u;
            this.username = username;
            this.contrasena = contrasena;
            this.correoUsuario = correoUsuario;
            this.rol = rol;
        }

        public string crearUsuario()
        {
            bool valido = u.agregarUsuario(correoUsuario, contrasena, username, rol);
            return serializar(valido.ToString());
        }

        public string login()
        {
            bool valido = u.login(correoUsuario, contrasena);
            return serializar(valido.ToString());
        }

        public string serializar(string entrada)
        {
            return JObject.FromObject(entrada).ToString();
        }

        public string toJSON()
        {
            return JObject.FromObject(this).ToString();
        }
    }
}*/

