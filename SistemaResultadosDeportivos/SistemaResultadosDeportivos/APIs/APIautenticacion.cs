using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SistemaResultadosDeportivos
{
    internal class APIautenticacion
    {
        private LogicaUsuarios u;
        public bool exito;
        public int rol;

        public APIautenticacion()
        {
            u = new LogicaUsuarios();
        }

        public string loginToJSON(string e, string c)
        {
            exito = u.autenticar(e, c).exito;
            rol = u.autenticar(e, c).rol;
            var json = JObject.FromObject(this);
            return json.ToString();
        }
    }
}

