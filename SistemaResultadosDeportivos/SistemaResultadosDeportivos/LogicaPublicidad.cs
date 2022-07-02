using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SistemaResultadosDeportivos.AccesoADatos;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace SistemaResultadosDeportivos
{
    class LogicaPublicidad
    {
        DatosPublicidad datosPublicidad;
        Random random;
        public string urlBanner;
        public string urlSitio;
        int randomPublicidad;

        public LogicaPublicidad() 
        {
            datosPublicidad = new DatosPublicidad();
            random = new Random();
            string[,] arr = datosPublicidad.getAllBanners();
            randomPublicidad = random.Next(0, arr.GetLength(0)); //tomo un numero random de 0 a la cantidad de filas de la tabla.
            urlBanner = arr[randomPublicidad, 1];
            urlSitio = arr[randomPublicidad, 0];
            
        }
        public LogicaPublicidad(DatosPublicidad datosPublicidad, Random random, string urlBanner, string urlSitio)
        {
            this.datosPublicidad = datosPublicidad;
            this.random = random;
            this.urlBanner = urlBanner;
            this.urlSitio = urlSitio;
        }

        public string getUrlBanner() { return urlBanner; }

        public string getUrlSitio() { return urlSitio; }
    }
}

