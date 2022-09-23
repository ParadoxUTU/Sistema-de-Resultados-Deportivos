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
using SistemaResultadosDeportivos.Modelos;

namespace SistemaResultadosDeportivos
{
    public partial class SubFrmModificarTorneo : Form
    {
        ABMTorneos torneos;
        
        public SubFrmModificarTorneo(ABMTorneos t)
        {
            InitializeComponent();
            torneos = t;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String pais = txtPais.Text;
            DateTime fechaInicio = dateFechaInicio.Value;
            String strFechaInicio = fechaInicio.Year.ToString() + "-" + fechaInicio.Month.ToString() + "-" + fechaInicio.Day.ToString();
            DateTime fechaFin = dateFechaFin.Value;
            String strFechaFin = fechaFin.Year.ToString() + "-" + fechaFin.Month.ToString() + "-" + fechaFin.Day.ToString();
            this.Dispose();
            if (!torneos.confirmarModificacion(strFechaInicio, strFechaFin, pais, nombre))
            {
                new SubFrmModificarTorneo(torneos).Visible = true;
            }
        }

        private void SubFrmModificarTorneo_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            Torneo torneo = torneos.obtenerTorneo();
            txtNombre.Text = torneo.nombreTorneo;
            txtPais.Text = torneo.nombrePais;
            DateTime fechaInicio = Convert.ToDateTime(torneo.fechaComienzo);
            dateFechaInicio.Value = fechaInicio;
            DateTime fechaFin = Convert.ToDateTime(torneo.fechaFin);
            dateFechaFin.Value = fechaFin;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Estás seguro?", "Confirmar baja de torneo", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == System.Windows.MessageBoxResult.Yes)
            {
                torneos.eliminarTorneo();
                this.Dispose();
            }
        }
    }
}
