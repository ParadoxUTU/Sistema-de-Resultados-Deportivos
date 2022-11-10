using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaResultadosDeportivos.APIs;
using SistemaResultadosDeportivos.Modelos;
using SistemaResultadosDeportivos.Logica;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.IO;

namespace SistemaResultadosDeportivos
{
    public partial class FrmVerEncuentroEquipo : Form
    {
        APIresultados resultados;
        LogicaNotificaciones lgn;
        LogicaUsuarios lgu;
        LogicaIncidencias lga;
        LogicaCambios lgc;
        LogicaJugadores lgj;
        Encuentro encuentro;
        Deporte deporte;
        Equipo equipo1;
        Equipo equipo2;
        Usuario usuario;
        public List<Incidencia> incidencias;

        public FrmVerEncuentroEquipo(Encuentro e, Usuario usuario)
        {
            InitializeComponent();
            timer1.Enabled = true;
            resultados = new APIresultados();
            lgn = new LogicaNotificaciones();
            lgu = new LogicaUsuarios();
            lga = new LogicaIncidencias();
            lgc = new LogicaCambios();
            lgj = new LogicaJugadores();
            this.usuario = usuario;
            incidencias = new List<Incidencia>();
            timer2.Enabled = true;
            encuentro = e;
            deporte = JsonConvert.DeserializeObject<Deporte>(resultados.getDeporte(encuentro.idDeporte));
            equipo1 = JsonConvert.DeserializeObject<Equipo>(resultados.getEquiposPorEncuentro(encuentro.idEncuentro)[0]);
            equipo2 = JsonConvert.DeserializeObject<Equipo>(resultados.getEquiposPorEncuentro(encuentro.idEncuentro)[1]);
            lblEquipo1.Text = equipo1.nombreEquipo;
            lblEquipo2.Text = equipo2.nombreEquipo;
            if (deporte.anotaciones)
            {
                setAnotacionesEquipo(encuentro.idEncuentro, equipo1.idEquipo, lblPuntaje1);
                setAnotacionesEquipo(encuentro.idEncuentro, equipo2.idEquipo, lblPuntaje2);
            }
            else
            {
                setSetsEquipo(encuentro.idEncuentro, equipo1.idEquipo, lblPuntaje1);
                setSetsEquipo(encuentro.idEncuentro, equipo2.idEquipo, lblPuntaje2);
            }
            lblMinuto.Text = Convert.ToString(encuentro.minActual);
            actualizarSuscribirse();
            if (encuentro.minActual < 10)
            {
                lblMinuto.Text = "0" + encuentro.minActual.ToString();
            }
            else
            {
                lblMinuto.Text = encuentro.minActual.ToString();
            }
            if (encuentro.segActual < 10)
            {
                lblMinuto.Text += ":0" + encuentro.segActual.ToString();
            }
            else
            {
                lblMinuto.Text += ":" + encuentro.segActual.ToString();
            }
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
                String textMinuto = "";
                if (incidencia.minuto < 10)
                {
                    textMinuto += "0" + incidencia.minuto.ToString();
                }
                else
                {
                    textMinuto = incidencia.minuto.ToString();
                }
                if (incidencia.segundo < 10)
                {
                    textMinuto += ":0" + incidencia.segundo.ToString();
                }
                else
                {
                    textMinuto += ":" + incidencia.segundo.ToString();
                }
                asignarComponentes(textNombre, textJugador, textMinuto, i, tamano);
                i++;
            }
        }

        public void asignarComponentes(String n, String p, String e, int i, int tamano)
        {
            Label lblBoton = new Label();
            Label lblBoton2 = new Label();
            Label lblBoton3 = new Label();
            Button btnParticipante = new Button();
            String textNombre = n;
            String textPais = p;
            String textEdad = e;
            propiedadesBoton(btnParticipante, i, tamano);
            propiedadesLabel(lblBoton, textNombre, btnParticipante, 8);
            propiedadesLabel(lblBoton2, textPais, btnParticipante, 39);
            propiedadesLabel(lblBoton3, textEdad, btnParticipante, 70);
            btnParticipante.Controls.Add(lblBoton);
            btnParticipante.Controls.Add(lblBoton2);
            btnParticipante.Controls.Add(lblBoton3);
            flpIncidencias.Controls.Add(btnParticipante);
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

        public void setSetsEquipo(int idEncuentro, int idEquipo, Label lbl)
        {
            List<Set> sets = new List<Set>();
            List<String> setsJson = resultados.getSetsEquipo(idEquipo, idEncuentro);
            for (int i = 0; i < setsJson.Count; i++)
            {
                Set s = JsonConvert.DeserializeObject<Set>(setsJson[i]);
                sets.Add(s);
            }
            if(sets.Count > 0)
            {
                lbl.Text = "";
                foreach (Set set in sets)
                {
                    lbl.Text += " " + set.puntuacionSet;
                }
            }
        }

        public void setAnotacionesEquipo(int idEncuentro, int idEquipo, Label lbl)
        {
            RespuestaAnotaciones puntaje1 = JsonConvert.DeserializeObject<RespuestaAnotaciones>(resultados.getAnotacionesEquipo(idEncuentro, idEquipo));
            lbl.Text = puntaje1.puntaje.ToString();
        }

        private void FrmVerEncuentroApp_Load(object sender, EventArgs e)
        {
            flpIncidencias.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            encuentro = JsonConvert.DeserializeObject<Encuentro>(resultados.getEncuentro(encuentro.idEncuentro));
            if (encuentro.minActual < 10)
            {
                lblMinuto.Text = "0" + encuentro.minActual.ToString();
            }
            else
            {
                lblMinuto.Text = encuentro.minActual.ToString();
            }
            if (encuentro.segActual < 10)
            {
                lblMinuto.Text += ":0" + encuentro.segActual.ToString();
            }
            else
            {
                lblMinuto.Text += ":" + encuentro.segActual.ToString();
            }
            setAnotacionesEquipo(encuentro.idEncuentro, equipo1.idEquipo, lblPuntaje1);
            setAnotacionesEquipo(encuentro.idEncuentro, equipo2.idEquipo, lblPuntaje2);
        }

        private void btnSuscribirse_Click(object sender, EventArgs e)
        {
            if (lgu.esMiembro(usuario.correo))
            {
                List<String> correos = lgn.devolverMiembrosPorSuscripcionEncuentro(encuentro.idEncuentro);
                if (correos.Contains(usuario.correo))
                {
                    lgn.eliminarSuscripcionAEncuentro(usuario.correo, encuentro.idEncuentro);
                }
                else
                {
                    lgn.agregarSuscripcionAEncuentro(usuario.correo, encuentro.idEncuentro);
                }
                actualizarSuscribirse();
            }
            else
            {
                MessageBox.Show("Para acceder a esta función debe de obtener la membresía.");
            }
        }

        private void actualizarSuscribirse()
        {
            List<String> correos = lgn.devolverMiembrosPorSuscripcionEncuentro(encuentro.idEncuentro);
            if (correos.Contains(usuario.correo))
            {
                btnSuscribirse.BackColor = Color.Gray;
                btnSuscribirse.Text = "Suscrito";
            }
            else
            {
                btnSuscribirse.BackColor = Color.MediumTurquoise;
                btnSuscribirse.Text = "Suscribirse";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            setIncidencias();
            listarIncidencias();
        }
    }
}