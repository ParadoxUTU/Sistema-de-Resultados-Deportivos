using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaResultadosDeportivos.Logica;

namespace SistemaResultadosDeportivos
{
    public partial class Login : Form
    {
        LogicaUsuarios lg;

        public Login()
        {
            InitializeComponent();
            lg = new LogicaUsuarios();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String correo = txtEmail.Text;
            String contrasena = txtContrasena.Text;
            RespuestaAutenticacion res = lg.autenticar(correo, contrasena);
            if (res.exito)
            {
                switch (res.rol)
                {
                    case 0:
                        new InicioApp().Visible = true;
                        break;
                    case 1:
                        new Backoffice().Visible = true;
                        break;
                }
                this.Hide();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
