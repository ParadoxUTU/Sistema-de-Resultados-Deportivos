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
    public class LogicaNotificaciones
    {
        DatosNotificacion datosNotificacion;

        public LogicaNotificaciones()
        {
            datosNotificacion = new DatosNotificacion();
        }

        public List<Notificacion> devolverNotificacionesPorMiembro(String dirCorreo)
        {
            //Devuelve una lista con las notificaciones pertenecientes a un usuario en la BD
            return datosNotificacion.getNotificacionesByMiembro(dirCorreo);
        }

        public bool agregarNotificacion(String dirCorreo, String descripcion)
        {
            //Intenta agregar una notificacion para un usuario
            return datosNotificacion.agregarNotificacion(dirCorreo, descripcion);
        }

        public bool eliminarNotificacionesPorUsuario(String dirCorreo)
        {
            //Intenta eliminar las notificaciones de un usuario
            return datosNotificacion.eliminarNotificacionesPorUsuario(dirCorreo);
        }

        public bool agregarSuscripcionAEquipo(String dirCorreo, int idEquipo)
        {
            //Intenta agregar una suscripcion a un equipo
            return datosNotificacion.agregarSuscripcionAEquipo(dirCorreo, idEquipo);
        }

        public List<String> devolverMiembrosPorSuscripcionEquipo(int idEquipo)
        {
            //Devuelve todos los usuarios sucritos a un equipo
            return datosNotificacion.getMiembrosPorSuscripcionEquipo(idEquipo);
        }

        public bool eliminarSuscripcionAEquipo(String dirCorreo, int idEquipo)
        {
            //Intenta eliminar una suscripcion de un equipo
            return datosNotificacion.eliminarSuscripcionAEquipo(dirCorreo, idEquipo);
        }

        public bool agregarSuscripcionAEncuentro(String dirCorreo, int idEncuentro)
        {
            //Intenta agregar una suscripcion a un encuentro
            return datosNotificacion.agregarSuscripcionAEncuentro(dirCorreo, idEncuentro);
        }

        public List<String> devolverMiembrosPorSuscripcionEncuentro(int idEncuentro)
        {
            //Devuelve todos los usuarios sucritos a un encuentro
            return datosNotificacion.getMiembrosPorSuscripcionEncuentro(idEncuentro);
        }

        public bool eliminarSuscripcionAEncuentro(String dirCorreo, int idEncuentro)
        {
            //Intenta eliminar una suscripcion de un encuentro
            return datosNotificacion.eliminarSuscripcionAEncuentro(dirCorreo, idEncuentro);
        }

        public bool agregarSuscripcionATorneo(String dirCorreo, int idTorneo)
        {
            //Intenta agregar una suscripcion a un torneo
            return datosNotificacion.agregarSuscripcionATorneo(dirCorreo, idTorneo);
        }

        public List<String> devolverMiembrosPorSuscripcionTorneo(int idTorneo)
        {
            //Devuelve todos los usuarios sucritos a un torneo
            return datosNotificacion.getMiembrosPorSuscripcionTorneo(idTorneo);
        }

        public bool eliminarSuscripcionATorneo(String dirCorreo, int idTorneo)
        {
            //Intenta eliminar una suscripcion de un torneo
            return datosNotificacion.eliminarSuscripcionATorneo(dirCorreo, idTorneo);
        }
    }
}
