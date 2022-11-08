using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaResultadosDeportivos.APIs;
using SistemaResultadosDeportivos.Modelos;
using SistemaResultadosDeportivos.Logica;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SistemaResultadosDeportivos
{
    public partial class FrmLogin : Form
    {
        APIautenticacion autenticacion;
        LogicaUsuarios lgu;

        public FrmLogin()
        {
            InitializeComponent();
            autenticacion = new APIautenticacion();
            lgu = new LogicaUsuarios();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Realiza la autenticacion y según el rol, envía el usuario a la app de usuario o al backoffice
            String correo = txtCorreo.Text;
            String contrasena = txtContrasena.Text;
            
            RespuestaAutenticacion res = JsonConvert.DeserializeObject<RespuestaAutenticacion>(autenticacion.loginToJSON(correo, contrasena));
            bool exito = res.exito;
            int rol = res.rol;
            if (exito)
            {
                switch (rol)
                {
                    case 0:
                        new FrmInicioAppLogin(lgu.devolverUsuarioPorId(correo)).Visible = true;
                        break;
                    case 1:
                        new FrmBackoffice().Visible = true;
                        break;
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales inválidas.");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100,0,0,0);
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            new FrmRegistro().Visible = true;
        }

        private void btnInvitado_Click(object sender, EventArgs e)
        {
            RespuestaAutenticacion res = JsonConvert.DeserializeObject<RespuestaAutenticacion>(autenticacion.loginToJSON("guest", "1"));
            bool exito = res.exito;
            if (exito)
            {
                new FrmInicioAppInvitado().Visible = true;
            }
        }
    }
}
