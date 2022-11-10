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
using System.Diagnostics;
using System.IO;

namespace SistemaResultadosDeportivos
{
    public partial class SubFrmEquipoApp : Form
    {
        LogicaUsuarios lgu;
        LogicaNotificaciones lgn;
        Usuario usuario;
        Equipo equipo;

        public SubFrmEquipoApp(Usuario usuario, Equipo equipo)
        {
            InitializeComponent();
            lgu = new LogicaUsuarios();
            lgn = new LogicaNotificaciones();
            this.usuario = usuario;
            this.equipo = equipo;
            txtNombre.Text = equipo.nombreEquipo;
            txtPais.Text = equipo.nombrePais;
            actualizarSuscribirse();
            txtNombre.Enabled = false;
            txtPais.Enabled = false;
        }

        private void btnSuscribirse_Click(object sender, EventArgs e)
        {
            if (lgu.esMiembro(usuario.correo))
            {
                List<String> correos = lgn.devolverMiembrosPorSuscripcionEquipo(equipo.idEquipo);
                if (correos.Contains(usuario.correo))
                {
                    lgn.eliminarSuscripcionAEquipo(usuario.correo, equipo.idEquipo);
                }
                else
                {
                    lgn.agregarSuscripcionAEquipo(usuario.correo, equipo.idEquipo);
                }
                actualizarSuscribirse();
            }
            else
            {
                MessageBox.Show("Para acceder a esta función debe de obtener la membresía.");
            }
        }

        private void actualizarSuscribirse()
        {
            List<String> correos = lgn.devolverMiembrosPorSuscripcionEquipo(equipo.idEquipo);
            if (correos.Contains(usuario.correo))
            {
                btnSuscribirse.BackColor = Color.Gray;
                btnSuscribirse.Text = "Suscrito";
            }
            else
            {
                btnSuscribirse.BackColor = Color.MediumTurquoise;
                btnSuscribirse.Text = "Suscribirse";
            }
        }

        private void SubFrmEquipoApp_Load(object sender, EventArgs e)
        {
            panel1.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
        }

        private void btnPlantel_Click(object sender, EventArgs e)
        {
            new SubFrmPlantelApp(equipo).Visible = true;
        }
    }
}
