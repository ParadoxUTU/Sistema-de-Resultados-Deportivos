using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaResultadosDeportivos.Logica;
using SistemaResultadosDeportivos.Modelos;

namespace SistemaResultadosDeportivos
{
    public partial class FrmGestionarEncIndDeADos : Form
    {
        public LogicaAnotaciones lga;
        public LogicaEncuentros lge;
        public LogicaSets lgs;
        public Encuentro encuentro;
        public Jugador jugador1;
        public Jugador jugador2;
        public Deporte deporte;

        public FrmGestionarEncIndDeADos(Encuentro en, Jugador jug1, Jugador jug2, Deporte dep)
        {
            InitializeComponent();
            lga = new LogicaAnotaciones();
            lge = new LogicaEncuentros();
            lgs = new LogicaSets();
            encuentro = en;
            jugador1 = jug1;
            jugador2 = jug2;
            deporte = dep;
            lblJugador1.Text = jugador1.nombreJugador;
            lblJugador2.Text = jugador2.nombreJugador;
            setSetsJugador(jugador1.idJugador, lblPuntaje1);
            setSetsJugador(jugador2.idJugador, lblPuntaje2);
        }

        private void FrmGestionarEncIndDeADos_Load(object sender, EventArgs e)
        {
            flpIncidencias.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
        }

        public void agregarSet(Jugador jugador, int puntuacion)
        {
            int numSetActual = lgs.getMaxNumSetJug(encuentro.idEncuentro);
            lgs.agregarSet(numSetActual + 1, puntuacion);
            int idSet = lgs.devolverUltimaID();
            lgs.agregarSetJugador(idSet, jugador.idJugador, encuentro.idEncuentro);
        }

        public void setSetsJugador(int idJugador, Label lbl)
        {
            List<Set> setsJugador = lgs.devolverSetsJugadorEncuentro(idJugador, encuentro.idEncuentro);
            lbl.Text = "";
            foreach (Set set in setsJugador)
            {
                lbl.Text += " " + set.puntuacionSet;
            }
        }

        private void btnAgregarPuntos1_Click(object sender, EventArgs e)
        {
            new SubFrmDatosSetJug(this, jugador1, lblPuntaje1).Visible = true;
            setSetsJugador(jugador1.idJugador, lblPuntaje1);
        }

        private void btnAgregarPuntos2_Click(object sender, EventArgs e)
        {
            new SubFrmDatosSetJug(this, jugador2, lblPuntaje2).Visible = true;
            setSetsJugador(jugador2.idJugador, lblPuntaje2);
        }
    }
}
