﻿using System;
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
    public partial class FrmParent : Form
    {
        Deporte deporte;
        Usuario usuario;
        LogicaNotificaciones lgn;

        public FrmParent(Deporte deporte, Usuario usuario)
        {
            InitializeComponent();
            lgn = new LogicaNotificaciones();
            this.deporte = deporte;
            if (!deporte.porEquipos)
            {
                btnEquipos.Enabled = false;
            }
            this.usuario = usuario;
        }

        private void btnEncuentros_Click(object sender, EventArgs e)
        {
            new FrmEncuentrosDeporteApp(deporte, usuario).Visible = true;
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            new FrmEquiposDeporteApp(deporte, usuario).Visible = true;
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            new FrmJugadoresDeporteApp(deporte).Visible = true;
        }

        private void btnTorneos_Click(object sender, EventArgs e)
        {
            new FrmTorneosDeporteApp(deporte, usuario).Visible = true;
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            new FrmPerfil(usuario).Visible = true;
        }
    }
}
