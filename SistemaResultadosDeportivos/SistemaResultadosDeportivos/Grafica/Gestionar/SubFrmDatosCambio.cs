using SistemaResultadosDeportivos.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaResultadosDeportivos.Logica;
using System.Drawing;
using System.Windows;

namespace SistemaResultadosDeportivos
{
    public partial class SubFrmDatosCambio : Form
    {
        FrmGestionarEncCol gestionar;
        LogicaJugadores lgj;
        LogicaEquipos lgeq;
        LogicaEncuentros lge;
        LogicaCambios lgc;
        Equipo equipoActual;
        int var1 = 0;
        int var2 = 0;
        Button botonAlineacionAnterior = null;
        Button botonPlantelAnterior = null;
        List<int> idJugadoresAlineacion;
        List<int> idJugadoresPlantel;

        public SubFrmDatosCambio(FrmGestionarEncCol g, Equipo eq)
        {
            InitializeComponent();
            gestionar = g;
            lgj = new LogicaJugadores();
            lgeq = new LogicaEquipos();
            lgc = new LogicaCambios();
            lge = new LogicaEncuentros();
            idJugadoresAlineacion = new List<int>();
            idJugadoresPlantel = new List<int>();
            equipoActual = eq;
            listarJugadoresPorJugando(equipoActual.idEquipo, gestionar.encuentro.idEncuentro);
            listarJugadoresPorBanco(equipoActual.idEquipo);
        }

        public void listarJugadoresPorBanco(int idEquipo)
        {
            int i = 0;
            int tamano = flpPlantel.Width - 5;
            List<Alineacion> lista = lge.devolverBanca(idEquipo, gestionar.encuentro.idEncuentro);
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
                idJugadoresPlantel.Add(j.idJugador);
                String textNombre = "Nombre: " + j.nombreJugador;
                String textPais = "Pais: " + j.pais;
                String textEdad = "Fecha de Nacimiento: " + j.fechaNac;
                asignarComponentes2(textNombre, textPais, textEdad, i, tamano);
                i++;
            }
        }

        public void asignarComponentes2(String n, String p, String e, int i, int tamano)
        {
            Label lblBoton = new Label();
            Label lblBoton2 = new Label();
            Label lblBoton3 = new Label();
            Panel pnlPerfil = new Panel();
            Button btnParticipante = new Button();
            String textNombre = n;
            String textPais = p;
            String textEdad = e;
            propiedadesBoton2(btnParticipante, i, tamano);
            propiedadesLabel2(lblBoton, textNombre, btnParticipante, 8);
            propiedadesLabel2(lblBoton2, textPais, btnParticipante, 39);
            propiedadesLabel2(lblBoton3, textEdad, btnParticipante, 70);
            propiedadesPanel2(pnlPerfil);
            btnParticipante.Controls.Add(pnlPerfil);
            btnParticipante.Controls.Add(lblBoton);
            btnParticipante.Controls.Add(lblBoton2);
            btnParticipante.Controls.Add(lblBoton3);
            flpPlantel.Controls.Add(btnParticipante);
            btnParticipante.Click += new EventHandler(btnJugadoresPlantel_Click);
        }

        private void propiedadesBoton2(Button btn, int i, int t)
        {
            btn.Height = 92;
            btn.Tag = i;
            btn.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
            btn.FlatStyle = FlatStyle.Flat;
            if (t == (flpPlantel.Width - 5))
            {
                btn.Width = t;
            }
            else
            {
                btn.Width = t * 10;
            }
        }

        private void propiedadesLabel2(Label lbl, String s, Button btn, int l)
        {
            lbl.Text = s;
            lbl.BackColor = System.Drawing.Color.Transparent;
            lbl.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            lbl.ForeColor = System.Drawing.Color.White;
            lbl.Width = s.Length * 10;
            lbl.Location = new System.Drawing.Point(110, l);
        }

        private void propiedadesPanel2(Panel pnl)
        {
            pnl.Width = 92;
            pnl.Height = 91;
            Image imagenPerfil = Properties.Resources.perfil;
            Bitmap bitmapPerfil = new Bitmap(imagenPerfil, pnl.Width, pnl.Height - 1);
            pnl.BackgroundImage = bitmapPerfil;
        }

        private void btnJugadoresPlantel_Click(object sender, EventArgs e)
        {
            if (botonPlantelAnterior != null)
                botonPlantelAnterior.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
            Button btnJugador = sender as Button;
            int i = (Int32)btnJugador.Tag;
            btnJugador.BackColor = System.Drawing.Color.FromArgb(90, 40, 0, 0);
            var1 = i;
            botonPlantelAnterior = btnJugador;
        }

        public void listarJugadoresPorJugando(int idEquipo, int idEncuentro)
        {
            flpAlineacion.Controls.Clear();
            int i = 0;
            int tamano = flpAlineacion.Width - 5;
            List<Alineacion> lista = gestionar.lge.devolverJugando(idEquipo, idEncuentro);
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
                idJugadoresAlineacion.Add(a.idJugador);
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
            flpAlineacion.Controls.Add(btnParticipante);
            btnParticipante.Click += new EventHandler(btnJugadorAlineacion_Click);
        }

        private void propiedadesBoton(Button btn, int i, int t)
        {
            btn.Height = 92;
            btn.Tag = i;
            btn.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
            btn.FlatStyle = FlatStyle.Flat;
            if (t == (flpAlineacion.Width - 5))
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

        private void btnJugadorAlineacion_Click(object sender, EventArgs e)
        {
            if (botonAlineacionAnterior != null)
                botonAlineacionAnterior.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
            Button btnJugador = sender as Button;
            int i = (Int32)btnJugador.Tag;
            btnJugador.BackColor = System.Drawing.Color.FromArgb(90, 40, 0, 0);
            var2 = i;
            botonAlineacionAnterior = btnJugador;
        }

        private void SubFrmDatosCambio_Load(object sender, EventArgs e)
        {
            flpAlineacion.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
            flpPlantel.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Jugador jugadorSaliente = lgj.devolverJugadorPorID(idJugadoresAlineacion[var2]);
            Jugador jugadorEntrante = lgj.devolverJugadorPorID(idJugadoresPlantel[var1]);
            lgc.agregarCambio(gestionar.ts.Minutes, gestionar.encuentro.idEncuentro, equipoActual.idEquipo, jugadorEntrante.idJugador, jugadorSaliente.idJugador, gestionar.ts.Seconds);
            lgj.agregarJugadorAAlineacion(jugadorEntrante.idJugador, equipoActual.idEquipo, gestionar.encuentro.idEncuentro, 0);
            gestionar.setIncidencias();
            gestionar.listarIncidencias();
        }
    }
}
