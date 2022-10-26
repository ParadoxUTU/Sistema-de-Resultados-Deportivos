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
    public partial class SubFrmDatosSetEq : Form
    {
        public FrmGestionarEncCol encuentro;
        public Equipo equipo;
        public Label lbl;

        public SubFrmDatosSetEq(FrmGestionarEncCol encuentro, Equipo equipo, Label lbl)
        {
            InitializeComponent();
            this.encuentro = encuentro;
            this.equipo = equipo;
            this.lbl = lbl;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            encuentro.agregarSet(equipo, Convert.ToInt16(numPuntuacion.Value));
            encuentro.setSetsEquipo(equipo.idEquipo, lbl);
            this.Dispose();
        }
    }
}
