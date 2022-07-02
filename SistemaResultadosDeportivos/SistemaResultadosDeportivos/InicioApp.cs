using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SistemaResultadosDeportivos
{
    public partial class InicioApp : Form
    {
        APIpublicidad publicidad;
        string jsonPublicidad;
        //APIpublicidad objeto;
        string urlSitio, urlBanner;
        Bitmap bitmapBanner;
        Image imagenBanner;
        public InicioApp()
        {
            InitializeComponent();
            publicidad = new APIpublicidad();
            jsonPublicidad = publicidad.toJSON();
            urlBanner = getUrlBannerFromJson(jsonPublicidad);
            urlSitio = getUrlSitioFromJson(jsonPublicidad);
            setImageBanner(urlBanner);
            adjustSizeImageBanner(imagenBanner);
            setBanner(bitmapBanner);
        }

        private string getUrlSitioFromJson(string jsonInput)
        {
            var publicidadJSON = JsonConvert.DeserializeObject<APIpublicidad>(jsonInput);
            return publicidadJSON.urlSitio;
        }

        private string getUrlBannerFromJson(string jsonInput)
        {
            var publicidadJSON = JsonConvert.DeserializeObject<APIpublicidad>(jsonInput);
            return publicidadJSON.urlBanner;
        }

        private void setImageBanner(string path)
        {
            imagenBanner = Image.FromFile(path);
        }

        private void setBanner(Bitmap b)
        {
            banner.Image = b;
        }

        private void adjustSizeImageBanner(Image img)
        {
            bitmapBanner = new Bitmap(img, banner.Width, banner.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void banner_Click_1(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = urlSitio,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede abrir el link.");
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
