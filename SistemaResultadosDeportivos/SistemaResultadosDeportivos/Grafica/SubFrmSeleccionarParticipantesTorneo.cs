using SistemaResultadosDeportivos.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaResultadosDeportivos.Logica;
using System.Drawing;

namespace SistemaResultadosDeportivos
{
    public partial class SubFrmSeleccionarParticipantesTorneo : Form
    {
        int var = 0;
        SubFrmVerParticipantes participantes;
        LogicaEquipos lgeq;
        LogicaJugadores lgj;
        List<int> idParticipantes = new List<int>();

        public SubFrmSeleccionarParticipantesTorneo(SubFrmVerParticipantes p)
        {
            InitializeComponent();
            participantes = p;
            lgeq = new LogicaEquipos();
            lgj = new LogicaJugadores();
            if (participantes.deporte.porEquipos)
            {
                listarEquiposPorDeporte(participantes.deporte.idDeporte);
            }
            else
            {
                listarJugadoresPorDeporte(participantes.deporte.idDeporte);
            }
        }

        public void listarEquiposPorDeporte(int idDeporte)
        {
            flpParticipantes.Controls.Clear();
            int i = 0;
            int tamano = flpParticipantes.Width - 5;
            List<Equipo> lista = lgeq.devolverEquiposPorDeporte(participantes.deporte.idDeporte);

            foreach (Equipo e in lista)
            {
                String tamanoSt = "Nombre: " + e.nombreEquipo;
                String tamanoSt2 = "Pais: " + e.nombreEquipo;
                if (tamanoSt.Length > tamano)
                {
                    tamano = tamanoSt.Length;
                }
                else if (tamanoSt2.Length > tamano)
                {
                    tamano = tamanoSt2.Length;
                }
            }

            foreach (Equipo e in lista)
            {
                idParticipantes.Add(e.idEquipo);
                String textNombre = "Nombre: " + e.nombreEquipo;
                String textPais = "Pais: " + e.nombrePais;
                asignarComponentes(textNombre, textPais, "", i, tamano);
                i++;
            }
        }

        public void listarJugadoresPorDeporte(int idDeporte)
        {
            flpParticipantes.Controls.Clear();
            int i = 0;
            int tamano = flpParticipantes.Width - 5;
            List<Jugador> lista = lgj.devolverJugadoresPorDeporte(participantes.deporte.idDeporte);
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
            btnParticipante.Click += new EventHandler(btnParticipante_Click);
        }

        private void btnParticipante_Click(object sender, EventArgs e)
        {
            Button btnParticipante = sender as Button;
            int i = (Int32)btnParticipante.Tag;
            var = i;
            if (participantes.deporte.porEquipos)
            {
                if (lgeq.agregarEquipoATorneo(idParticipantes[var], participantes.torneo.idTorneo))
                {
                    participantes.listarEquiposPorTorneo(participantes.torneo.idTorneo);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Ese participante ya está en el torneo.");
                }
            }
            else
            {
                if (lgj.agregarJugadorATorneo(idParticipantes[var], participantes.torneo.idTorneo))
                {
                    participantes.listarJugadoresPorTorneo(participantes.torneo.idTorneo);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Ese participante ya está en el torneo.");
                }
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

        private void SubFrmSeleccionarParticipantesTorneo_Load(object sender, EventArgs e)
        {
            flpParticipantes.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
        }
    }
}
