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
    public partial class FrmGestionarEncInd : Form
    {
        public Stopwatch oSW = new Stopwatch();
        public TimeSpan ts;
        public LogicaAnotaciones lga;
        public LogicaEncuentros lge;
        public LogicaSets lgs;
        public LogicaJugadores lgj;
        public Encuentro encuentro;
        public List<JugadorDeEncuentro> jugadores;
        public Deporte deporte;
        int var = 0;
        Button botonAnterior = null;

        public FrmGestionarEncInd(Encuentro en, Deporte dep)
        {
            InitializeComponent();
            lga = new LogicaAnotaciones();
            lge = new LogicaEncuentros();
            lgs = new LogicaSets();
            lgj = new LogicaJugadores();
            encuentro = en;
            deporte = dep;
            botonAnterior = null;
            lblNombreEncuentro.Text = encuentro.nombreEncuentro;
            jugadores = lgj.devolverJugadoresDeEncuentro(encuentro.idEncuentro);
            listarJugadores();
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
                btnAgregarPuntos.Enabled = false;
                btnQuitarPuntos.Enabled = false;
            }
            else if (encuentro.comenzo && !encuentro.pausado && !encuentro.finalizo)
            {
                btnIniciar.Enabled = false;
                btnPausar.Enabled = true;
                btnFinalizar.Enabled = true;
                btnReanudar.Enabled = false;
                btnAgregarPuntos.Enabled = true;
                btnQuitarPuntos.Enabled = true;
            }
            else if (!encuentro.finalizo && encuentro.pausado)
            {
                btnIniciar.Enabled = false;
                btnPausar.Enabled = false;
                btnFinalizar.Enabled = true;
                btnReanudar.Enabled = true;
                btnAgregarPuntos.Enabled = false;
                btnQuitarPuntos.Enabled = false;
            }
            else if (encuentro.finalizo)
            {
                btnIniciar.Enabled = false;
                btnPausar.Enabled = false;
                btnFinalizar.Enabled = false;
                btnReanudar.Enabled = false;
                btnAgregarPuntos.Enabled = false;
                btnQuitarPuntos.Enabled = false;
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

        public void listarJugadores()
        {
            flpJugadores.Controls.Clear();
            int i = 0;
            int tamano = flpJugadores.Width - 5;
            //List<JugadorDeEncuentro> lista = lgj.devolverJugadoresDeEncuentro(encuentro.idEncuentro);
            jugadores = lgj.devolverJugadoresDeEncuentro(encuentro.idEncuentro);
            foreach (JugadorDeEncuentro j in jugadores)
            {
                String tamanoSt = "Nombre: " + j.nombreJugador;
                String tamanoSt2 = "Puntuación: " + j.puntuacion;
                if (tamanoSt.Length > tamano)
                {
                    tamano = tamanoSt.Length;
                }
                else if (tamanoSt2.Length > tamano)
                {
                    tamano = tamanoSt2.Length;
                }
            }

            foreach (JugadorDeEncuentro j in jugadores)
            {
                String textNombre = "Nombre: " + j.nombreJugador;
                String textPuntuacion = "Puntuacion: " + j.puntuacion;
                asignarComponentes(textNombre, textPuntuacion, i, tamano);
                i++;
            }
        }

        public void asignarComponentes(String n, String p, int i, int tamano)
        {
            Label lblBoton = new Label();
            Label lblBoton2 = new Label();
            Label lblBoton3 = new Label();
            Panel pnlPerfil = new Panel();
            Button btnJugador = new Button();
            String textNombre = n;
            String textPais = p;
            propiedadesBoton(btnJugador, i, tamano);
            propiedadesLabel(lblBoton, textNombre, btnJugador, 8);
            propiedadesLabel(lblBoton2, textPais, btnJugador, 39);
            propiedadesPanel(pnlPerfil);
            btnJugador.Controls.Add(pnlPerfil);
            btnJugador.Controls.Add(lblBoton);
            btnJugador.Controls.Add(lblBoton2);
            btnJugador.Controls.Add(lblBoton3);
            flpJugadores.Controls.Add(btnJugador);
            btnJugador.Click += new EventHandler(btnJugadores_Click);
        }

        private void propiedadesBoton(Button btn, int i, int t)
        {
            btn.Height = 92;
            btn.Tag = i;
            btn.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
            btn.FlatStyle = FlatStyle.Flat;
            if (t == (flpJugadores.Width - 5))
            {
                btn.Width = t;
            }
            else
            {
                btn.Width = t * 10;
            }
        }

        private void propiedadesLabel(Label lbl, String s, Button btn, int l)
        {
            lbl.Text = s;
            lbl.BackColor = System.Drawing.Color.Transparent;
            lbl.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            lbl.ForeColor = System.Drawing.Color.White;
            lbl.Width = s.Length * 10;
            lbl.Location = new System.Drawing.Point(110, l);
        }

        private void propiedadesPanel(Panel pnl)
        {
            pnl.Width = 92;
            pnl.Height = 91;
            Image imagenPerfil = Properties.Resources.perfil;
            Bitmap bitmapPerfil = new Bitmap(imagenPerfil, pnl.Width, pnl.Height - 1);
            pnl.BackgroundImage = bitmapPerfil;
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            if(botonAnterior != null)
                botonAnterior.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
            Button btnJugador = sender as Button;
            int i = (Int32)btnJugador.Tag;
            btnJugador.BackColor = System.Drawing.Color.FromArgb(90, 40, 0, 0);
            var = i;
            botonAnterior = btnJugador;
        }

        private void FrmGestionarEncInd_Load(object sender, EventArgs e)
        {
            flpJugadores.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
        }

        private void btnAgregarPuntos_Click(object sender, EventArgs e)
        {
            int puntuacion = (int)numPuntuacion.Value;
            int idJugador = jugadores[var].idJugador;
            lgj.agregarOQuitarPuntos(idJugador, encuentro.idEncuentro, puntuacion);
            listarJugadores();
        }

        private void btnQuitarPuntos_Click(object sender, EventArgs e)
        {
            int puntuacion = -(int)numPuntuacion.Value;
            int idJugador = jugadores[var].idJugador;
            System.Windows.MessageBox.Show(puntuacion.ToString());
            lgj.agregarOQuitarPuntos(idJugador, encuentro.idEncuentro, puntuacion);
            listarJugadores();
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            lge.pausarEncuentro(encuentro.idEncuentro);
            encuentro = lge.devolverEncuentroPorId(encuentro.idEncuentro);
            detenerTimer();
            actualizarBotones();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            lge.iniciarEncuentro(encuentro.idEncuentro);
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

        private void btnReanudar_Click(object sender, EventArgs e)
        {
            lge.reanudarEncuentro(encuentro.idEncuentro);
            encuentro = lge.devolverEncuentroPorId(encuentro.idEncuentro);
            iniciarTimer();
            actualizarBotones();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ts = new TimeSpan(0, 0, encuentro.minActual, 0, (int)oSW.ElapsedMilliseconds);
            lge.actualizarMinActual(encuentro.idEncuentro, (int)ts.Minutes);
            lblMinuto.Text = ts.Minutes.ToString();
        }
    }
}
