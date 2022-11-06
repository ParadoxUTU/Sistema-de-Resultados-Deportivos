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
    public partial class FrmVerEncuentroEquipo : Form
    {
        APIresultados resultados;
        Encuentro encuentro;
        Deporte deporte;
        Equipo equipo1;
        Equipo equipo2;

        public FrmVerEncuentroEquipo(Encuentro e)
        {
            InitializeComponent();
            timer1.Enabled = true;
            resultados = new APIresultados();
            encuentro = e;
            deporte = JsonConvert.DeserializeObject<Deporte>(resultados.getDeporte(encuentro.idDeporte));
            equipo1 = JsonConvert.DeserializeObject<Equipo>(resultados.getEquiposPorEncuentro(encuentro.idEncuentro)[0]);
            equipo2 = JsonConvert.DeserializeObject<Equipo>(resultados.getEquiposPorEncuentro(encuentro.idEncuentro)[1]);
            lblEquipo1.Text = equipo1.nombreEquipo;
            lblEquipo2.Text = equipo2.nombreEquipo;
            if (deporte.anotaciones)
            {
                setAnotacionesEquipo(encuentro.idEncuentro, equipo1.idEquipo, lblPuntaje1);
                setAnotacionesEquipo(encuentro.idEncuentro, equipo2.idEquipo, lblPuntaje2);
            }
            else
            {
                setSetsEquipo(encuentro.idEncuentro, equipo1.idEquipo, lblPuntaje1);
                setSetsEquipo(encuentro.idEncuentro, equipo2.idEquipo, lblPuntaje2);
            }
            lblMinuto.Text = Convert.ToString(encuentro.minActual);
        }

        public void setSetsEquipo(int idEncuentro, int idEquipo, Label lbl)
        {
            List<Set> sets = new List<Set>();
            List<String> setsJson = resultados.getSetsEquipo(idEquipo, idEncuentro);
            for (int i = 0; i < setsJson.Count; i++)
            {
                Set s = JsonConvert.DeserializeObject<Set>(setsJson[i]);
                sets.Add(s);
            }
            if(sets.Count > 0)
            {
                lbl.Text = "";
                foreach (Set set in sets)
                {
                    lbl.Text += " " + set.puntuacionSet;
                }
            }
        }

        public void setAnotacionesEquipo(int idEncuentro, int idEquipo, Label lbl)
        {
            RespuestaAnotaciones puntaje1 = JsonConvert.DeserializeObject<RespuestaAnotaciones>(resultados.getAnotacionesEquipo(idEncuentro, idEquipo));
            lbl.Text = puntaje1.puntaje.ToString();
        }

        private void FrmVerEncuentroApp_Load(object sender, EventArgs e)
        {
            flpIncidencias.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            encuentro = JsonConvert.DeserializeObject<Encuentro>(resultados.getEncuentro(encuentro.idEncuentro));
            lblMinuto.Text = encuentro.minActual.ToString();
        }
    }
}
