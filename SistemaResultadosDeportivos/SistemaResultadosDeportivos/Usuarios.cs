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

namespace SistemaResultadosDeportivos
{
    public partial class Usuarios : Form
    {
        public ListViewItem lista;

        public Usuarios()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            listarUsuarios();
            lviewUsuarios.FullRowSelect = true;
        }

        private void listarUsuarios()
        {
            try
            {
                lviewUsuarios.Items.Clear();
                ADODB.Connection cn = new ADODB.Connection();
                cn.Open("miodbc", "root", "Veimach0"); //"contraseña" se puede cambiar por la contraseña del portador de la base de datos
                String sql = "SELECT * FROM USUARIOS;";
                ADODB.Recordset rs = cn.Execute(sql, out object cantFilas, -1);
                for (int i = 0; i < (int)cantFilas; i++)
                {
                    lista = new ListViewItem(Convert.ToString(rs.Fields[0].Value));
                    lista.SubItems.Add(Convert.ToString(rs.Fields[1].Value));
                    lviewUsuarios.Items.Add(lista);
                    rs.MoveNext();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string contrasena = txtContrasena.Text;
            short rol = 0;
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
            else
            {
                try
                {
                    ADODB.Connection cn = new ADODB.Connection();
                    cn.Open("miodbc", "root", "Veimach0");
                    String sql = "CREATE USER '" + email + "'@'localhost' IDENTIFIED BY '" + contrasena + "';";
                    String sql2 = "";
                    String sql3 = "INSERT INTO Usuarios VALUES('" + email + "', '" + username + "', '" + contrasena + "', '" + rol + "');";
                    cn.Execute(sql, out object cantFilas, -1);
                    sql2 = "GRANT ALL ON Usuarios TO '" + email + "'@'localhost';";
                    cn.Execute(sql2, out object cantFilas2, -1);
                    cn.Execute(sql3, out object cantFilas3, -1);
                    cn.Close();
                    listarUsuarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            txtEmail.Text = null;
            txtContrasena.Text = null;
            txtRol.Text = null;
            txtUsername.Text = null;
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            string email = lviewUsuarios.SelectedItems[0].Text;
            try
            {
                ADODB.Connection cn = new ADODB.Connection();
                cn.Open("miodbc", "root", "Veimach0");
                String sql = "DELETE FROM Usuarios WHERE dirCorreo = '" + email + "';";
                String sql2 = "DROP USER '" + email + "'@'localhost';";
                cn.Execute(sql, out object cantFilas, -1);
                cn.Execute(sql2, out object cantFilas2, -1);
                cn.Close();
                listarUsuarios();
                txtEmail.Text = null;
                txtContrasena.Text = null;
                txtRol.Text = null;
                txtUsername.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
