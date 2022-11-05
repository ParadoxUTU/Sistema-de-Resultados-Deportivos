using SistemaResultadosDeportivos.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaResultadosDeportivos.Logica;
using System.Drawing;
using System.Windows;

namespace SistemaResultadosDeportivos
{
    public partial class FrmSeleccionarJugadorAnotacion : Form
    {
        FrmGestionarEncCol gestionar;
        LogicaJugadores lgj;
        Equipo equipoActual;
        int var = 0;
        Label lbl;
        Button botonAnterior = null;

        public FrmSeleccionarJugadorAnotacion(FrmGestionarEncCol g, Equipo eq, Label l)
        {
            InitializeComponent();
            gestionar = g;
            lgj = new LogicaJugadores();
            equipoActual = eq;
            lbl = l;
        }

        public void listarJugadoresPorAlineacion(int idEquipo, int idEncuentro)
        {
            flpJugadores.Controls.Clear();
            int i = 0;
            int tamano = flpJugadores.Width - 5;
            List<Alineacion> lista = gestionar.lge.devolverAlineacion(idEquipo, idEncuentro);
            foreach (Alineacion a in lista)
            {
                Jugador j = lgj.devolverJugadorPorID(a.idJugador);
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

            foreach (Alineacion a in lista)
            {
                Jugador j = lgj.devolverJugadorPorID(a.idJugador);
                String textNombre = "Nombre: " + j.nombreJugador;
                String textPais = "Pais: " + j.pais;
                String textFecha = "Fecha de Nacimiento: " + j.fechaNac;
                asignarComponentes(textNombre, textPais, textFecha, i, tamano);
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
            if (botonAnterior != null)
                botonAnterior.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
            Button btnJugador = sender as Button;
            int i = (Int32)btnJugador.Tag;
            btnJugador.BackColor = System.Drawing.Color.FromArgb(90, 40, 0, 0);
            var = i;
            botonAnterior = btnJugador;
        }

        private void SeleccionarJugadorAlineacion_Load(object sender, EventArgs e)
        {
            flpJugadores.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            List<Alineacion> alineacion = gestionar.lge.devolverAlineacion(equipoActual.idEquipo, gestionar.encuentro.idEncuentro);
            Jugador jugador = lgj.devolverJugadorPorID(alineacion[var].idJugador);
            int minuto = gestionar.ts.Minutes;
            int puntuacion = (int)numPuntuacion.Value;
            gestionar.lga.agregarAnotacion(jugador.idJugador, minuto, equipoActual.idEquipo, gestionar.encuentro.idEncuentro, puntuacion);
            gestionar.setAnotacionesEquipo(gestionar.encuentro.idEncuentro, equipoActual.idEquipo, lbl);
            this.Dispose();
        }
    }
}
