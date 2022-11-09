using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaResultadosDeportivos.Modelos;

namespace SistemaResultadosDeportivos
{
    public partial class SubFrmDatosSetJug : Form
    {
        public FrmGestionarEncIndDeADos encuentro;
        public Jugador jugador;
        public Label lbl;

        public SubFrmDatosSetJug(FrmGestionarEncIndDeADos encuentro, Jugador jugador, Label lbl)
        {
            InitializeComponent();
            this.encuentro = encuentro;
            this.jugador = jugador;
            this.lbl = lbl;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            encuentro.agregarSet(jugador, Convert.ToInt16(numPuntuacion.Value));
            encuentro.setSetsJugador(jugador.idJugador, lbl);
            this.Dispose();
        }
    }
}
