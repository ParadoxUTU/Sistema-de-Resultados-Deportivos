using SistemaResultadosDeportivos.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaResultadosDeportivos.Logica;
using System.Drawing;
using System.Windows;

namespace SistemaResultadosDeportivos
{
    public partial class SubFrmModificarEncuentro : Form
    {
        public FrmInicioEncuentros encuentros;
        public LogicaDeportes lgd;
        public LogicaTorneos lgt;
        public LogicaSets lgs;
        LogicaJugadores lgj;
        public LogicaEquipos lgeq;
        LogicaAnotaciones lga;
        public int var = 0;
        public List<int> idParticipantes = new List<int>();

        public SubFrmModificarEncuentro(FrmInicioEncuentros en)
        {
            InitializeComponent();
            encuentros = en;
            lgd = new LogicaDeportes();
            lgt = new LogicaTorneos();
            lgj = new LogicaJugadores();
            lgeq = new LogicaEquipos();
            lga = new LogicaAnotaciones();
            lgs = new LogicaSets();
            listarDeportes();
            Encuentro encuentro = encuentros.obtenerEncuentro();
            listarTorneos(encuentro.idDeporte);
            cbxDeportes.Enabled = false;
            cbxTorneos.Enabled = false;
            listarParticipantes(encuentro.idEncuentro);
            habilitarODeshabilitarGestionar();
        }

        private void habilitarODeshabilitarGestionar()
        {
            Encuentro encuentro = encuentros.obtenerEncuentro();
            Deporte deporte = lgd.devolverDeportePorID(encuentro.idDeporte);
            if (idParticipantes.Count < deporte.cantParticipantes)
            {
                btnGestionarEncuentro.Enabled = false;
            }
            else
            {
                btnGestionarEncuentro.Enabled = true;
            }
        }

        private void listarDeportes()
        {
            cbxDeportes.Items.Clear();
            List<Deporte> lista = lgd.devolverDeportes();
            if (lista.Count != 0)
            {
                foreach (Deporte d in lista)
                {
                    cbxDeportes.Items.Add(d.nombreDeporte);
                }
            }
        }

        private void listarTorneos(int idDeporte)
        {
            cbxTorneos.Items.Clear();
            List<Torneo> lista = lgt.devolverTorneosPorDeporte(idDeporte);
            if (lista.Count != 0)
            {
                foreach (Torneo t in lista)
                {
                    cbxTorneos.Items.Add(t.nombreTorneo);
                }
            }
        }

