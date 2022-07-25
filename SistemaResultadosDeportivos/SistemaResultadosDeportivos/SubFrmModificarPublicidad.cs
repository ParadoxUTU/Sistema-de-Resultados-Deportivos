using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaResultadosDeportivos
{
    public partial class SubFrmModificarPublicidad : Form
    {
        ABMPublicidad publicidad;
        public int id;
        public SubFrmModificarPublicidad(ABMPublicidad p, int i)
        {
            InitializeComponent();
            publicidad = p;
            id = i;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String marca = txtMarca.Text;
            String pathBanner = txtUrlBanner.Text;
            String urlSitio = txtUrlSitio.Text;
            if (!marca.Equals("") && !pathBanner.Equals("") && !urlSitio.Equals(""))
            {
                if (publicidad.sqlModificar(id, marca, pathBanner, urlSitio))
                {
                    publicidad.listarPublicidad();
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Datos invalidos.");
            }
        }
    }
}






