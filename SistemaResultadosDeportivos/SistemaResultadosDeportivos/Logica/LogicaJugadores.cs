﻿using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SistemaResultadosDeportivos.AccesoADatos;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SistemaResultadosDeportivos.Modelos;

namespace SistemaResultadosDeportivos.Logica
{
    public class LogicaJugadores
    {
        DatosJugador datosJugador;

        public LogicaJugadores()
        {
            datosJugador = new DatosJugador();
        }

        public List<Jugador> devolverJugadores()
        {
            //Devuelve una lista con los jugadores en la BD
            return datosJugador.getJugadores();
        }

        public List<Jugador> devolverJugadoresPorPlantel(int idEquipo)
        {
            //Devuelve una lista con los jugadores de un plantel en la BD
            return datosJugador.getJugadoresByPlantel(idEquipo);
        }

        public Jugador devolverJugadorPorID(int id)
        {
            //Devuelve un jugador en específico por ID
            return datosJugador.getJugadorByID(id);
        }

        public List<JugadorDeEncuentro> devolverJugadoresDeEncuentro(int idEncuentro)
        {
            //Devuelve los jugadores de encuentro dado un encuentro
            return datosJugador.getJugadoresDeEncuentro(idEncuentro);
        }

        public List<Jugador> devolverJugadoresPorDeporte(int idDeporte)
        {
            //Devuelve una lista con los jugadores pertenecientes a un deporte en la BD
            return datosJugador.getJugadoresByDeporte(idDeporte);
        }

        public List<Jugador> devolverJugadoresPorTorneo(int idTorneo)
        {
            //Devuelve una lista con los jugadores pertenecientes a un torneo en la BD
            return datosJugador.getJugadoresByTorneo(idTorneo);
        }

        public List<Jugador> devolverJugadoresPorEncuentro(int idEncuentro)
        {
            //Devuelve una lista con los jugadores pertenecientes a un encuentro en la BD
            return datosJugador.getJugadoresByEncuentro(idEncuentro);
        }

        public List<Jugador> devolverJugadoresPorEquipo(int idEquipo)
        {
            //Devuelve una lista con los jugadores pertenecientes a un equipo en la BD
            return datosJugador.getJugadoresByEquipo(idEquipo);
        }

        public bool agregarJugador(String nombreJugador, String fechaNac, int peso, int estatura, String pais, int idDeporte)
        {
            //Intenta agregar un jugador a la BD, con los datos dados
            return datosJugador.agregarJugador(nombreJugador, fechaNac, peso, estatura, pais, idDeporte);
        }

        public bool agregarJugadorAPlantel(int idJugador, int idEquipo)
        {
            //Intenta agregar un jugador a un plantel de la BD, con los datos dados
            return datosJugador.agregarJugadorAPlantel(idJugador, idEquipo);
        }

        public bool agregarJugadorATorneo(int idJugador, int idTorneo)
        {
            //Intenta agregar un jugador a un torneo de la BD, con los datos dados
            return datosJugador.agregarJugadorATorneo(idJugador, idTorneo);
        }

        public bool agregarJugadorAAlineacion(int idJugador, int idEquipo, int idEncuentro, int numero)
        {
            //Intenta agregar un jugador a una alineacion de la BD, con los datos dados
            return datosJugador.agregarJugadorAAlineacion(idJugador, idEquipo, idEncuentro, numero);
        }

        public bool eliminarJugador(int id)
        {
            //Intenta eliminar un jugador de la BD con la id dada
            return datosJugador.eliminarJugador(id);
        }

        public bool eliminarJugadorDeEncuentro(int idJugador, int idEncuentro)
        {
            //Intenta eliminar un jugador de un encuentro de la BD con la id dada
            return datosJugador.eliminarJugadorDeEncuentro(idJugador, idEncuentro);
        }

        public bool eliminarJugadorDeTorneo(int idTorneo, int idJugador)
        {
            //Intenta eliminar un jugador de un torneo de la BD con la id dada
            return datosJugador.eliminarJugadorDeTorneo(idJugador, idTorneo);
        }

        public bool eliminarJugadorDePlantel(int idEquipo, int idJugador)
        {
            //Intenta eliminar un jugador de un plantel de la BD con la id dada
            return datosJugador.eliminarJugadorDePlantel(idEquipo, idJugador);
        }

        public bool eliminarJugadorDeTodoEncuentro(int id)
        {
            //Intenta eliminar un jugador de todos los encuentros de la BD con la id dada
            return datosJugador.eliminarJugadorDeTodoEncuentro(id);
        }

        public bool eliminarJugadorDeTodoPlantel(int id)
        {
            //Intenta eliminar un jugador de todos los planteles de la BD con la id dada
            return datosJugador.eliminarJugadorDeTodoPlantel(id);
        }

        public bool eliminarJugadorDeTodaAlineacion(int id)
        {
            //Intenta eliminar un jugador de todas las alineaciones de la BD con la id dada
            return datosJugador.eliminarJugadorDeTodaAlineacion(id);
        }

        public bool eliminarJugadorDeTodaAnotacion(int id)
        {
            //Intenta eliminar un jugador de todas las anotaciones de la BD con la id dada
            return datosJugador.eliminarJugadorDeTodaAnotacion(id);
        }

        public bool eliminarJugadorDeTodoTorneo(int id)
        {
            //Intenta eliminar un jugador de todos los torneos de la BD con la id dada
            return datosJugador.eliminarJugadorDeTodoTorneo(id);
        }

        public bool eliminarJugadorDeTodoSet(int id)
        {
            //Intenta eliminar un jugador de todos los sets de la BD con la id dada
            return datosJugador.eliminarJugadorDeTodoSet(id);
        }

        public bool modificarJugador(int id, String nombreJugador, String fechaNac, int peso, int estatura, String pais, int idDeporte)
        {
            //Intenta modificar un jugador en la BD, con los datos dados
            return datosJugador.modificarJugador(id, nombreJugador, fechaNac, peso, estatura, pais, idDeporte);
        }

        public bool agregarOQuitarPuntos(int idJugador, int idEncuentro, int puntuacion)
        {
            //Intenta agregar o quitar puntos a un jugador en un encuentro dado
            return datosJugador.agregarOQuitarPuntosEncuentro(idJugador, idEncuentro, puntuacion);
        }

        public int devolverUltimaID()
        {
            //Devuelve la última ID generada.
            return datosJugador.getLastID();
        }
    }
}
