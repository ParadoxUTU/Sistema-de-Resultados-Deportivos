using SistemaResultadosDeportivos.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaResultadosDeportivos.Logica;

namespace SistemaResultadosDeportivos
{
    public partial class ABMUsuarios : Form
    {
        private LogicaUsuarios lg;

        public ABMUsuarios()
        {
            InitializeComponent();
            lg = new LogicaUsuarios();
            this.Dock = DockStyle.Fill;
            listarUsuarios();
            lviewUsuarios.FullRowSelect = true;
        }

        public void listarUsuarios()
        {
            lviewUsuarios.Items.Clear();
            List<Usuario> l = lg.devolverUsuarios();
            if (l.Count > 0)
            {
                foreach (Usuario us in l)
                {
                    ListViewItem item = new ListViewItem(us.correo);
                    item.SubItems.Add(us.nombre);
                    item.SubItems.Add(us.rol.ToString());
                    lviewUsuarios.Items.Add(item);
                }
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            string correo = txtEmail.Text;
            string contrasena = txtContrasena.Text;
            int rol;
            string username = txtUsername.Text;
            try
            {
                rol = short.Parse(txtRol.Text);
                if (!correo.Equals("") && !contrasena.Equals("") && !username.Equals(""))
                {
                    if (rol != 0 && rol != 1)
                    {
                        MessageBox.Show("Las opciones son: 0 para aficionado, 1 para administrador");
                    }
                    else if (lg.registrarUsuario(correo, username, contrasena, rol))
                    {
                        listarUsuarios();
                        limpiarTextos();
                    }
                }
                else
                {
                    MessageBox.Show("No se ha podido agregar el usuario");
                }
            }
            catch
            {
                MessageBox.Show("No se ha podido agregar el usuario");
            }
            limpiarTextos();
        }

        private void limpiarTextos()
        {
            txtEmail.Text = null;
            txtContrasena.Text = null;
            txtRol.Text = null;
            txtUsername.Text = null;
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (lviewUsuarios.SelectedItems.Count > 0)
            {
                string correo = lviewUsuarios.SelectedItems[0].Text;
                if (lg.bajaUsuario(correo))
                {
                    listarUsuarios();
                }
                else
                {
                    MessageBox.Show("No se ha podido eliminar el usuario");
                }
            }
            else
            {
                MessageBox.Show("No hay usuario seleccionado.");
            }
        }

/******************************************************************************************************************************************/
        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (lviewUsuarios.SelectedItems.Count == 1)
                {
                    String correo = lviewUsuarios.SelectedItems[0].Text;
                    SubFrmModificarUsuario modificar = new SubFrmModificarUsuario(this, correo);
                    modificar.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No hay usuario seleccionado.");
                }
            }
            catch { }
        }

        public bool sqlModificar(String correo, String nombre, int rol)
        {
            bool exito;
            if (lg.modificarUsuario(correo, nombre, rol))
            {
                exito = true;
            }
            else
            {
                exito = false;
            }
            return exito;
        }
/******************************************************************************************************************************************/

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
