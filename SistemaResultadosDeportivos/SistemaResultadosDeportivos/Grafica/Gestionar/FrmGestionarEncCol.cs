using SistemaResultadosDeportivos.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaResultadosDeportivos.Logica;
using System.Drawing;
using System.Windows;
using System.Diagnostics;
using System.Linq;

namespace SistemaResultadosDeportivos
{
    public partial class FrmGestionarEncCol : Form
    {
        public Stopwatch oSW = new Stopwatch();
        public TimeSpan ts;
        public LogicaIncidencias lga;
        public LogicaEncuentros lge;
        public LogicaSets lgs;
        public LogicaCambios lgc;
        public LogicaJugadores lgj;
        public LogicaNotificaciones lgn;
        public LogicaTorneos lgt;
        public Encuentro encuentro;
        public Equipo equipo1;
        public Equipo equipo2;
        public Deporte deporte;
        public List<Incidencia> incidencias;
        int var = 0;

        public FrmGestionarEncCol(Encuentro en, Equipo eq1, Equipo eq2, Deporte dep)
        {
            InitializeComponent();
            lga = new LogicaIncidencias();
            lge = new LogicaEncuentros();
            lgs = new LogicaSets();
            lgc = new LogicaCambios();
            lgj = new LogicaJugadores();
            lgn = new LogicaNotificaciones();
            lgt = new LogicaTorneos();
            incidencias = new List<Incidencia>();
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
            if(encuentro.comenzo && !encuentro.pausado && !encuentro.finalizo)
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
            setIncidencias();
            listarIncidencias();
        }

        public void listarIncidencias()
        {
            flpIncidencias.Controls.Clear();
            int i = 0;
            int tamano = flpIncidencias.Width - 5;
            foreach (Incidencia incidencia in incidencias)
            {
                String tamanoSt = incidencia.tipoIncidencia;
                Jugador jugador1 = lgj.devolverJugadorPorID(incidencia.idJugador1);
                String tamanoSt2 = jugador1.nombreJugador.ToString();
                if (incidencia.tipoIncidencia == "Cambio")
                {
                    Jugador jugador2 = lgj.devolverJugadorPorID(incidencia.idJugador2);
                    tamanoSt2 += " => " + jugador2.nombreJugador;
                }
                if (tamanoSt.Length > tamano)
                {
                    tamano = tamanoSt.Length;
                }
                else if (tamanoSt2.Length > tamano)
                {
                    tamano = tamanoSt2.Length;
                }
            }

            foreach (Incidencia incidencia in incidencias)
            {
                String textNombre = incidencia.tipoIncidencia;
                Jugador jugador1 = lgj.devolverJugadorPorID(incidencia.idJugador1);
                String textJugador = jugador1.nombreJugador.ToString();
                if (incidencia.tipoIncidencia == "Cambio")
                {
                    Jugador jugador2 = lgj.devolverJugadorPorID(incidencia.idJugador2);
                    textJugador += " => " + jugador2.nombreJugador;
                }
                String textMinuto = incidencia.minuto.ToString() + ":" + incidencia.segundo.ToString();
                asignarComponentes(textNombre, textJugador, textMinuto, i, tamano);
                i++;
            }
        }

        public void asignarComponentes(String n, String p, String e, int i, int tamano)
        {
            Label lblBoton = new Label();
            Label lblBoton2 = new Label();
            Label lblBoton3 = new Label();
            Panel pnlPerfil = new Panel();
            Button btnParticipante = new Button();
            String textNombre = n;
            String textPais = p;
            String textEdad = e;
            propiedadesBoton(btnParticipante, i, tamano);
            propiedadesLabel(lblBoton, textNombre, btnParticipante, 8);
            propiedadesLabel(lblBoton2, textPais, btnParticipante, 39);
            propiedadesLabel(lblBoton3, textEdad, btnParticipante, 70);
            propiedadesPanel(pnlPerfil);
            btnParticipante.Controls.Add(pnlPerfil);
            btnParticipante.Controls.Add(lblBoton);
            btnParticipante.Controls.Add(lblBoton2);
            btnParticipante.Controls.Add(lblBoton3);
            flpIncidencias.Controls.Add(btnParticipante);
            btnParticipante.Click += new EventHandler(btnJugadores_Click);
        }

