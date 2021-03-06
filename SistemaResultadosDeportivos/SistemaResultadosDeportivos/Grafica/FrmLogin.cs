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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SistemaResultadosDeportivos
{
    public partial class FrmLogin : Form
    {
        APIautenticacion autenticacion;

        public FrmLogin()
        {
            InitializeComponent();
            autenticacion = new APIautenticacion();
        }

        private bool getExitoFromJson(string jsonInput)
        {
            var autenticacionJSON = JsonConvert.DeserializeObject<APIautenticacion>(jsonInput);
            return autenticacionJSON.exito;
        }

        private int getRolFromJson(string jsonInput)
        {
            var autenticacionJSON = JsonConvert.DeserializeObject<APIautenticacion>(jsonInput);
            return autenticacionJSON.rol;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String correo = txtEmail.Text;
            String contrasena = txtContrasena.Text;
            bool exito = getExitoFromJson(autenticacion.loginToJSON(correo, contrasena));
            int rol = getRolFromJson(autenticacion.loginToJSON(correo, contrasena));
            if (exito)
            {
                switch (rol)
                {
                    case 0:
                        new FrmInicioApp().Visible = true;
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
    }
}
