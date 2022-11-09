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
    public class LogicaIncidencias
    {
        DatosIncidencias datosAnotacion;

        public LogicaIncidencias()
        {
            datosAnotacion = new DatosIncidencias();
        }

        public List<Anotacion> devolverAnotacionesPorEncuentro(int idEncuentro)
        {
            //Devuelve una lista con las anotaciones pertenecientes a un encuentro en la BD
            return datosAnotacion.getAnotacionesByEncuentro(idEncuentro);
        }

        public List<Anotacion> devolverAnotacionesPorEncuentroYEquipo(int idEncuentro, int idEquipo)
        {
            //Devuelve una lista con las anotaciones de un equipo pertenecientes a un encuentro en la BD
            return datosAnotacion.getAnotacionesByEncuentroAndEquipo(idEncuentro, idEquipo);
        }

        public int devolverAnotacionesEquipo(int idEncuentro, int idEquipo)
        {
            //Suma las anotaciones de un equipo en un encuentro para determinar su puntaje
            return datosAnotacion.getSumAnotaciones(idEncuentro, idEquipo);
        }

        public bool agregarAnotacion(int idJugador, int minuto, int idEquipo, int idEncuentro, int puntuacion)
        {
            //Agrega una anotación a un equipo en determinado encuentro
            return datosAnotacion.agregarAnotacion(idJugador, minuto, idEquipo, idEncuentro, puntuacion);
        }


        public bool eliminarAnotacion(int id)
        {
            //Intenta eliminar una anotación de la BD con la id dada
            return datosAnotacion.eliminarAnotacion(id);
        }

        public bool eliminarAnotacionesDeEncuentro(int idEncuentro)
        {
            //Intenta eliminar todas las anotaciones de un encuentro
            return datosAnotacion.eliminarAnotacionesDeEncuentro(idEncuentro);
        }

        public RespuestaAnotaciones devolverAnotacionesEquipoEnObjeto(int idEncuentro, int idEquipo)
        {
            //Suma las anotaciones de un equipo en un encuentro para determinar su puntaje y lo devuelve en un objeto de respuesta
            int puntaje = datosAnotacion.getSumAnotaciones(idEncuentro, idEquipo);
            RespuestaAnotaciones res = new RespuestaAnotaciones(puntaje);
            return res;
        }

        public List<AmonestacionAlineacion> devolverAmonestacionesPorEncuentroo(int idEncuentro, int idEquipo)
        {
            //Devuelve una lista con las amonestaciones pertenecientes a un encuentro en la BD
            return datosAnotacion.getAmonestacionesByEncuentro(idEncuentro);
        }

        public bool agregarAmonestacionAlineacion(int idEquipo, int idEncuentro, int idJugador, int idDeporte, string nombreAmonestacion, int minuto)
        {
            //Agrega una amonestacion a un jugador en determinado encuentro
            return datosAnotacion.agregarAmonestacionAlineacion(idEquipo, idEncuentro, idJugador, idDeporte, nombreAmonestacion, minuto);
        }

        public bool eliminarAmonestacion(int idEquipo, int idEncuentro, int idJugador, int idDeporte, string nombreAmonestacion, int minuto)
        {
            //Elimina una amonestacion a un jugador en determinado encuentro
            return datosAnotacion.eliminarAmonestacionDeEncuentro(idEquipo, idEncuentro, idJugador, idDeporte, nombreAmonestacion, minuto);
        }
    }
}
