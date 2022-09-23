using SistemaResultadosDeportivos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace SistemaResultadosDeportivos
{
    public partial class SubFrmModificarDeporte : Form
    {
        ABMDeportes deportes;

        public SubFrmModificarDeporte(ABMDeportes d)
        {
            InitializeComponent();
            deportes = d;
            txtNombre.Enabled = false;
            cbxModalidad.Enabled = false;
            cbxPuntuacion.Enabled = false;
            numAlineacion.Enabled = false;
            numParticipantes.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String modalidad;
            bool porEquipos;
            string puntuacion;
            bool anotaciones;
            bool sets;
            int participantes = (int)numParticipantes.Value;
            int alineacion = (int)numAlineacion.Value;
            modalidad = cbxModalidad.SelectedItem.ToString();
            puntuacion = cbxPuntuacion.SelectedItem.ToString();
            porEquipos = (modalidad == "Por equipos");
            anotaciones = (puntuacion == "Anotaciones");
            sets = (puntuacion == "Sets");
            if (!nombre.Equals(""))
            {
                this.Dispose();
                if (!deportes.confirmarModificacion(porEquipos, anotaciones, sets, participantes, nombre, alineacion))
                {
                    new SubFrmModificarDeporte(deportes).Visible = true;
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No deje espacios vacíos");
            }
        }

        private void SubFrmModificarDeporte_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            Deporte deporte = deportes.obtenerDeporte();
            txtNombre.Text = deporte.nombreDeporte;
            if (deporte.porEquipos)
            {
                cbxModalidad.SelectedIndex = 1;
            }
            else
            {
                cbxModalidad.SelectedIndex = 0;
            }
            if (deporte.anotaciones)
            {
                cbxPuntuacion.SelectedIndex = 0;
            }
            else if (deporte.sets)
            {
                cbxPuntuacion.SelectedIndex = 1;
            }
            numAlineacion.Value = deporte.tamAlineacion;
            numParticipantes.Value = deporte.cantParticipantes;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            cbxModalidad.Enabled = true;
            cbxPuntuacion.Enabled = true;
            numAlineacion.Enabled = true;
            numParticipantes.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Estás seguro?", "Confirmar baja de deporte", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == System.Windows.MessageBoxResult.Yes)
            {
                deportes.eliminarDeporte();
                this.Dispose();
            }
        }
    }
}
