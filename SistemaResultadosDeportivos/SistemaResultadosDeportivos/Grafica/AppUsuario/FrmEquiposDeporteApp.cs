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
    public partial class FrmEquiposDeporteApp : Form
    {
        APIresultados resultados;
        Deporte deporte;
        List<Equipo> equipos;
        int var = 0;

        public FrmEquiposDeporteApp(Deporte deporte)
        {
            InitializeComponent();
            equipos = new List<Equipo>();
            resultados = new APIresultados();
            this.deporte = deporte;
            setEncEquipos();
            listarEquipos();
        }

        private void setEncEquipos()
        {
            List<String> equiposJson = resultados.getEquiposPorDeporte(deporte.idDeporte);
            for (int i = 0; i < equiposJson.Count; i++)
            {
                Equipo e = JsonConvert.DeserializeObject<Equipo>(equiposJson[i]);
                equipos.Add(e);
            }
        }

        public void listarEquipos()
        {
            flpEquipos.Controls.Clear();
            if (equipos != null)
            {
                int i = 0;
                int tamano = flpEquipos.Width - 5;

                foreach (Equipo e in equipos)
                {
                    String tamanoSt = e.nombreEquipo + " ";
                    String tamanoSt2 = "País: " + e.nombrePais;
                    if (tamanoSt.Length > tamano)
                    {
                        tamano = tamanoSt.Length;
                    }
                    else if (tamanoSt2.Length > tamano)
                    {
                        tamano = tamanoSt2.Length;
                    }
                }

                foreach (Equipo e in equipos)
                {
                    Label lblBoton = new Label();
                    Label lblBoton2 = new Label();
                    Label lblBoton3 = new Label();
                    Button btnEncuentro = new Button();
                    String textNombre = e.nombreEquipo + " ";
                    String textPais = "País: " + e.nombrePais;
                    propiedadesBoton(btnEncuentro, i, tamano);
                    propiedadesLabel(lblBoton, textNombre, btnEncuentro, 8);
                    propiedadesLabel(lblBoton2, textPais, btnEncuentro, 39);
                    btnEncuentro.Controls.Add(lblBoton);
                    btnEncuentro.Controls.Add(lblBoton2);
                    btnEncuentro.Controls.Add(lblBoton3);
                    flpEquipos.Controls.Add(btnEncuentro);
                    btnEncuentro.Click += new EventHandler(btnEncuentro_Click);
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
            if (t == (flpEquipos.Width - 5))
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

        private void btnEncuentro_Click(object sender, EventArgs e)
        {
            Button btnEncuentro = sender as Button;
            int i = (Int32)btnEncuentro.Tag;
            var = i;
            Equipo equipo = equipos[var];
        }

        private void FrmEquiposDeporteApp_Load(object sender, EventArgs e)
        {
            flpEquipos.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
        }
    }
}
