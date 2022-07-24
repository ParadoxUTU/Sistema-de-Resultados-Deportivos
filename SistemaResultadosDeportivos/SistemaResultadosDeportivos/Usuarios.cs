using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADODB;
using SistemaResultadosDeportivos.Logica;
using SistemaResultadosDeportivos.Modelos;

namespace SistemaResultadosDeportivos
{
    public partial class Usuarios : Form
    {
        private LogicaUsuarios lg;

        public Usuarios()
        {
            InitializeComponent();
            lg = new LogicaUsuarios();
            this.Dock = DockStyle.Fill;
            listarUsuarios();
            lviewUsuarios.FullRowSelect = true;
        }

        private void listarUsuarios()
        {
            lviewUsuarios.Items.Clear();
            List<Usuario> l = lg.devolverUsuarios();
            if (l != null)
            {
                foreach (Usuario us in l)
                {
                    ListViewItem item = new ListViewItem(us.correo);
                    item.SubItems.Add(us.nombre);
                    item.SubItems.Add(us.rol.ToString()); ;
                    lviewUsuarios.Items.Add(item);
                }
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            string correo = txtEmail.Text;
            string contrasena = txtContrasena.Text;
            int rol = 0;
            string username = txtUsername.Text;
            try
            {
                rol = short.Parse(txtRol.Text);
            }
            catch
            {
                MessageBox.Show("Tipo de dato no valido, reemplazado por 0.");
            }

            if (rol != 0 && rol != 1)
            {
                MessageBox.Show("Las opciones son: 0 para aficionado, 1 para administrador");
            }
            else if (lg.registrarUsuario(correo, username, contrasena, rol))
            {
                listarUsuarios();
                txtEmail.Text = null;
                txtContrasena.Text = null;
                txtRol.Text = null;
                txtUsername.Text = null;
            }
            else
            {
                MessageBox.Show("No se ha podido agregar el usuario");
            }
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
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (lviewUsuarios.SelectedItems != null)
                {
                    String username = Microsoft.VisualBasic.Interaction.InputBox("Nombre de usuario:", "Modificar Usuario");
                    short rol = 0;
                    try
                    {
                        rol = short.Parse(Microsoft.VisualBasic.Interaction.InputBox("Rol:", "Modificar Usuario"));
                    }
                    catch
                    {
                        MessageBox.Show("Tipo de dato no valido, reemplazado por 0.");
                    }
                    String email = lviewUsuarios.SelectedItems[0].Text;
                    if (rol != 0 && rol != 1)
                    {
                        MessageBox.Show("Las opciones son: 0 para aficionado, 1 para administrador");
                    }
                    else
                    {
                        ADODB.Connection cn = new ADODB.Connection();
                        cn.Open("miodbc", "root", "Veimach0");
                        String sql = "UPDATE Usuarios SET username = '" + username + "', rol = '" + rol + "' WHERE dirCorreo = '" + email + "';";
                        cn.Execute(sql, out object cantFilas, -1);
                        cn.Close();
                        listarUsuarios();
                    }
                }
                else
                {
                    MessageBox.Show("No hay usuario seleccionado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
