using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SistemaResultadosDeportivos.AccesoADatos;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SistemaResultadosDeportivos.Modelos;

namespace SistemaResultadosDeportivos
{
    public partial class LogicaPublicidad
    {
        DatosPublicidad datosPublicidad;
        Random random;

        public LogicaPublicidad()
        {
            datosPublicidad = new DatosPublicidad();
            random = new Random();
        }

        public RespuestaPublicidad publicidadRandom()
        {
            List<Publicidad> lista = datosPublicidad.getPublicidades();
            RespuestaPublicidad res;
            if(lista.Count > 0)
            {
                Publicidad publicidad = lista[random.Next(0, lista.Count)];
                String pathBanner = publicidad.pathBanner;
                String urlSitio = publicidad.urlSitio;
                res = new RespuestaPublicidad(pathBanner, urlSitio);
            }
            else
            {
                res = null;
            }
            return res;
        }

        public List<Publicidad> devolverPublicidades()
        {
            return datosPublicidad.getPublicidades();
        }

        public bool agregarPublicidad(String marca, String pathBanner, String urlSitio)
        {
            return datosPublicidad.agregarPublicidad(marca, pathBanner, urlSitio);
        }

        public bool eliminarPublicidad(String id)
        {
            return datosPublicidad.eliminarPublicidad(id);
        }

        public bool modificarPublicidad(int id, String marca, String pathBanner, String urlSitio)
        {
            return datosPublicidad.modificarPublicidad(id, marca, pathBanner, urlSitio);
        }
    }
}

