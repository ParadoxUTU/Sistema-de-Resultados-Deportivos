using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SistemaResultadosDeportivos.Logica;
using SistemaResultadosDeportivos.Modelos;

namespace SistemaResultadosDeportivos.APIs
{
    public class APIresultados
    {
        private LogicaEncuentros lge;
        private LogicaAnotaciones lga;
        private LogicaSets lgs;
        private LogicaDeportes lgd;
        private LogicaEquipos lgeq;
        private LogicaJugadores lgj;

        public APIresultados()
        {
            lge = new LogicaEncuentros();
            lga = new LogicaAnotaciones();
            lgs = new LogicaSets();
            lgd = new LogicaDeportes();
            lgeq = new LogicaEquipos();
            lgj = new LogicaJugadores();
        }

        public List<String> encuentrosToJSON()
        {
            List<Encuentro> lista = lge.devolverEncuentros();
            List<String> listJson = new List<String>();
            foreach(Encuentro e in lista)
            {
                JObject json = JObject.FromObject(e);
                listJson.Add(json.ToString());
            }
            return listJson;
        }

        public String getDeporte(int idDeporte)
        {
            JObject json = JObject.FromObject(lgd.devolverDeportePorID(idDeporte));
            return json.ToString();
        }

        public String getAnotacionesEquipo(int idEncuentro, int idEquipo)
        {
            JObject json = JObject.FromObject(lga.devolverAnotacionesEquipoEnObjeto(idEncuentro, idEquipo));
            return json.ToString();
        }

        public List<String> getSetsEquipo(int idEquipo, int idEncuentro)
        {
            List<Set> lista = lgs.devolverSetsEquipoEncuentro(idEquipo, idEncuentro);
            List<String> listJson = new List<String>();
            foreach (Set s in lista)
            {
                JObject json = JObject.FromObject(s);
                listJson.Add(json.ToString());
            }
            return listJson;
        }

        public List<String> getSetsJugador(int idJugador, int idEncuentro)
        {
            List<Set> lista = lgs.devolverSetsJugadorEncuentro(idJugador, idEncuentro);
            List<String> listJson = new List<String>();
            foreach (Set s in lista)
            {
                JObject json = JObject.FromObject(s);
                listJson.Add(json.ToString());
            }
            return listJson;
        }

        public List<String> getEquiposPorEncuentro(int idEncuentro)
        {
            List<Equipo> lista = lgeq.devolverEquiposPorEncuentro(idEncuentro);
            List<String> listJson = new List<String>();
            foreach(Equipo e in lista)
            {
                JObject json = JObject.FromObject(e);
                listJson.Add(json.ToString());
            }
            return listJson;
        }

        public List<String> getJugadoresPorEncuentro(int idEncuentro)
        {
            List<Jugador> lista = lgj.devolverJugadoresPorEncuentro(idEncuentro);
            List<String> listJson = new List<String>();
            foreach (Jugador e in lista)
            {
                JObject json = JObject.FromObject(e);
                listJson.Add(json.ToString());
            }
            return listJson;
        }

        public List<String> getJugadoresDeEncuentro(int idEncuentro)
        {
            List<JugadorDeEncuentro> lista = lgj.devolverJugadoresDeEncuentro(idEncuentro);
            List<String> listJson = new List<String>();
            foreach (JugadorDeEncuentro e in lista)
            {
                JObject json = JObject.FromObject(e);
                listJson.Add(json.ToString());
            }
            return listJson;
        }

        public List<String> getEquiposPorDeporte(int idDeporte)
        {
            List<Equipo> lista = lgeq.devolverEquiposPorDeporte(idDeporte);
            List<String> listJson = new List<String>();
            foreach (Equipo e in lista)
            {
                JObject json = JObject.FromObject(e);
                listJson.Add(json.ToString());
            }
            return listJson;
        }

        public List<String> getEquiposPorTorneo(int idTorneo)
        {
            List<Equipo> lista = lgeq.devolverEquiposPorTorneo(idTorneo);
            List<String> listJson = new List<String>();
            foreach (Equipo e in lista)
            {
                JObject json = JObject.FromObject(e);
                listJson.Add(json.ToString());
            }
            return listJson;
        }
    }
}
