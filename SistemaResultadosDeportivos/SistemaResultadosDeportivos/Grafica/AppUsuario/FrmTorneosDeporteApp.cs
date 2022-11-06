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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.IO;

namespace SistemaResultadosDeportivos
{
    public partial class FrmTorneosDeporteApp : Form
    {
        APIresultados resultados;
        Deporte deporte;
        List<Torneo> torneos;
        int var = 0;

        public FrmTorneosDeporteApp(Deporte deporte)
        {
            InitializeComponent();
            torneos = new List<Torneo>();
            resultados = new APIresultados();
            this.deporte = deporte;
            setTorneos();
            listarTorneos();
        }

        private void setTorneos()
        {
            List<String> torneosJson = resultados.getTorneosByDeporte(deporte.idDeporte);
            for (int i = 0; i < torneosJson.Count; i++)
            {
                Torneo t = JsonConvert.DeserializeObject<Torneo>(torneosJson[i]);
                torneos.Add(t);
            }
        }

        public void listarTorneos()
        {
            flpTorneos.Controls.Clear();
            if (torneos != null)
            {
                int i = 0;
                int tamano = flpTorneos.Width - 5;

                foreach (Torneo tor in torneos)
                {
                    String tamanoSt = tor.nombreTorneo;
                    String tamanoSt2 = "Pais: " + tor.nombrePais;
                    if (tamanoSt.Length > tamano)
                    {
                        tamano = tamanoSt.Length;
                    }
                    else if (tamanoSt2.Length > tamano)
                    {
                        tamano = tamanoSt2.Length;
                    }
                }

                foreach (Torneo tor in torneos)
                {
                    Label lblBoton = new Label();
                    Label lblBoton2 = new Label();
                    Label lblBoton3 = new Label();
                    Button btnTorneo = new Button();
                    String textNombre = tor.nombreTorneo;
                    String textFecha = "Pais: " + tor.nombrePais;
                    String textHora = "Fecha: " + tor.fechaComienzo;
                    propiedadesBoton(btnTorneo, i, tamano);
                    propiedadesLabel(lblBoton, textNombre, btnTorneo, 8);
                    propiedadesLabel(lblBoton2, textFecha, btnTorneo, 39);
                    propiedadesLabel(lblBoton3, textHora, btnTorneo, 70);
                    btnTorneo.Controls.Add(lblBoton);
                    btnTorneo.Controls.Add(lblBoton2);
                    btnTorneo.Controls.Add(lblBoton3);
                    flpTorneos.Controls.Add(btnTorneo);
                    btnTorneo.Click += new EventHandler(btnTorneo_Click);
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
            if (t == (flpTorneos.Width - 5))
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

        private void btnTorneo_Click(object sender, EventArgs e)
        {
            Button btnTorneo = sender as Button;
            int i = (Int32)btnTorneo.Tag;
            var = i;
        }

        private void FrmTorneosDeporteApp_Load(object sender, EventArgs e)
        {
            flpTorneos.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
        }
    }
}
