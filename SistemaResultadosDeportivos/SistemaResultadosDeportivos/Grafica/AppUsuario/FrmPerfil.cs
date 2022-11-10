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
using SistemaResultadosDeportivos.Modelos;

namespace SistemaResultadosDeportivos
{
    public partial class FrmPerfil : Form
    {
        Usuario usuario;
        LogicaUsuarios lgu;
        Correos mail = new Correos();

        public FrmPerfil(Usuario usuario)
        {
            InitializeComponent();
            txtContrasena.Enabled = true;
            txtUsername.Enabled = true;
            this.usuario = usuario;
            lgu = new LogicaUsuarios();
            txtUsername.Text = usuario.nombre;
            if (lgu.esMiembro(usuario.correo))
            {
                btnMembresia.Enabled = false;
            }
        }

        private void btnMembresia_Click(object sender, EventArgs e)
        {
            if (lgu.agregarMiembro(usuario.correo))
            {
                MessageBox.Show("Ha obtenido la membresía, felicidades.");
                btnMembresia.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lgu.eliminarMiembro(usuario.correo);
            lgu.bajaUsuario(usuario.correo);
            FrmLogin login = new FrmLogin();
            login.Visible = true;
            List<Form> forms = new List<Form>();
            foreach (Form frm in Application.OpenForms)
            {
                if(frm.Name != login.Name)
                {
                    forms.Add(frm);
                }
            }
            foreach(Form frm in forms)
            {
                frm.Dispose();
            }
        }

        private void FrmPerfil_Load(object sender, EventArgs e)
        {
            panel1.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Visible = true;
            List<Form> forms = new List<Form>();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name != login.Name)
                {
                    forms.Add(frm);
                }
            }
            foreach (Form frm in forms)
            {
                frm.Dispose();
            }
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            if(lgu.modificarContrasena(usuario.correo, txtContrasena.Text))
            {
                mail.enviarCorreo(usuario.correo, txtContrasena.Text);
                MessageBox.Show("Contraseña cambiada con éxito, revise correo.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lgu.modificarUsuario(usuario.correo, txtUsername.Text, usuario.rol))
            {
                MessageBox.Show("Nombre de usuario modificado, reinicie la aplicación para visualizar los cambios.");
            }
        }
    }
}
