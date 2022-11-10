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
    public partial class FrmInicioAppLogin : Form
    {
        APIresultados resultados; 
        List<Deporte> deportes;
        LogicaNotificaciones lgn;
        int var = 0;
        Usuario usuario;

        public FrmInicioAppLogin(Usuario usuario)
        {
            InitializeComponent();
            resultados = new APIresultados();
            deportes = new List<Deporte>();
            lgn = new LogicaNotificaciones();
            setDeportes();
            listarDeportes();
            this.usuario = usuario;
            mostrarNotificacion();
        }

        private void mostrarNotificacion()
        {
            List<Notificacion> notificaciones = lgn.devolverNotificacionesPorMiembro(usuario.correo);
            foreach (Notificacion notificacion in notificaciones)
            {
                notifyIcon1.ShowBalloonTip(100, notificacion.descripcion, "Ha recibido una notificación", ToolTipIcon.Info);
                lgn.eliminarNotificacionesPorUsuario(usuario.correo);
            }
        }

        public void setDeportes()
        {
            List<String> deportesJson = resultados.getDeportes();
            for (int i = 0; i < deportesJson.Count; i++)
            {
                Deporte deporte = JsonConvert.DeserializeObject<Deporte>(deportesJson[i]);
                deportes.Add(deporte);
            }
        }

        public void listarDeportes()
        {
            flpDeportes.Controls.Clear();
            if (deportes != null)
            {
                int i = 0;
                int tamano = flpDeportes.Width - 5;

                foreach (Deporte dep in deportes)
                {
                    String tamanoSt = dep.nombreDeporte;
                    String tamanoSt2;
                    if (dep.porEquipos)
                        tamanoSt2 = "Modalidad: colectivo";
                    else
                        tamanoSt2 = "Modalidad: individual";
                    if (tamanoSt.Length > tamano)
                    {
                        tamano = tamanoSt.Length;
                    }
                    else if (tamanoSt2.Length > tamano)
                    {
                        tamano = tamanoSt2.Length;
                    }
                }

                foreach (Deporte dep in deportes)
                {
                    Label lblBoton = new Label();
                    Label lblBoton2 = new Label();
                    Label lblBoton3 = new Label();
                    Button btnDeporte = new Button();
                    String textNombre = dep.nombreDeporte;
                    String textModalidad;
                    if (dep.porEquipos)
                        textModalidad = "Modalidad: colectivo";
                    else
                        textModalidad = "Modalidad: individual";
                    propiedadesBoton(btnDeporte, i, tamano);
                    propiedadesLabel(lblBoton, textNombre, btnDeporte, 8);
                    propiedadesLabel(lblBoton2, textModalidad, btnDeporte, 39);
                    btnDeporte.Controls.Add(lblBoton);
                    btnDeporte.Controls.Add(lblBoton2);
                    btnDeporte.Controls.Add(lblBoton3);
                    flpDeportes.Controls.Add(btnDeporte);
                    btnDeporte.Click += new EventHandler(btnDeporte_Click);
                    i++;
                }
            }
        }

        private void propiedadesBoton(Button btn, int i, int t)
        {
            btn.Height = 92;
            btn.Tag = i;
            btn.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
            btn.FlatStyle = FlatStyle.Flat;
            if (t == (flpDeportes.Width - 5))
            {
                btn.Width = t;
            }
            else
            {
                btn.Width = t * 10;
            }
        }

        private void propiedadesLabel(Label lbl, String s, Button btn, int l)
        {
            lbl.Text = s;
            lbl.BackColor = System.Drawing.Color.Transparent;
            lbl.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            lbl.ForeColor = System.Drawing.Color.White;
            lbl.Width = s.Length * 10;
            lbl.Location = new System.Drawing.Point(110, l);
        }

        private void btnDeporte_Click(object sender, EventArgs e)
        {
            Button btnDeporte = sender as Button;
            int i = (Int32)btnDeporte.Tag;
            var = i;
            new FrmParent(deportes[var], usuario).Visible = true;
        }

        public Deporte obtenerDeporte()
        {
            Deporte deporte = deportes[var];
            return deporte;
        }


        private void FrmInicioAppLogin_Load(object sender, EventArgs e)
        {
            flpDeportes.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
        }
    }
}
