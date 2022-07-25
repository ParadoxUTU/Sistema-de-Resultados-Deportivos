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
    public partial class SubFrmModificarUsuario : Form
    {
        ABMUsuarios usuarios;
        public String correo;

        public SubFrmModificarUsuario(ABMUsuarios u, String c)
        {
            InitializeComponent();
            usuarios = u;
            correo = c;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            String nombre = txtUsername.Text;
            int rol;
            bool exito = int.TryParse(txtRol.Text, out rol);
            if (!nombre.Equals("") && exito && (rol == 0 || rol == 1))
            {
                if (usuarios.sqlModificar(correo, nombre, rol))
                {
                        usuarios.listarUsuarios();
                        this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Datos invalidos.");
            }
        }
    }
}
