using SistemaResultadosDeportivos.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaResultadosDeportivos.Logica;
using System.Drawing;

namespace SistemaResultadosDeportivos
{
    public partial class FrmSeleccionarAlineacion : Form
    {
        LogicaDeportes lgd;
        LogicaJugadores lgj;
        Equipo equipo1;
        Equipo equipo2;
        Encuentro encuentro;
        int var = 0;
        int fase = 0;
        List<int> idJugadores = new List<int>();
        List<int> alineacion1 = new List<int>();
        List<int> alineacion2 = new List<int>();

        public FrmSeleccionarAlineacion(Equipo eq1, Equipo eq2, Encuentro en)
        {
            InitializeComponent();
            lgd = new LogicaDeportes();
            lgj = new LogicaJugadores();
            equipo1 = eq1;
            equipo2 = eq2;
            encuentro = en;
            listarJugadoresPorPlantel(equipo1.idEquipo);
        }

        public void listarJugadoresPorPlantel(int idEquipo)
        {
            idJugadores.Clear();
            flpJugadores.Controls.Clear();
            int i = 0;
            int tamano = flpJugadores.Width - 5;
            List<Jugador> lista = lgj.devolverJugadoresPorEquipo(idEquipo);
            foreach (Jugador j in lista)
            {
                String tamanoSt = "Nombre: " + j.nombreJugador;
                String tamanoSt2 = "Pais: " + j.edad;
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
                idJugadores.Add(j.idJugador);
                String textNombre = "Nombre: " + j.nombreJugador;
                String textPais = "Pais: " + j.pais;
                String textEdad = "Edad: " + j.edad;
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
            flpJugadores.Controls.Add(btnParticipante);
            btnParticipante.Click += new EventHandler(btnJugadores_Click);
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
            Jugador jugador = lgj.devolverJugadorPorID(idJugadores[var]);
            bool repetido = false;
            if (fase == 0)
            {
                foreach(int id in alineacion1)
                {
                    if(jugador.idJugador == id)
                    {
                        repetido = true;
                    }
                }
                if (repetido)
                {
                    btnJugador.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
                    alineacion1.Remove(jugador.idJugador);
                }
                else
                {
                    btnJugador.BackColor = System.Drawing.Color.FromArgb(90, 10, 0, 0);
                    alineacion1.Add(jugador.idJugador);
                }
            }
            else
            {
                foreach (int id in alineacion2)
                {
                    if (jugador.idJugador == id)
                    {
                        repetido = true;
                    }
                }
                if (repetido)
                {
                    btnJugador.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
                    alineacion2.Remove(jugador.idJugador);
                }
                else
                {
                    btnJugador.BackColor = System.Drawing.Color.FromArgb(90, 10, 0, 0);
                    alineacion2.Add(jugador.idJugador);
                }
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if(fase == 0)
            {
                fase++;
                lblEquipo.Text = equipo2.nombreEquipo;
                listarJugadoresPorPlantel(equipo2.idEquipo);
            }
            else
            {
                foreach(int id in alineacion1)
                {
                    if(!(lgj.agregarJugadorAAlineacion(id, equipo1.idEquipo, encuentro.idEncuentro, 0)))
                    {
                        MessageBox.Show("Ha ocurrido un error");
                    }
                }
                foreach (int id in alineacion2)
                {
                    if (!(lgj.agregarJugadorAAlineacion(id, equipo2.idEquipo, encuentro.idEncuentro, 0)))
                    {
                        MessageBox.Show("Ha ocurrido un error");
                    }
                }
                new FrmGestionarEncCol(encuentro, equipo1, equipo2, lgd.devolverDeportePorID(encuentro.idDeporte)).Visible = true;
            }
        }

        private void FrmSeleccionarAlineacion_Load(object sender, EventArgs e)
        {
            lblEquipo.Text = equipo1.nombreEquipo;
            flpJugadores.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
            pnlBuscar.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
            pnlLupa.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
        }
    }
}
