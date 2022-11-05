using SistemaResultadosDeportivos.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaResultadosDeportivos.Logica;
using System.Drawing;
using System.Windows;
using System.Diagnostics;

namespace SistemaResultadosDeportivos
{
    public partial class FrmGestionarEncCol : Form
    {
        public Stopwatch oSW = new Stopwatch();
        public TimeSpan ts;
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
                setSetsEquipo(equipo1.idEquipo, lblPuntaje1);
                setSetsEquipo(equipo2.idEquipo, lblPuntaje2); 
            }
            ts = new TimeSpan(0, 0, encuentro.minActual, 0, (int)oSW.ElapsedMilliseconds);
            lblMinuto.Text = ts.Minutes.ToString();
            actualizarBotones();
        }

        public void actualizarBotones()
        {
            if (!encuentro.comenzo)
            {
                btnIniciar.Enabled = true;
                btnPausar.Enabled = false;
                btnFinalizar.Enabled = false;
                btnReanudar.Enabled = false;
                btnAgregarPuntos1.Enabled = false;
                btnAgregarPuntos2.Enabled = false;
            }
            else if (encuentro.comenzo && !encuentro.pausado && !encuentro.finalizo)
            {
                btnIniciar.Enabled = false;
                btnPausar.Enabled = true;
                btnFinalizar.Enabled = true;
                btnReanudar.Enabled = false;
                btnAgregarPuntos1.Enabled = true;
                btnAgregarPuntos2.Enabled = true;
            }
            else if(!encuentro.finalizo && encuentro.pausado)
            {
                btnIniciar.Enabled = false;
                btnPausar.Enabled = false;
                btnFinalizar.Enabled = true;
                btnReanudar.Enabled = true;
                btnAgregarPuntos1.Enabled = false;
                btnAgregarPuntos2.Enabled = false;
            }
            else if (encuentro.finalizo)
            {
                btnIniciar.Enabled = false;
                btnPausar.Enabled = false;
                btnFinalizar.Enabled = false;
                btnReanudar.Enabled = false;
                btnAgregarPuntos1.Enabled = false;
                btnAgregarPuntos2.Enabled = false;
            }
        }

        public void iniciarTimer()
        {
            ts = new TimeSpan(0, 0, encuentro.minActual, 0, (int)oSW.ElapsedTicks);
            oSW.Start();
            timer1.Enabled = true;
        }

        public void detenerTimer()
        {
            oSW.Stop();
            timer1.Enabled = false;
        }

        public void setAnotacionesEquipo(int idEncuentro, int idEquipo, Label lbl)
        {
            int puntaje = lga.devolverAnotacionesEquipo(idEncuentro, idEquipo);
            lbl.Text = puntaje.ToString();
        }

        public void setSetsEquipo(int idEquipo, Label lbl)
        {
            List<Set> setsEquipo = lgs.devolverSetsEquipoEncuentro(idEquipo, encuentro.idEncuentro);
            lbl.Text = "";
            foreach(Set set in setsEquipo)
            {
                lbl.Text += " " + set.puntuacionSet;
            }
        }

        private void btnAgregarPuntos1_Click(object sender, EventArgs e)
        {
            if (deporte.anotaciones)
            {
                agregarAnotacion(equipo1, lblPuntaje1);
            }
            else if (deporte.sets)
            {
                new SubFrmDatosSetEq(this, equipo1, lblPuntaje1).Visible = true;
                setSetsEquipo(equipo1.idEquipo, lblPuntaje1);
            }
        }

        private void btnAgregarPuntos2_Click(object sender, EventArgs e)
        {
            if (deporte.anotaciones)
            {
                agregarAnotacion(equipo2, lblPuntaje2);
            }
            else if (deporte.sets)
            {
                new SubFrmDatosSetEq(this, equipo2, lblPuntaje2).Visible = true;
                setSetsEquipo(equipo2.idEquipo, lblPuntaje2);
            }
        }

        public void agregarSet(Equipo equipo, int puntuacion)
        {
            int numSetActual = lgs.getMaxNumSet(encuentro.idEncuentro);
            lgs.agregarSet(numSetActual + 1, puntuacion);
            int idSet = lgs.devolverUltimaID();
            lgs.agregarSetEquipo(idSet, equipo.idEquipo, encuentro.idEncuentro);
        }

        public void agregarAnotacion(Equipo equipo, Label lbl)
        {
            int minuto = Int32.Parse(lblMinuto.Text);
            FrmSeleccionarJugadorAnotacion frmsja = new FrmSeleccionarJugadorAnotacion(this, equipo, lbl);
            frmsja.Visible = true;
            frmsja.listarJugadoresPorAlineacion(equipo.idEquipo, encuentro.idEncuentro);
        }

        private void FrmGestionarEncCol_Load(object sender, EventArgs e)
        {
            flpIncidencias.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
        }

        private void lblPuntaje2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ts = new TimeSpan(0, 0, encuentro.minActual, 0, (int)oSW.ElapsedMilliseconds);
            lge.actualizarMinActual(encuentro.idEncuentro, (int)ts.Minutes);
            lblMinuto.Text = ts.Minutes.ToString();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            lge.iniciarEncuentro(encuentro.idEncuentro);
            encuentro = lge.devolverEncuentroPorId(encuentro.idEncuentro);
            iniciarTimer();
            actualizarBotones();
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            lge.pausarEncuentro(encuentro.idEncuentro);
            encuentro = lge.devolverEncuentroPorId(encuentro.idEncuentro);
            detenerTimer();
            actualizarBotones();
        }

        private void btnReanudar_Click(object sender, EventArgs e)
        {
            lge.reanudarEncuentro(encuentro.idEncuentro);
            encuentro = lge.devolverEncuentroPorId(encuentro.idEncuentro);
            iniciarTimer();
            actualizarBotones();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            lge.finalizarEncuentro(encuentro.idEncuentro);
            encuentro = lge.devolverEncuentroPorId(encuentro.idEncuentro);
            detenerTimer();
            actualizarBotones();
        }
    }
}