        private void propiedadesBoton(Button btn, int i, int t)
        {
            btn.Height = 92;
            btn.Tag = i;
            btn.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
            btn.FlatStyle = FlatStyle.Flat;
            if (t == (flpIncidencias.Width - 5))
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
            Button btnJugador = sender as Button;
            int i = (Int32)btnJugador.Tag;
            btnJugador.BackColor = System.Drawing.Color.FromArgb(90, 40, 0, 0);
            var = i;
        }

        public void setIncidencias()
        {
            incidencias.Clear();
            List<Anotacion> anotaciones = lga.devolverAnotacionesPorEncuentro(encuentro.idEncuentro);
            foreach (Anotacion a in anotaciones)
            {
                Incidencia incidencia = new Incidencia(a.idAnotacion, "Anotación", a.minuto, a.segundo, 0, a.idJugador, -1);
                incidencias.Add(incidencia);
            }
            List<AmonestacionAlineacion> amonestaciones = lga.devolverAmonestacionesPorEncuentro(encuentro.idEncuentro);
            foreach (AmonestacionAlineacion a in amonestaciones)
            {
                Incidencia incidencia = new Incidencia(0, a.nombreAmonestacion, a.minuto, a.segundo, a.idEquipo, a.idJugador, -1);
                incidencias.Add(incidencia);
            }
            List<Cambio> cambios = lgc.devolverCambiosPorEncuentro(encuentro.idEncuentro);
            foreach (Cambio c in cambios)
            {
                Incidencia incidencia = new Incidencia(c.idCambio, "Cambio", c.minuto, c.segundo, c.idEquipo, c.jugadorSaliente, c.jugadorEntrante);
                incidencias.Add(incidencia);
            }
            incidencias.Sort((a, b) => (a.minuto * 60 + a.segundo).CompareTo(b.minuto * 60 + b.segundo));
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
                btnAmonestacion1.Enabled = false;
                btnAmonestacion2.Enabled = false;
                btnCambio1.Enabled = false;
                btnCambio2.Enabled = false;
            }
            else if (encuentro.comenzo && !encuentro.pausado && !encuentro.finalizo)
            {
                btnIniciar.Enabled = false;
                btnPausar.Enabled = true;
                btnFinalizar.Enabled = true;
                btnReanudar.Enabled = false;
                btnAgregarPuntos1.Enabled = true;
                btnAgregarPuntos2.Enabled = true;
                btnAmonestacion1.Enabled = true;
                btnAmonestacion2.Enabled = true;
                btnCambio1.Enabled = true;
                btnCambio2.Enabled = true;
            }
            else if(!encuentro.finalizo && encuentro.pausado)
            {
                btnIniciar.Enabled = false;
                btnPausar.Enabled = false;
                btnFinalizar.Enabled = true;
                btnReanudar.Enabled = true;
                btnAgregarPuntos1.Enabled = false;
                btnAgregarPuntos2.Enabled = false;
                btnAmonestacion1.Enabled = false;
                btnAmonestacion2.Enabled = false;
                btnCambio1.Enabled = false;
                btnCambio2.Enabled = false;
            }
            else if (encuentro.finalizo)
            {
                btnIniciar.Enabled = false;
                btnPausar.Enabled = false;
                btnFinalizar.Enabled = false;
                btnReanudar.Enabled = false;
                btnAgregarPuntos1.Enabled = false;
                btnAgregarPuntos2.Enabled = false;
                btnAmonestacion1.Enabled = false;
                btnAmonestacion2.Enabled = false;
                btnCambio1.Enabled = false;
                btnCambio2.Enabled = false;
            }
        }

        public void iniciarTimer()
        {
            ts = new TimeSpan(0, 0, encuentro.minActual, encuentro.segActual, 0);
            oSW.Start();
            timer1.Enabled = true;
        }

