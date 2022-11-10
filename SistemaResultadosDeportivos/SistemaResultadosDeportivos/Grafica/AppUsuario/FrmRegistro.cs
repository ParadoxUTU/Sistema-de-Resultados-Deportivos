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
    public partial class FrmRegistro : Form
    {
        APIautenticacion autenticacion;

        public FrmRegistro()
        {
            InitializeComponent();
            autenticacion = new APIautenticacion();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if(txtContrasena.Text != "")
            {
                String correo = txtCorreo.Text;
                String username = txtUsername.Text;
                String contrasena = txtContrasena.Text;
                RespuestaRegistro res = JsonConvert.DeserializeObject<RespuestaRegistro>(autenticacion.registroToJSON(correo, username, contrasena, 0));
                bool exito = res.exito;
                if (exito)
                {
                    MessageBox.Show("Registrado con éxito.");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos.");
                }
            }
            else
            {
                MessageBox.Show("Datos incorrectos.");
            }
        }
    }
}
