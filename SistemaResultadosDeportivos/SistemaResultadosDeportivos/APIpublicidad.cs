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
        public string urlBanner;
        public string urlSitio;
        public APIpublicidad()
        {
            urlBanner = p.getUrlBanner();
            urlSitio = p.getUrlSitio();
        }

        public string getUrlBanner() { return urlBanner; }
        public string getUrlSitio() { return urlSitio; }

        public String toJSON()
        {
            var json = JObject.FromObject(this);
            Console.WriteLine(json);
            return json.ToString();
        }
    }
}
