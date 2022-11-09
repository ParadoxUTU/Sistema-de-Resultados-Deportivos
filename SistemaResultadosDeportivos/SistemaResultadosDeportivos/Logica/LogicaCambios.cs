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
    public class LogicaCambios
    {
        DatosCambio datosCambio;

        public LogicaCambios()
        {
            datosCambio = new DatosCambio();
        }

        public List<Cambio> devolverCambiosPorEncuentro(int idEncuentro)
        {
            //Devuelve una lista con los cambios pertenecientes a un encuentro en la BD
            return datosCambio.getCambiosByEncuentro(idEncuentro);
        }

        public bool agregarCambio(int minuto, int idEncuentro, int idEquipo, int jugadorEntrante, int jugadorSaliente)
        {
            //Agrega un cambio a un encuentro
            return datosCambio.agregarCambio(minuto, idEncuentro, idEquipo, jugadorEntrante, jugadorSaliente);
        }
    }
}
