using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaResultadosDeportivos.Modelos;
using SistemaResultadosDeportivos.Logica;

namespace SistemaResultadosDeportivos
{
    public partial class SubFrmModificarEquipo : Form
    {
        FrmInicioEquipos equipos;
        Equipo equipo;
        LogicaDeportes lgd;

        public SubFrmModificarEquipo(FrmInicioEquipos e)
        {
            InitializeComponent();
            equipos = e;
            equipo = equipos.obtenerEquipo();
            lgd = new LogicaDeportes();
            listarDeportes();
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

        private void SubFrmModificarEquipo_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            txtNombre.Text = equipo.nombreEquipo;
            txtPais.Text = equipo.nombrePais;
            Deporte dep = lgd.devolverDeportePorID(equipo.idDeporte);
            cbxDeportes.Text = dep.nombreDeporte;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            String pais = txtPais.Text;
            if (!nombre.Equals("") && !pais.Equals(""))
            {
                this.Dispose();
                if (!equipos.confirmarModificacion(nombre, pais))
                {
                    new SubFrmModificarEquipo(equipos).Visible = true;
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No deje espacios vacíos");
            }
        }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new FrmSeleccionarPlantel(equipos).Visible = true;
        }
    }
}
