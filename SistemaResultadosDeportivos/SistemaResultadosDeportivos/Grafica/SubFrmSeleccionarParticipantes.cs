using SistemaResultadosDeportivos.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaResultadosDeportivos.Logica;
using System.Drawing;

namespace SistemaResultadosDeportivos
{
    public partial class SubFrmSeleccionarParticipantes : Form
    {
        SubFrmModificarEncuentro frmencuentro;
        LogicaJugadores lgj;
        int var = 0;
        List<int> idParticipantes = new List<int>();

        public SubFrmSeleccionarParticipantes(SubFrmModificarEncuentro en)
        {
            InitializeComponent();
            lgj = new LogicaJugadores();
            frmencuentro = en;
        }

        public void listarEquiposPorDeporte(int idDeporte)
        {
            flpParticipantes.Controls.Clear();
            Encuentro encuentro = frmencuentro.encuentros.obtenerEncuentro();
            Deporte deporte = frmencuentro.lgd.devolverDeportePorID(encuentro.idDeporte);
            int i = 0;
            int tamano = flpParticipantes.Width - 5;
            List<Equipo> lista = frmencuentro.lgeq.devolverEquiposPorDeporte(deporte.idDeporte);

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
            Encuentro encuentro = frmencuentro.encuentros.obtenerEncuentro();
            Deporte deporte = frmencuentro.lgd.devolverDeportePorID(encuentro.idDeporte);
            int i = 0;
            int tamano = flpParticipantes.Width - 5;
            List<Jugador> lista = lgj.devolverJugadoresPorDeporte(deporte.idDeporte);
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

        public void listarEquiposPorTorneo(int idTorneo)
        {
            flpParticipantes.Controls.Clear();
            Encuentro encuentro = frmencuentro.encuentros.obtenerEncuentro();
            Torneo torneo = frmencuentro.lgt.devolverTorneoPorID(idTorneo);
            int i = 0;
            int tamano = flpParticipantes.Width - 5;
            List<Equipo> lista = frmencuentro.lgeq.devolverEquiposPorTorneo(idTorneo);

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

        public void listarJugadoresPorTorneo(int idTorneo)
        {
            flpParticipantes.Controls.Clear();
            Encuentro encuentro = frmencuentro.encuentros.obtenerEncuentro();
            Torneo torneo = frmencuentro.lgt.devolverTorneoPorID(idTorneo);
            int i = 0;
            int tamano = flpParticipantes.Width - 5;
            List<Jugador> lista = lgj.devolverJugadoresPorTorneo(idTorneo);
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

        private bool setIdParticipante(int id, String nombre)
        {
            bool exito = true;
            if(nombre.StartsWith("Participante"))
            {
                foreach(int i in frmencuentro.idParticipantes)
                {
                    if(id == i)
                    {
                        exito = false;
                    }
                }
                if (exito)
                {
                    frmencuentro.idParticipantes.Add(id);
                }
            }
            else
            {
                foreach (int i in frmencuentro.idParticipantes)
                {
                    if (id == i)
                    {
                        exito = false;
                    }
                }
                if (exito)
                {
                    frmencuentro.idParticipantes[frmencuentro.var] = id;
                }
            }
            return exito;
        }

        private void btnParticipante_Click(object sender, EventArgs e)
        {
            Button btnParticipante = sender as Button;
            int i = (Int32)btnParticipante.Tag;
            var = i;
            if(setIdParticipante(idParticipantes[var], frmencuentro.flpParticipantes.Controls[frmencuentro.var].Controls[1].Text))
            {
                Label lbl1 = (Label)frmencuentro.flpParticipantes.Controls[frmencuentro.var].Controls[1];
                Label lbl2 = (Label)frmencuentro.flpParticipantes.Controls[frmencuentro.var].Controls[2];
                Label lbl3 = (Label)frmencuentro.flpParticipantes.Controls[frmencuentro.var].Controls[3];
                String textNombre = flpParticipantes.Controls[var].Controls[1].Text;
                String textPais = flpParticipantes.Controls[var].Controls[2].Text;
                String textEdad = flpParticipantes.Controls[var].Controls[3].Text;
                frmencuentro.propiedadesLabel((Label)frmencuentro.flpParticipantes.Controls[frmencuentro.var].Controls[1], textNombre, btnParticipante, 8);
                frmencuentro.propiedadesLabel((Label)frmencuentro.flpParticipantes.Controls[frmencuentro.var].Controls[2], textPais, btnParticipante, 39);
                frmencuentro.propiedadesLabel((Label)frmencuentro.flpParticipantes.Controls[frmencuentro.var].Controls[3], textEdad, btnParticipante, 70);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Ese participante ya está incluido");
            }
        }

        private void SubFrmSeleccionarParticipantes_Load(object sender, EventArgs e)
        {
            flpParticipantes.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
            pnlBuscar.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
            pnlLupa.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
        }
    }
}
