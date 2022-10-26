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
    public partial class SubFrmModificarUsuario : Form
    {
        ABMUsuarios usuarios;

        public SubFrmModificarUsuario(ABMUsuarios u)
        {
            InitializeComponent();
            usuarios = u;
        }

        private void SubFrmModificarUsuario_Load_1(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            Image imagenPerfil = Properties.Resources.perfil;
            Bitmap bitmapPerfil = new Bitmap(imagenPerfil, pnlPerfil.Width, pnlPerfil.Height - 1);
            pnlPerfil.BackgroundImage = bitmapPerfil;
            txtUsername.Text = usuarios.obtenerUsuario();
            cbxRol.SelectedIndex = usuarios.obtenerRol();
            cbxTipoUsuario.Enabled = false;
            cbxRol.Enabled = false;
            if (usuarios.esMiembro())
                cbxTipoUsuario.SelectedIndex = 0;
            else
                cbxTipoUsuario.SelectedIndex = 1;
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Estás seguro?", "Confirmar baja de usuario", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == System.Windows.MessageBoxResult.Yes)
            {
                usuarios.eliminarUsuario();
                this.Dispose();
            }
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            //Recoge los datos de modificacion, y los envía al frame original para su confirmacion
            String nombre = txtUsername.Text;
            int rol;
            if (cbxRol.SelectedItem != null)
            {
                if (cbxRol.SelectedItem.ToString().Equals("User"))
                {
                    rol = 0;
                }
                else
                {
                    rol = 1;
                }
            }
            else
            {
                rol = -1;
            }

            if (!nombre.Equals("") && rol != -1)
            {
                this.Dispose();
                if (!usuarios.confirmarModificacion(nombre, rol))
                {
                    new SubFrmModificarUsuario(usuarios).Visible = true;
                }
                else
                {
                    if (cbxTipoUsuario.SelectedIndex == 0)
                    {
                        usuarios.agregarMiembro();
                    }
                    else
                    {
                        usuarios.eliminarMiembro();
                    }

                }
            }
            else
            {
                System.Windows.MessageBox.Show("Datos invalidos.");
            }
        }

        private void cbxRol_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbxRol.SelectedIndex == 0)
            {
                cbxTipoUsuario.Enabled = true;
            }
            else
            {
                cbxTipoUsuario.SelectedIndex = 1;
                cbxTipoUsuario.Text = "";
                cbxTipoUsuario.Enabled = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtUsername.Enabled = true;
            cbxRol.Enabled = true;
            if (cbxRol.SelectedIndex == 0)
                cbxTipoUsuario.Enabled = true;
            btnModificar.Enabled = false;
        }
    }
}
