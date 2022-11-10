using SistemaResultadosDeportivos.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaResultadosDeportivos.Logica;
using System.Drawing;


namespace SistemaResultadosDeportivos
{
    public partial class SubFrmPlantelApp : Form
    {
        public Equipo equipo;
        LogicaEquipos lgeq;
        LogicaJugadores lgj;
        Button botonAnterior = null;
        int var = 0;
        List<int> idParticipantes = new List<int>();

        public SubFrmPlantelApp(Equipo equipo)
        {
            InitializeComponent();
            lgeq = new LogicaEquipos();
            lgj = new LogicaJugadores();
            this.equipo = equipo;
            listarJugadoresPorPlantel(equipo.idEquipo);
        }

        public void listarJugadoresPorPlantel(int idEquipo)
        {
            idParticipantes.Clear();
            flpParticipantes.Controls.Clear();
            int i = 0;
            int tamano = flpParticipantes.Width - 5;
            List<Jugador> lista = lgj.devolverJugadoresPorPlantel(idEquipo);
            foreach (Jugador j in lista)
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

            foreach (Jugador j in lista)
            {
                idParticipantes.Add(j.idJugador);
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
            flpParticipantes.Controls.Add(btnParticipante);
        }

        private void propiedadesBoton(Button btn, int i, int t)
        {
            btn.Height = 92;
            btn.Tag = i;
            btn.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
            btn.FlatStyle = FlatStyle.Flat;
            if (t == (flpParticipantes.Width - 5))
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

        private void SubFrmPlantelApp_Load(object sender, EventArgs e)
        {
            flpParticipantes.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
        }
    }
}
