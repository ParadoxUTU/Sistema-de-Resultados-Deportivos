using SistemaResultadosDeportivos.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaResultadosDeportivos.Logica;
using System.Drawing;

namespace SistemaResultadosDeportivos
{
    public partial class FrmInicioEncuentros : Form
    {
        public LogicaEncuentros lge;
        int var = 0;

        public FrmInicioEncuentros()
        {
            InitializeComponent();
            lge = new LogicaEncuentros();
            this.Dock = DockStyle.Fill;
            listarEncuentros();
        }

        public void listarEncuentros()
        {
            flpEncuentros.Controls.Clear();
            List<Encuentro> lista = lge.devolverEncuentros();
            if (lista != null)
            {
                int i = 0;
                int tamano = flpEncuentros.Width - 5;

                foreach (Encuentro en in lista)
                {
                    String tamanoSt = en.nombreEncuentro;
                    String tamanoSt2 = "Fecha: " + en.fecha;
                    if (tamanoSt.Length > tamano)
                    {
                        tamano = tamanoSt.Length;
                    }
                    else if (tamanoSt2.Length > tamano)
                    {
                        tamano = tamanoSt2.Length;
                    }
                }

                foreach (Encuentro en in lista)
                {
                    Label lblBoton = new Label();
                    Label lblBoton2 = new Label();
                    Label lblBoton3 = new Label();
                    Button btnEncuentro = new Button();
                    String textNombre = en.nombreEncuentro;
                    String textFecha = "Fecha: " + en.fecha.Day + "/" + en.fecha.Month + "/" + en.fecha.Year;
                    String textHora = "Hora:"; 
                    if (en.hora.Hour < 10)
                        textHora += " 0" + en.hora.Hour + ":";
                    else
                        textHora += " " + en.hora.Hour + ":";
                    if (en.hora.Minute < 10)
                        textHora += "0" + en.hora.Minute;
                    else
                        textHora += en.hora.Minute;
                    propiedadesBoton(btnEncuentro, i, tamano);
                    propiedadesLabel(lblBoton, textNombre, btnEncuentro, 8);
                    propiedadesLabel(lblBoton2, textFecha, btnEncuentro, 39);
                    propiedadesLabel(lblBoton3, textHora, btnEncuentro, 70);
                    btnEncuentro.Controls.Add(lblBoton);
                    btnEncuentro.Controls.Add(lblBoton2);
                    btnEncuentro.Controls.Add(lblBoton3);
                    flpEncuentros.Controls.Add(btnEncuentro);
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
            if (t == (flpEncuentros.Width - 5))
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

        public Encuentro obtenerEncuentro()
        {
            List<Encuentro> lista = lge.devolverEncuentros();
            Encuentro en = lista[var];
            return en;
        }

        private void btnEncuentro_Click(object sender, EventArgs e)
        {
            Button btnEncuentro = sender as Button;
            int i = (Int32)btnEncuentro.Tag;
            var = i;
            new SubFrmModificarEncuentro(this).Visible = true;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            ABMEncuentros encuentros = new ABMEncuentros(this);
            encuentros.Show();
        }

        private void FrmInicioEncuentros_Load(object sender, EventArgs e)
        {
            flpEncuentros.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
