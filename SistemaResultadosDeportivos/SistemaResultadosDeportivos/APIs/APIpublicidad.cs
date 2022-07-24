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
    public class APIpublicidad
    {
        private LogicaPublicidad p = new LogicaPublicidad();
        public string urlBanner { get; set; }
        public string urlSitio { get; set; }
        public APIpublicidad()
        {
            RespuestaPublicidad publicidad = p.publicidadRandom();
            urlBanner = publicidad.pathBanner;
            urlSitio = publicidad.urlSitio;
        }

        public String toJSON()
        {
            var json = JObject.FromObject(this);
            Console.WriteLine(json);
            return json.ToString();
        }
    }
}
