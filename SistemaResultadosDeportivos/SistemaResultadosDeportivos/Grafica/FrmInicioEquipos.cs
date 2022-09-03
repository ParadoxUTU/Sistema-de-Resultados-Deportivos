using SistemaResultadosDeportivos.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaResultadosDeportivos.Logica;
using System.Drawing;


namespace SistemaResultadosDeportivos
{
    public partial class FrmInicioEquipos : Form
    {
        public LogicaEquipos lgeq;
        int var = 0;

        public FrmInicioEquipos()
        {
            InitializeComponent();
            lgeq = new LogicaEquipos();
            this.Dock = DockStyle.Fill;
            listarEquipos();
        }

        public void listarEquipos()
        {
            flpEquipos.Controls.Clear();
            List<Equipo> lista = lgeq.devolverEquipos();
            if (lista != null)
            {
                int i = 0;
                int tamano = flpEquipos.Width - 5;

                foreach (Equipo equipo in lista)
                {
                    String tamanoSt = equipo.nombreEquipo;
                    String tamanoSt2 = "Pais: " + equipo.nombrePais;
                    if (tamanoSt.Length > tamano)
                    {
                        tamano = tamanoSt.Length;
                    }
                    else if (tamanoSt2.Length > tamano)
                    {
                        tamano = tamanoSt2.Length;
                    }
                }

                foreach (Equipo equipo in lista)
                {
                    Label lblBoton = new Label();
                    Label lblBoton2 = new Label();
                    Label lblBoton3 = new Label();
                    Button btnEquipo = new Button();
                    String textNombre = equipo.nombreEquipo + " ";
                    String textPais = "Pais: " + equipo.nombrePais;
                    propiedadesBoton(btnEquipo, i, tamano);
                    propiedadesLabel(lblBoton, textNombre, btnEquipo, 8);
                    propiedadesLabel(lblBoton2, textPais, btnEquipo, 39);
                    btnEquipo.Controls.Add(lblBoton);
                    btnEquipo.Controls.Add(lblBoton2);
                    btnEquipo.Controls.Add(lblBoton3);
                    flpEquipos.Controls.Add(btnEquipo);
                    btnEquipo.Click += new EventHandler(btnEquipo_Click);
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

        private void btnEquipo_Click(object sender, EventArgs e)
        {
            Button btnEncuentro = sender as Button;
            int i = (Int32)btnEncuentro.Tag;
            var = i;
            new FrmSeleccionarPlantel(this).Visible = true;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            new ABMEquipos().Visible = true;
        }

        public Equipo obtenerEquipo()
        {
            List<Equipo> lista = lgeq.devolverEquipos();
            Equipo equipo = lista[var];
            return equipo;
        }

        private void FrmInicioEquipos_Load(object sender, EventArgs e)
        {
            flpEquipos.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
