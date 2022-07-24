using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADODB;
using SistemaResultadosDeportivos.Modelos;

namespace SistemaResultadosDeportivos.AccesoADatos
{
    public class DatosPublicidad
    {
        //ADODB.Recordset rs;

        public List<Publicidad> getPublicidades()
        {
            int idPublicidad;
            string marca;
            string pathBanner;
            string urlSitio;
            List<Publicidad> lista = new List<Publicidad>();
            String stringSql = "SELECT * FROM Publicidad;";
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                ADODB.Recordset rs = cn.Execute(stringSql, out object cantFilas, -1);
                if (rs.RecordCount > 0)
                {
                    for (int i = 0; i < (int)cantFilas; i++)
                    {
                        idPublicidad = (int)rs.Fields[0].Value;
                        marca = (string)rs.Fields[1].Value;
                        pathBanner = (string)rs.Fields[2].Value;
                        urlSitio = (string)rs.Fields[3].Value;
                        Publicidad publicidad = new Publicidad(idPublicidad, marca, pathBanner, urlSitio);
                        lista.Add(publicidad);
                        rs.MoveNext();
                    }
                    cn.Close();
                }
                else
                {
                    cn.Close();
                    return null;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return lista;
        }

        public string getBanner(String idPublicidad)
        {
            String stringSql = "SELECT PathBanner FROM Publicidad WHERE idPublicidad ='" + idPublicidad + "';";
            String urlBanner;
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                ADODB.Recordset rs = cn.Execute(stringSql, out object cantFilas, -1);
                Console.WriteLine(cantFilas);
                urlBanner = rs.Fields[0].Value.ToString();
                cn.Close();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return urlBanner;
        }

        public string[,] getAllBanners() //retorna urlBanner y urlSitio en un array2D de todas las filas.
        {
            String stringSql = "SELECT * FROM Publicidad;";
            string[,] pareja;
            string urlSitio, urlBanner;
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                ADODB.Recordset rs = cn.Execute(stringSql, out object cantFilas, -1);
                pareja = new string[(int)cantFilas, 2];
                for (int i = 0; i < (int)cantFilas; i++)
                {
                    urlSitio = rs.Fields[3].Value.ToString();
                    urlBanner = rs.Fields[2].Value.ToString();
                    pareja[i, 0] = urlSitio;
                    pareja[i, 1] = urlBanner;
                    rs.MoveNext();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            return pareja;
        }
    }
}
