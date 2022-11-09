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
    public class DatosAmonestacion
    {
        public List<Amonestacion> getAmonestacionesByDeporte(int idDeporte)
        {
            //Mapea las anotaciones pertenecientes a un deporte existentes a los modelos, y los devuelve en una lista
            String nombreAmonestacion;
            List<Amonestacion> lista = new List<Amonestacion>();
            String stringSql = "SELECT * FROM Amonestaciones WHERE IdDeporte = '" + idDeporte + "';";
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                ADODB.Recordset rs = cn.Execute(stringSql, out object cantFilas, -1);
                if (rs.RecordCount > 0)
                {
                    for (int i = 0; i < (int)cantFilas; i++)
                    {
                        nombreAmonestacion = (String)rs.Fields[1].Value;
                        Amonestacion amonestacion = new Amonestacion(idDeporte, nombreAmonestacion);
                        lista.Add(amonestacion);
                        rs.MoveNext();
                    }
                }
                cn.Close();
            }
            catch { }
            return lista;
        }

        public bool eliminarAmonestacion(int id, String nombre)
        {
            //Intenta eliminar una amonestacion de la BD, dada una id
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "DELETE FROM Amonestaciones WHERE IdDeporte = '" + id + "' AND NombreAmonestacion = '" + nombre + "';";
                cn.Execute(stringSql, out object cantFilas, -1);
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool agregarAmonestacion(int id, String nombre)
        {
            //Intenta agregar una amonestacion a la BD
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "INSERT INTO Amonestaciones VALUES('" + id + "', '" + nombre + "')";
                cn.Execute(stringSql, out object cantFilas, -1);
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
