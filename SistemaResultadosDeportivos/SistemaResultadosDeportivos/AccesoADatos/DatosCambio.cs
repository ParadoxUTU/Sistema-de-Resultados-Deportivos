using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaResultadosDeportivos.Modelos;
using ADODB;

namespace SistemaResultadosDeportivos.AccesoADatos
{
    public class DatosCambio
    {
        public List<Cambio> getCambiosByEncuentro(int idEncuentro)
        {
            //Mapea los cambios pertenecientes a un encuentro existentes a los modelos, y los devuelve en una lista
            int idCambio;
            int minuto;
            int idEquipo;
            int jugadorEntrante;
            int jugadorSaliente;
            int segundo;
            List<Cambio> lista = new List<Cambio>();
            String stringSql = "SELECT * FROM Enc_eq_cambios WHERE IdEncuentro = '" + idEncuentro + "';";
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                ADODB.Recordset rs = cn.Execute(stringSql, out object cantFilas, -1);
                if (rs.RecordCount > 0)
                {
                    for (int i = 0; i < (int)cantFilas; i++)
                    {
                        idCambio = (int)rs.Fields[0].Value;
                        minuto = (int)rs.Fields[1].Value;
                        idEquipo = (int)rs.Fields[3].Value;
                        jugadorEntrante = (int)rs.Fields[4].Value;
                        jugadorSaliente = (int)rs.Fields[5].Value;
                        segundo = (int)rs.Fields[6].Value;
                        Cambio cambio = new Cambio(idCambio, minuto, idEncuentro, idEquipo, jugadorEntrante, jugadorSaliente, segundo);
                        lista.Add(cambio);
                        rs.MoveNext();
                    }
                }
                cn.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
            return lista;
        }

        public bool agregarCambio(int minuto, int idEncuentro, int idEquipo, int jugadorEntrante, int jugadorSaliente, int segundo)
        {
            //Intenta agregar un cambio a la BD
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "INSERT INTO Enc_eq_cambios(Minuto, IdEncuentro, IdEquipo, JugadorEntrante, JugadorSaliente, segundo) VALUES('" + minuto + "', '" + idEncuentro + "', '" + idEquipo + "', '" + jugadorEntrante + "', '" + jugadorSaliente + "', '" + segundo + "')";
                cn.Execute(stringSql, out object cantFilas, -1);
                cn.Close();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
    }
}
