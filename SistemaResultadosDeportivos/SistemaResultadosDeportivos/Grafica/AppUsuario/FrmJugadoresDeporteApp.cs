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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.IO;

namespace SistemaResultadosDeportivos
{
    public partial class FrmJugadoresDeporteApp : Form
    {
        APIresultados resultados;
        Deporte deporte;
        List<Jugador> jugadores;
        int var = 0;

        public FrmJugadoresDeporteApp(Deporte deporte)
        {
            InitializeComponent();
            jugadores = new List<Jugador>();
            resultados = new APIresultados();
            this.deporte = deporte;
            setJugadores();
            listarJugadores();
        }

        private void setJugadores()
        {
            List<String> jugadoresJson = resultados.getJugadoresByDeporte(deporte.idDeporte);
            for (int i = 0; i < jugadoresJson.Count; i++)
            {
                Jugador j = JsonConvert.DeserializeObject<Jugador>(jugadoresJson[i]);
                jugadores.Add(j);
            }
        }

        public void listarJugadores()
        {
            flpJugadores.Controls.Clear();
            int i = 0;
            int tamano = flpJugadores.Width - 5;
            foreach (Jugador j in jugadores)
            {
                String tamanoSt = "Nombre: " + j.nombreJugador;
                String tamanoSt2 = "Pais: " + j.pais;
                if (tamanoSt.Length > tamano)
                {
                    tamano = tamanoSt.Length;
                }
                else if (tamanoSt2.Length > tamano)
                {
                    tamano = tamanoSt2.Length;
                }
            }

            foreach (Jugador j in jugadores)
            {
                String textNombre = "Nombre: " + j.nombreJugador;
                String textPais = "Pais: " + j.pais;
                String textEdad = "Fecha de Nacimiento: " + j.fechaNac;
                asignarComponentes(textNombre, textPais, textEdad, i, tamano);
                i++;
            }
        }

        public void asignarComponentes(String n, String p, String e, int i, int tamano)
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
            Button btnJugador = sender as Button;
            int i = (Int32)btnJugador.Tag;
            var = i;
        }

        private void FrmJugadoresDeporteApp_Load(object sender, EventArgs e)
        {
            flpJugadores.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
        }
    }
}