        public void detenerTimer()
        {
            oSW.Reset();
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
            int minuto = ts.Minutes;
            FrmSeleccionarJugadorAnotacion frmsja = new FrmSeleccionarJugadorAnotacion(this, equipo, lbl);
            frmsja.Visible = true;
            frmsja.listarJugadoresPorAlineacion(equipo.idEquipo, encuentro.idEncuentro);
        }

        public void agregarAmonestacion(Equipo equipo)
        {
            int minuto = ts.Minutes;
            SubFrmDatosAmonestacion frmda = new SubFrmDatosAmonestacion(this, equipo);
            frmda.Visible = true;
            frmda.listarJugadoresPorAlineacion(equipo.idEquipo, encuentro.idEncuentro);
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
            ts = new TimeSpan(0, 0, encuentro.minActual, encuentro.segActual, (int)oSW.ElapsedMilliseconds);
            lge.actualizarMinActual(encuentro.idEncuentro, (int)ts.Minutes, (int)ts.Seconds);
            if(ts.Minutes < 10)
            {
                lblMinuto.Text = "0" + ts.Minutes.ToString();
            }
            else
            {
                lblMinuto.Text = ts.Minutes.ToString();
            }
            if(ts.Seconds < 10)
            {
                lblMinuto.Text += ":0" + ts.Seconds.ToString();
            }
            else
            {
                lblMinuto.Text += ":" + ts.Seconds.ToString();
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            lge.iniciarEncuentro(encuentro.idEncuentro);
            encuentro = lge.devolverEncuentroPorId(encuentro.idEncuentro);
            iniciarTimer();
            actualizarBotones();
            List<String> correosEncuentro = lgn.devolverMiembrosPorSuscripcionEncuentro(encuentro.idEncuentro);
            List<String> correosEquipo1 = lgn.devolverMiembrosPorSuscripcionEquipo(equipo1.idEquipo);
            List<String> correosEquipo2 = lgn.devolverMiembrosPorSuscripcionEquipo(equipo2.idEquipo);
            List<String> correosTorneo = null;
            if(lgt.devolverTorneoPorEncuentro(encuentro.idEncuentro) != null)
            {
                Torneo torneo = lgt.devolverTorneoPorEncuentro(encuentro.idEncuentro);
                correosTorneo = lgn.devolverMiembrosPorSuscripcionTorneo(torneo.idTorneo);
                foreach (String correo in correosTorneo)
                {
                    lgn.agregarNotificacion(correo, "Ha empezado el encuentro de " + equipo1.nombreEquipo + " VS " + equipo2.nombreEquipo + " del torneo " + torneo.nombreTorneo);
                }
            }
            foreach (String correo in correosEncuentro)
            {
                lgn.agregarNotificacion(correo, "Ha empezado el encuentro de " + equipo1.nombreEquipo + " VS " + equipo2.nombreEquipo);
            }
            foreach (String correo in correosEquipo1)
            {
                lgn.agregarNotificacion(correo, "Ha empezado el encuentro de " + equipo1.nombreEquipo + " VS " + equipo2.nombreEquipo);
            }
            foreach (String correo in correosEquipo2)
            {
                lgn.agregarNotificacion(correo, "Ha empezado el encuentro de " + equipo1.nombreEquipo + " VS " + equipo2.nombreEquipo);
            }
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

        private void flpIncidencias_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAmonestacion1_Click(object sender, EventArgs e)
        {
            agregarAmonestacion(equipo1);
        }

        private void btnAmonestacion2_Click(object sender, EventArgs e)
        {
            agregarAmonestacion(equipo2);
        }

        private void lblEquipo1_Click(object sender, EventArgs e)
        {

        }

        private void btnCambio1_Click(object sender, EventArgs e)
        {
            new SubFrmDatosCambio(this, equipo1).Visible = true;
        }

        private void btnCambio2_Click(object sender, EventArgs e)
        {
            new SubFrmDatosCambio(this, equipo2).Visible = true;
        }
    }
}
