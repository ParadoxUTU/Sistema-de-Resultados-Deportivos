using SistemaResultadosDeportivos.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaResultadosDeportivos.Logica;
using System.Drawing;

namespace SistemaResultadosDeportivos
{
    public partial class SubFrmEncuentrosTorneo : Form
    {
        public LogicaEncuentros lge;
        Torneo torneo;
        int var = 0;

        public SubFrmEncuentrosTorneo(Torneo torneo)
        {
            InitializeComponent();
            lge = new LogicaEncuentros();
            this.torneo = torneo;
            listarEncuentros();
        }

        private void SubFrmEncuentrosTorneo_Load(object sender, EventArgs e)
        {
            flpEncuentros.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
        }

        public void listarEncuentros()
        {
            flpEncuentros.Controls.Clear();
            List<EncuentroTorneo> lista = lge.devolverEncuentrosPorTorneo(torneo.idTorneo);
            if (lista != null)
            {
                int i = 0;
                int tamano = flpEncuentros.Width - 5;

                foreach (EncuentroTorneo en in lista)
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

                foreach (EncuentroTorneo en in lista)
                {
                    Label lblBoton = new Label();
                    Label lblBoton2 = new Label();
                    Label lblBoton3 = new Label();
                    Button btnEncuentro = new Button();
                    String textNombre = en.nombreEncuentro + "    Etapa: " + en.etapa;
                    String estado = "";
                    if (en.finalizo)
                    {
                        estado = "Finalizado";
                    }
                    else if (en.pausado)
                    {
                        estado = "En descanso";
                    }
                    else if (en.comenzo)
                    {
                        estado = "En curso";
                    }
                    else
                    {
                        estado = "Sin comenzar";
                    }
                    String textFecha = "Fecha: " + en.fecha.Day + "/" + en.fecha.Month + "/" + en.fecha.Year + "                           " + estado;
                    String textHora = "Hora: " + en.hora;
                    propiedadesBoton(btnEncuentro, i, tamano);
                    propiedadesLabel(lblBoton, textNombre, btnEncuentro, 8);
                    propiedadesLabel(lblBoton2, textFecha, btnEncuentro, 39);
                    propiedadesLabel(lblBoton3, textHora, btnEncuentro, 70);
                    btnEncuentro.Controls.Add(lblBoton);
                    btnEncuentro.Controls.Add(lblBoton2);
                    btnEncuentro.Controls.Add(lblBoton3);
                    flpEncuentros.Controls.Add(btnEncuentro);
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
    }
}
