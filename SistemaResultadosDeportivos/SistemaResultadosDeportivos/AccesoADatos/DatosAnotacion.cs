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
    internal class DatosAnotacion
    {
        public List<Anotacion> getAnotacionesByEncuentro(int idEncuentro)
        {
            //Mapea las anotaciones pertenecientes a un encuentro existentes a los modelos, y los devuelve en una lista
            int idAnotacion;
            int idJugador;
            int minuto;
            int puntuacion;
            List<Anotacion> lista = new List<Anotacion>();
            String stringSql = "SELECT * FROM Anotaciones WHERE IdEncuentro = '" + idEncuentro + "';";
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                ADODB.Recordset rs = cn.Execute(stringSql, out object cantFilas, -1);
                if (rs.RecordCount > 0)
                {
                    for (int i = 0; i < (int)cantFilas; i++)
                    {
                        idAnotacion = (int)rs.Fields[0].Value;
                        minuto = (int)rs.Fields[1].Value;
                        idJugador = (int)rs.Fields[4].Value;
                        puntuacion = (int)rs.Fields[5].Value;
                        Anotacion anotacion = new Anotacion(idAnotacion, idJugador, minuto, idEncuentro, 0);
                        lista.Add(anotacion);
                        rs.MoveNext();
                    }
                }
                cn.Close();
            }
            catch { }
            return lista;
        }

        public List<Anotacion> getAnotacionesByEncuentroAndEquipo(int idEncuentro, int idEquipo)
        {
            //Mapea las anotaciones pertenecientes a un encuentro existentes de un equipo, y los devuelve en una lista
            int idAnotacion;
            int idJugador;
            int minuto;
            int puntuacion;
            List<Anotacion> lista = new List<Anotacion>();
            String stringSql = "SELECT * FROM Anotaciones WHERE IdEncuentro = '" + idEncuentro + "' AND IdEquipo = '" + idEquipo + "';";
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                ADODB.Recordset rs = cn.Execute(stringSql, out object cantFilas, -1);
                if (rs.RecordCount > 0)
                {
                    for (int i = 0; i < (int)cantFilas; i++)
                    {
                        idAnotacion = (int)rs.Fields[0].Value;
                        minuto = (int)rs.Fields[1].Value;
                        idJugador = (int)rs.Fields[4].Value;
                        puntuacion = (int)rs.Fields[5].Value;
                        Anotacion anotacion = new Anotacion(idAnotacion, idJugador, minuto, idEncuentro, puntuacion);
                        lista.Add(anotacion);
                        rs.MoveNext();
                    }
                }
                cn.Close();
            }
            catch { }
            return lista;
        }

        public int getSumAnotaciones(int idEncuentro, int idEquipo)
        {
            //Devuelve el total del puntaje de anotaciones de un equipo en un encuentro dado
            int sumaAnotaciones = 0;
            String stringSql = "SELECT SUM(puntuacion) FROM Anotaciones WHERE IdEncuentro = '" + idEncuentro + "' AND IdEquipo = '" + idEquipo + "';";
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                ADODB.Recordset rs = cn.Execute(stringSql, out object cantFilas, -1);
                sumaAnotaciones = (int)rs.Fields[0].Value;
            }catch
            {
                sumaAnotaciones = 0;
            }
            return sumaAnotaciones;
        }

        public bool agregarAnotacion(int idJugador, int minuto, int idEquipo, int idEncuentro, int puntuacion)
        {
            //Intenta agregar un equipo a la BD con los datos dados
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "INSERT INTO Anotaciones (IdJugador, Minuto, IdEquipo, IdEncuentro, puntuacion) VALUES('" + idJugador + "', '" + minuto + "', '" + idEquipo + "', '" + idEncuentro + "', '" + puntuacion + "');";
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

        public bool eliminarAnotacion(int id)
        {
            //Intenta eliminar una anotación de la BD, dada una id
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "DELETE FROM Anotaciones WHERE IdAnotacion = '" + id + "';";
                cn.Execute(stringSql, out object cantFilas, -1);
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool eliminarAnotacionesDeEncuentro(int idEncuentro)
        {
            //Intenta eliminar todas las anotaciones de un encuentro dado en la BD
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "DELETE FROM Anotaciones WHERE IdEncuentro = '" + idEncuentro + "';";
                cn.Execute(stringSql, out object cantFilas, -1);
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool eliminarAnotacionesDeDeporte(int idEncuentro)
        {
            //Intenta eliminar todas las anotaciones de un encuentro dado en la BD
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "DELETE FROM Anotaciones WHERE IdEncuentro = '" + idEncuentro + "';";
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
