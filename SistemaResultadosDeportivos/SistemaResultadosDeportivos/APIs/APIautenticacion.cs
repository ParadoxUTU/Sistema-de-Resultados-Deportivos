using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SistemaResultadosDeportivos.Logica;

namespace SistemaResultadosDeportivos.APIs
{
    public class APIautenticacion
    {
        private LogicaUsuarios lgu;

        public APIautenticacion()
        {
            lgu = new LogicaUsuarios();
        }

        public string loginToJSON(string correo, string con)
        {
            //Devuelve la respuesta de autenticacion en formato JSON
            var json = JObject.FromObject(lgu.autenticar(correo, con));
            return json.ToString();
        }

        public string registroToJSON(string correo, string username, string con, int rol)
        {
            //Devuelve la respuesta de registro en formato JSON
            var json = JObject.FromObject(lgu.registrarUsuarioAPI(correo, username, con, rol));
            return json.ToString();
        }
    }
}

