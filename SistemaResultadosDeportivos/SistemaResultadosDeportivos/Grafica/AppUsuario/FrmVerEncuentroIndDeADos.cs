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
    public partial class FrmVerEncuentroIndDeADos : Form
    {
        APIresultados resultados;
        Encuentro encuentro;
        Deporte deporte;
        Jugador jugador1;
        Jugador jugador2;
        LogicaNotificaciones lgn;
        Usuario usuario;
        LogicaUsuarios lgu;

        public FrmVerEncuentroIndDeADos(Encuentro e, Usuario usuario)
        {
            InitializeComponent();
            timer1.Enabled = true;
            resultados = new APIresultados();
            encuentro = e;
            lgn = new LogicaNotificaciones();
            lgu = new LogicaUsuarios();
            deporte = JsonConvert.DeserializeObject<Deporte>(resultados.getDeporte(encuentro.idDeporte));
            jugador1 = JsonConvert.DeserializeObject<Jugador>(resultados.getJugadoresPorEncuentro(encuentro.idEncuentro)[0]);
            jugador2 = JsonConvert.DeserializeObject<Jugador>(resultados.getJugadoresPorEncuentro(encuentro.idEncuentro)[1]);
            lblJugador1.Text = jugador1.nombreJugador;
            lblJugador2.Text = jugador2.nombreJugador;
            setSetsJugador(encuentro.idEncuentro, jugador1.idJugador, lblPuntaje1);
            setSetsJugador(encuentro.idEncuentro, jugador2.idJugador, lblPuntaje2);
            lblMinuto.Text = Convert.ToString(encuentro.minActual);
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
            this.usuario = usuario;
            actualizarSuscribirse();
        }

        public void setSetsJugador(int idEncuentro, int idJugador, Label lbl)
        {
            List<Set> sets = new List<Set>();
            List<String> setsJson = resultados.getSetsJugador(idJugador, idEncuentro);
            for (int i = 0; i < setsJson.Count; i++)
            {
                Set s = JsonConvert.DeserializeObject<Set>(setsJson[i]);
                sets.Add(s);
            }
            if (sets.Count > 0)
            {
                lbl.Text = "";
                foreach (Set set in sets)
                {
                    lbl.Text += " " + set.puntuacionSet;
                }
            }
        }

        private void flpIncidencias_Paint(object sender, PaintEventArgs e)
        {
            flpIncidencias.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
        }

        private void lblPuntaje2_Click(object sender, EventArgs e)
        {

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
            setSetsJugador(encuentro.idEncuentro, jugador1.idJugador, lblPuntaje1);
            setSetsJugador(encuentro.idEncuentro, jugador2.idJugador, lblPuntaje2);
        }

        private void FrmVerEncuentroIndDeADos_Load(object sender, EventArgs e)
        {

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
    }
}
