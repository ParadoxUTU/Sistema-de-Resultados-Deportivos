using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaResultadosDeportivos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string contrasena = txtContrasena.Text;
            try
            {
                ADODB.Connection cn = new ADODB.Connection();
                cn.Open("miodbc", email, contrasena);
                MessageBox.Show("Logueado con exito");
                if (getRol(email, contrasena) == 1)
                {
                    cn.Close();
                    this.Hide();
                    Backoffice f = new Backoffice();
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    cn.Close();
                    this.Hide();
                    InicioApp f = new InicioApp();
                    f.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Credenciales incorrectas.");
                MessageBox.Show(ex.Message);
            }
        }

        private short getRol(string email, string contrasena)
        {
            ADODB.Connection cn = new ADODB.Connection();
            cn.Open("miodbc", email, contrasena);
            String sql = "SELECT * FROM USUARIOS WHERE dirCorreo = '" + email + "';";
            ADODB.Recordset rs = cn.Execute(sql, out object cantFilas, -1);
            return (short)rs.Fields[3].Value;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
