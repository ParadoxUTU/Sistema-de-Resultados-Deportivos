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

namespace SistemaResultadosDeportivos
{
    public partial class FrmVerEncuentroInd : Form
    {
        APIresultados resultados;
        public List<JugadorDeEncuentro> jugadores;
        Encuentro encuentro;
        Deporte deporte;
        LogicaNotificaciones lgn;
        LogicaUsuarios lgu;
        Usuario usuario;
        int var = 0;

        public FrmVerEncuentroInd(Encuentro e, Usuario usuario)
        {
            InitializeComponent();
            timer1.Enabled = true;
            jugadores = new List<JugadorDeEncuentro>();
            resultados = new APIresultados();
            lgn = new LogicaNotificaciones();
            lgu = new LogicaUsuarios();
            encuentro = e;
            timer2.Enabled = true;
            deporte = JsonConvert.DeserializeObject<Deporte>(resultados.getDeporte(encuentro.idDeporte));
            lblNombreEncuentro.Text = encuentro.nombreEncuentro;
            lblMinuto.Text = encuentro.minActual.ToString();
            listarJugadores();
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

        public void listarJugadores()
        {
            flpJugadores.Controls.Clear();
            int i = 0;
            int tamano = flpJugadores.Width - 5;
            List<String> jugadoresJSON = resultados.getJugadoresDeEncuentro(encuentro.idEncuentro);
            for(int g = 0; g < jugadoresJSON.Count; g++)
            {
                JugadorDeEncuentro jugador = JsonConvert.DeserializeObject<JugadorDeEncuentro>(jugadoresJSON[g]);
                jugadores.Add(jugador);
            }
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
            
        }

        private void lblNombreEncuentro_Click(object sender, EventArgs e)
        {

        }

        private void FrmVerEncuentroInd_Load(object sender, EventArgs e)
        {
            flpJugadores.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            encuentro = JsonConvert.DeserializeObject<Encuentro>(resultados.getEncuentro(encuentro.idEncuentro));
            listarJugadores();
        }

        private void timer2_Tick(object sender, EventArgs e)
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