        private void listarParticipantes(int idEncuentro)
        {
            flpParticipantes.Controls.Clear();
            Encuentro encuentro = encuentros.obtenerEncuentro();
            Deporte deporte = lgd.devolverDeportePorID(encuentro.idDeporte);
            int i = 0;
            int tamano = flpParticipantes.Width - 5;
            if (deporte.porEquipos)
            {
                List<Equipo> lista = lgeq.devolverEquiposPorEncuentro(encuentro.idEncuentro);

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
            else
            {
                List<Jugador> lista = lgj.devolverJugadoresPorEncuentro(encuentro.idEncuentro);

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
                    String textEdad = "Fecha mi Nacimiento: " + j.fechaNac;
                    asignarComponentes(textNombre, textPais, textEdad, i, tamano);
                    i++;
                }
            }
            if (i < deporte.cantParticipantes)
            {
                for (int g = i; g < deporte.cantParticipantes; g++)
                {
                    asignarComponentes("Participante " + (g + 1) + " ", "X ", "X ", g, tamano);
                }
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

        public void propiedadesBoton(Button btn, int i, int t)
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

        public void propiedadesLabel(Label lbl, String s, Button btn, int l)
        {
            lbl.Text = s;
            lbl.BackColor = System.Drawing.Color.Transparent;
            lbl.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            lbl.ForeColor = System.Drawing.Color.White;
            lbl.Width = s.Length * 10;
            lbl.Location = new System.Drawing.Point(110, l);
        }

        public void propiedadesPanel(Panel pnl)
        {
            pnl.Width = 92;
            pnl.Height = 91;
            Image imagenPerfil = Properties.Resources.perfil;
            Bitmap bitmapPerfil = new Bitmap(imagenPerfil, pnl.Width, pnl.Height - 1);
            pnl.BackgroundImage = bitmapPerfil;
        }

        private void btnParticipante_Click(object sender, EventArgs e)
        {
            Button btnParticipante = sender as Button;
            int i = (Int32)btnParticipante.Tag;
            var = i;
            SubFrmSeleccionarParticipantes seleccionarP = new SubFrmSeleccionarParticipantes(this);
            seleccionarP.Visible = true;
            Encuentro en = encuentros.obtenerEncuentro();
            Deporte deporte = lgd.devolverDeportePorID(en.idDeporte);
            Torneo torneo = lgt.devolverTorneoPorEncuentro(en.idEncuentro);
            if (deporte.porEquipos && torneo == null)
            {
                seleccionarP.listarEquiposPorDeporte(deporte.idDeporte);
            }
            else if (!(deporte.porEquipos) && torneo == null)
            {
                seleccionarP.listarJugadoresPorDeporte(deporte.idDeporte);
            }
            else if (deporte.porEquipos && torneo != null)
            {
                seleccionarP.listarEquiposPorTorneo(torneo.idTorneo);
            }else if(!(deporte.porEquipos) && torneo != null)
            {
                seleccionarP.listarJugadoresPorTorneo(torneo.idTorneo);
            }
        }

        private void SubFrmModificarEncuentro_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            flpParticipantes.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
            Encuentro en = encuentros.obtenerEncuentro();
            txtNombre.Text = en.nombreEncuentro;
            DateTime fecha = Convert.ToDateTime(en.fecha);
            dateFecha.Value = fecha;
            DateTime hora = Convert.ToDateTime(en.hora);
            timeHora.Value = hora;
            if (en.comenzo)
            {
                cbxEstado.SelectedIndex = 0;
            }else if (en.pausado)
            {
                cbxEstado.SelectedIndex = 1;
            }else if (en.finalizo)
            {
                cbxEstado.SelectedIndex = 2;
            }
            numMinActual.Value = en.minActual;
            Deporte dep = lgd.devolverDeportePorID(en.idDeporte);
            cbxDeportes.Text = dep.nombreDeporte;
            if (dep.porEquipos)
            {
                label2.Visible = false;
                txtNombre.Visible = false;
            }
            Torneo tor = lgt.devolverTorneoPorEncuentro(en.idEncuentro);
            if (tor != null)
            {
                cbxTorneos.Text = tor.nombreTorneo;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Encuentro en = encuentros.obtenerEncuentro();
            Deporte deporte = lgd.devolverDeportePorID(en.idDeporte);
            if (!deporte.porEquipos)
            {
                encuentros.lge.eliminarEncuentroJugadorPorEncuentro(en.idEncuentro);
                foreach (int i in idParticipantes)
                {
                    encuentros.lge.agregarEncuentroJugador(encuentros.obtenerEncuentro().idEncuentro, i, 0, 0);
                }
            }
            else
            {
                encuentros.lge.eliminarEncuentroEquipoPorEncuentro(en.idEncuentro);
                foreach (int i in idParticipantes)
                {
                    encuentros.lge.agregarEncuentroEquipo(encuentros.obtenerEncuentro().idEncuentro, i, 0, 0);
                }
            }
            DateTime fechaEncuentro = dateFecha.Value;
            String strFecha = fechaEncuentro.Year.ToString() + "-" + fechaEncuentro.Month.ToString() + "-" + fechaEncuentro.Day.ToString();
            DateTime horaEncuentro = timeHora.Value;
            String strHora = horaEncuentro.Hour.ToString() + ":" + horaEncuentro.Minute.ToString();
            bool pausado = (cbxEstado.SelectedIndex == 1);
            int minActual = (int)numMinActual.Value;
            bool comenzo = (cbxEstado.SelectedIndex == 0);
            bool finalizo = (cbxEstado.SelectedIndex == 2);
            String nombreEncuentro = "";
            if (deporte.porEquipos)
            {
                List<Equipo> participantes = lgeq.devolverEquiposPorEncuentro(en.idEncuentro);
                if(participantes.Count == 2)
                {
                    nombreEncuentro = participantes[0].nombreEquipo + " vs " + participantes[1].nombreEquipo;
                }
            }
            else
            {
                nombreEncuentro = txtNombre.Text;
            }
            if(encuentros.lge.modificarEncuentro(en.idEncuentro, strFecha, strHora, pausado, minActual, comenzo, finalizo, nombreEncuentro, deporte.idDeporte))
            {
                encuentros.listarEncuentros();
                System.Windows.Forms.MessageBox.Show("Modificado con éxito");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Ha habido un error al modificar.");
            }
            this.Dispose();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Encuentro en = encuentros.obtenerEncuentro();
            Deporte deporte = lgd.devolverDeportePorID(en.idDeporte);
            Torneo torneo = lgt.devolverTorneoPorEncuentro(en.idEncuentro);
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Estás seguro?", "Confirmar baja de encuentro", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == System.Windows.MessageBoxResult.Yes)
            {
                lgs.eliminarSetsEncuentroEquipos(en.idEncuentro);
                lgs.eliminarSetsEncuentroIndividual(en.idEncuentro);
                lgs.eliminarSetPorEncuentro(en.idEncuentro);
                lga.eliminarAnotacionesDeEncuentro(en.idEncuentro);
                encuentros.lge.eliminarAlineacionesDeEncuentro(en.idEncuentro);
                encuentros.lge.eliminarEncuentroEquipoPorEncuentro(en.idEncuentro);
                encuentros.lge.eliminarEncCol(en.idEncuentro);
                encuentros.lge.eliminarEncuentroJugadorPorEncuentro(en.idEncuentro);
                encuentros.lge.eliminarEncInd(en.idEncuentro);
                encuentros.lge.eliminarEncuentroTorneo(en.idEncuentro);
                encuentros.lge.eliminarEncuentro(en.idEncuentro);
                encuentros.listarEncuentros();
                this.Dispose();
            }
        }

        private void btnGestionarEncuentro_Click(object sender, EventArgs e)
        {
            Encuentro en = encuentros.obtenerEncuentro();
            Deporte dep = lgd.devolverDeportePorID(en.idDeporte);
            if (dep.porEquipos)
            {
                Equipo equipo1 = lgeq.devolverEquipoPorID(idParticipantes[0]);
                Equipo equipo2 = lgeq.devolverEquipoPorID(idParticipantes[1]);
                //LUEGO EVALUAR TAMALINEACION
                if (encuentros.lge.devolverAlineacion(equipo1.idEquipo, en.idEncuentro).Count > 0 && encuentros.lge.devolverAlineacion(equipo2.idEquipo, en.idEncuentro).Count > 0)
                {
                    new FrmGestionarEncCol(en, equipo1, equipo2, dep).Visible = true;
                }
                else
                {
                    new FrmSeleccionarAlineacion(equipo1, equipo2, en).Visible = true;
                }
            }
            else
            {
                if(dep.cantParticipantes == 2)
                {
                    Jugador jugador1 = lgj.devolverJugadorPorID(idParticipantes[0]);
                    Jugador jugador2 = lgj.devolverJugadorPorID(idParticipantes[1]);
                    new FrmGestionarEncIndDeADos(en, jugador1, jugador2, dep).Visible = true;
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbxDeportes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
