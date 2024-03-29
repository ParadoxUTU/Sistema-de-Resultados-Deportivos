﻿using System;
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
using System.Diagnostics;

namespace SistemaResultadosDeportivos
{
    public partial class FrmGestionarEncIndDeADos : Form
    {
        public Stopwatch oSW = new Stopwatch();
        public TimeSpan ts;
        public LogicaIncidencias lga;
        public LogicaEncuentros lge;
        public LogicaSets lgs;
        public Encuentro encuentro;
        public Jugador jugador1;
        public Jugador jugador2;
        public Deporte deporte;
        public LogicaAmonestaciones lgam;

        public FrmGestionarEncIndDeADos(Encuentro en, Jugador jug1, Jugador jug2, Deporte dep)
        {
            InitializeComponent();
            lga = new LogicaIncidencias();
            lge = new LogicaEncuentros();
            lgs = new LogicaSets();
            lgam = new LogicaAmonestaciones();
            encuentro = en;
            jugador1 = jug1;
            jugador2 = jug2;
            deporte = dep;
            lblJugador1.Text = jugador1.nombreJugador;
            lblJugador2.Text = jugador2.nombreJugador;
            setSetsJugador(jugador1.idJugador, lblPuntaje1);
            setSetsJugador(jugador2.idJugador, lblPuntaje2);
            if (encuentro.comenzo && !encuentro.pausado && !encuentro.finalizo)
            {
                iniciarTimer();
            }
            else
            {
                ts = new TimeSpan(0, 0, encuentro.minActual, encuentro.segActual, (int)oSW.ElapsedMilliseconds);
            }
            if (ts.Minutes < 10)
            {
                lblMinuto.Text = "0" + ts.Minutes.ToString();
            }
            else
            {
                lblMinuto.Text = ts.Minutes.ToString();
            }
            if (ts.Seconds < 10)
            {
                lblMinuto.Text += ":0" + ts.Seconds.ToString();
            }
            else
            {
                lblMinuto.Text += ":" + ts.Seconds.ToString();
            }
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
            else if (!encuentro.finalizo && encuentro.pausado)
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
            ts = new TimeSpan(0, 0, encuentro.minActual, 0, 0);
            oSW.Start();
            timer1.Enabled = true;
        }

        public void detenerTimer()
        {
            oSW.Reset();
            timer1.Enabled = false;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            ts = new TimeSpan(0, 0, encuentro.minActual, encuentro.segActual, (int)oSW.ElapsedMilliseconds);
            lge.actualizarMinActual(encuentro.idEncuentro, (int)ts.Minutes, (int)ts.Seconds);
            if (ts.Minutes < 10)
            {
                lblMinuto.Text = "0" + ts.Minutes.ToString();
            }
            else
            {
                lblMinuto.Text = ts.Minutes.ToString();
            }
            if (ts.Seconds < 10)
            {
                lblMinuto.Text += ":0" + ts.Seconds.ToString();
            }
            else
            {
                lblMinuto.Text += ":" + ts.Seconds.ToString();
            }
        }
    }
}
