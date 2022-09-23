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
    public partial class SubFrmModificarJugador : Form
    {
        ABMJugadores jugadores;

        public SubFrmModificarJugador(ABMJugadores j)
        {
            InitializeComponent();
            jugadores = j;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Estás seguro?", "Confirmar baja de jugador", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == System.Windows.MessageBoxResult.Yes)
            {
                jugadores.eliminarJugador();
                this.Dispose();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtPais.Enabled = true;
            numEdad.Enabled = true;
            numEstatura.Enabled = true;
            numPeso.Enabled = true;
            btnModificar.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String pais = txtPais.Text;
            int edad = (int)numEdad.Value;
            int estatura = (int)numEstatura.Value;
            int peso = (int)numPeso.Value;
            if(!nombre.Equals("") && !pais.Equals(""))
            {
                this.Dispose();
                if (!jugadores.confirmarModificacion(nombre, pais, edad, estatura, peso))
                {
                    new SubFrmModificarJugador(jugadores).Visible = true;
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No deje espacios vacíos");
            }
        }

        private void SubFrmModificarJugador_Load(object sender, EventArgs e)
        {
            Jugador jugador = jugadores.obtenerJugador();
            txtNombre.Text = jugador.nombreJugador;
            txtPais.Text = jugador.pais;
            numEdad.Value = jugador.edad;
            numEstatura.Value = jugador.estatura;
            numPeso.Value = jugador.peso;
            panel1.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
        }
    }
}
