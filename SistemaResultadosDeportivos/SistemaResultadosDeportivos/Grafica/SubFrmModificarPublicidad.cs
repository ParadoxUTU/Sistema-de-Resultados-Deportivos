using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace SistemaResultadosDeportivos
{
    public partial class SubFrmModificarPublicidad : Form
    {
        ABMPublicidad publicidad;

        public SubFrmModificarPublicidad(ABMPublicidad p)
        {
            InitializeComponent();
            publicidad = p;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtMarca.Enabled = true;
            txtUrlBanner.Enabled = true;
            txtUrlSitio.Enabled = true;
            btnModificar.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Recoge los datos de modificacion, y los envía al frame original para su confirmacion
            String marca = txtMarca.Text;
            String pathBanner = txtUrlBanner.Text;
            String urlSitio = txtUrlSitio.Text;
            if (!marca.Equals("") && !pathBanner.Equals("") && !urlSitio.Equals(""))
            {
                this.Dispose();
                if (!publicidad.confirmarModificacion(marca, pathBanner, urlSitio))
                {
                    new SubFrmModificarPublicidad(publicidad).Visible = true;
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Datos invalidos.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Estás seguro?", "Confirmar baja de publicidad", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == System.Windows.MessageBoxResult.Yes)
            {
                publicidad.eliminarPublicidad();
                this.Dispose();
            }
        }

        private void SubFrmModificarPublicidad_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            txtMarca.Text = publicidad.obtenerMarca();
            txtUrlBanner.Text = publicidad.obtenerBanner();
            txtUrlSitio.Text = publicidad.obtenerSitio();
            if (File.Exists(Directory.GetCurrentDirectory() + "\\Img\\" + txtUrlBanner.Text))
            {
                Image imagenBanner = Image.FromFile(Directory.GetCurrentDirectory() + "\\Img\\" + txtUrlBanner.Text);
                Bitmap bitmapBanner = new Bitmap(imagenBanner, pnlBanner.Width, pnlBanner.Height);
                pnlBanner.BackgroundImage = bitmapBanner;
            }
            else
            {
                Image imagenBanner = Properties.Resources.error;
                Bitmap bitmapBanner = new Bitmap(imagenBanner, pnlBanner.Width, pnlBanner.Height);
                pnlBanner.BackgroundImage = bitmapBanner;
            }
        }
    }
}






