using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SistemaResultadosDeportivos.AccesoADatos;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SistemaResultadosDeportivos.Modelos;
using SistemaResultadosDeportivos.APIs;

namespace SistemaResultadosDeportivos.Logica
{
    public class LogicaAmonestaciones
    {
        DatosAmonestacion datosAmonestacion;

        public LogicaAmonestaciones()
        {
            datosAmonestacion = new DatosAmonestacion();
        }

        public List<Amonestacion> devolverAmonestacionesPorDeporte(int idDeporte)
        {
            //Devuelve una lista con las amonestaciones pertenecientes a un deporte en la BD
            return datosAmonestacion.getAmonestacionesByDeporte(idDeporte);
        }

        public bool agregarAmonestacion(int idDeporte, String nombre)
        {
            //Agrega una amonestacion a un deporte
            return datosAmonestacion.agregarAmonestacion(idDeporte, nombre);
        }

        public bool eliminarAmonestacion(int idDeporte, String nombre)
        {
            //Elimina una amonestacion de un deporte
            return datosAmonestacion.eliminarAmonestacion(idDeporte, nombre);
        }
    }
}
