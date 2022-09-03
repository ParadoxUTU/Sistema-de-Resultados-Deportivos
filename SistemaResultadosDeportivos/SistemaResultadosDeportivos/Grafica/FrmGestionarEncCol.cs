using SistemaResultadosDeportivos.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaResultadosDeportivos.Logica;
using System.Drawing;

namespace SistemaResultadosDeportivos
{
    public partial class FrmGestionarEncCol : Form
    {
        public LogicaAnotaciones lga;
        public LogicaEncuentros lge;
        public LogicaSets lgs;
        public Encuentro encuentro;
        public Equipo equipo1;
        public Equipo equipo2;
        Deporte deporte;

        public FrmGestionarEncCol(Encuentro en, Equipo eq1, Equipo eq2, Deporte dep)
        {
            InitializeComponent();
            lga = new LogicaAnotaciones();
            lge = new LogicaEncuentros();
            lgs = new LogicaSets();
            encuentro = en;
            equipo1 = eq1;
            equipo2 = eq2;
            deporte = dep;
            lblEquipo1.Text = equipo1.nombreEquipo;
            lblEquipo2.Text = equipo2.nombreEquipo;
            if (deporte.anotaciones)
            {
                setAnotacionesEquipo(en.idEncuentro, equipo1.idEquipo, lblPuntaje1);
                setAnotacionesEquipo(en.idEncuentro, equipo2.idEquipo, lblPuntaje2);
            }
            else
            {
                List<Set> sets1 = lgs.devolverSetsEquipoEncuentro(equipo1.idEquipo, encuentro.idEncuentro);
                List<Set> sets2 = lgs.devolverSetsEquipoEncuentro(equipo2.idEquipo, encuentro.idEncuentro);
                if(sets1.Count > 0)
                {
                    lblPuntaje1.Text = sets1[sets1.Count - 1].numeroSet.ToString();
                }
                else
                {
                    lblPuntaje1.Text = "0";
                }
                if(sets2.Count > 0)
                {
                    lblPuntaje2.Text = sets2[sets2.Count - 1].numeroSet.ToString();
                }
                else
                {
                    lblPuntaje2.Text = "0";
                }
            }
            
        }

        public void setAnotacionesEquipo(int idEncuentro, int idEquipo, Label lbl)
        {
            int puntaje = lga.devolverAnotacionesEquipo(idEncuentro, idEquipo);
            lbl.Text = puntaje.ToString();
        }

        public void setSetsEquipo(int idSet, Label lbl)
        {
            Set set = lgs.devolverSetPorID(idSet);
            lbl.Text = set.numeroSet.ToString();
        }

        private void btnAgregarPuntos1_Click(object sender, EventArgs e)
        {
            if (deporte.anotaciones)
            {
                int minuto = Int32.Parse(lblMinuto.Text);
                FrmSeleccionarJugadorAnotacion frmsja = new FrmSeleccionarJugadorAnotacion(this, equipo1, lblPuntaje1);
                frmsja.Visible = true;
                frmsja.listarJugadoresPorAlineacion(equipo1.idEquipo, encuentro.idEncuentro);
            }
            else if (deporte.sets)
            {
                int puntajeActual = int.Parse(lblPuntaje1.Text);
                lgs.agregarSet(puntajeActual + 1, 0);
                int idSet = lgs.devolverUltimaID();
                lgs.agregarSetEquipo(idSet, equipo1.idEquipo, encuentro.idEncuentro);
                setSetsEquipo(idSet, lblPuntaje1);
            }
        }

        private void btnAgregarPuntos2_Click(object sender, EventArgs e)
        {
            if (deporte.anotaciones)
            {
                int minuto = Int32.Parse(lblMinuto.Text);
                FrmSeleccionarJugadorAnotacion frmsja = new FrmSeleccionarJugadorAnotacion(this, equipo2, lblPuntaje2);
                frmsja.Visible = true;
                frmsja.listarJugadoresPorAlineacion(equipo2.idEquipo, encuentro.idEncuentro);
            }
            else if (deporte.sets)
            {
                int puntajeActual = int.Parse(lblPuntaje2.Text);
                lgs.agregarSet(puntajeActual + 1, 0);
                int idSet = lgs.devolverUltimaID();
                lgs.agregarSetEquipo(idSet, equipo2.idEquipo, encuentro.idEncuentro);
                setSetsEquipo(idSet, lblPuntaje2);
            }

        }

        private void FrmGestionarEncCol_Load(object sender, EventArgs e)
        {
            flpIncidencias.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
        }
    }
}
