using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SistemaResultadosDeportivos
{
    class APIpublicidad
    {
        private LogicaPublicidad p = new LogicaPublicidad();
        public string urlBanner { get; set; }
        public string urlSitio { get; set; }
        public APIpublicidad()
        {
            urlBanner = p.publicidadRandom().pathBanner;
            urlSitio = p.publicidadRandom().urlSitio;
        }

        public String toJSON()
        {
            var json = JObject.FromObject(this);
            Console.WriteLine(json);
            return json.ToString();
        }
    }
}
