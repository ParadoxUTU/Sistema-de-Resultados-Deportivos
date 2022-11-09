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
    public class DatosNotificacion
    {
        public List<Notificacion> getNotificacionesByMiembro(String dirCorreo)
        {
            //Mapea las notificaciones de un miembro existentes a los modelos, y los devuelve en una lista
            String descripcion;
            List<Notificacion> lista = new List<Notificacion>();
            String stringSql = "SELECT * FROM Notificaciones_usuarios WHERE DirCorreo = '" + dirCorreo + "';";
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                ADODB.Recordset rs = cn.Execute(stringSql, out object cantFilas, -1);
                if (rs.RecordCount > 0)
                {
                    for (int i = 0; i < (int)cantFilas; i++)
                    {
                        descripcion = (String)rs.Fields[0].Value;
                        Notificacion notificacion = new Notificacion(dirCorreo, descripcion);
                        lista.Add(notificacion);
                        rs.MoveNext();
                    }
                }
                cn.Close();
            }
            catch { }
            return lista;
        }

        public bool agregarNotificacion(String dirCorreo, String descripcion)
        {
            //Intenta agregar una notificacion a la BD con los datos dados
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "INSERT INTO Notificaciones_usuarios (DirCorreo, Descripcion) VALUES('" + dirCorreo + "', '" + descripcion + "');";
                cn.Execute(stringSql, out object cantFilas, -1);
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool eliminarNotificacionesPorUsuario(String dirCorreo)
        {
            //Intenta eliminar todas las notificaciones de un usuario dado su correo
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "DELETE FROM Notificaciones_usuarios WHERE DirCorreo = '" + dirCorreo + "';";
                cn.Execute(stringSql, out object cantFilas, -1);
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool agregarSuscripcionAEquipo(String dirCorreo, int idEquipo)
        {
            //Intenta agregar una suscripcion de un equipo a la BD con los datos dados
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "INSERT INTO Miembros_equipos (DirCorreo, IdEquipo) VALUES('" + dirCorreo + "', '" + idEquipo + "');";
                cn.Execute(stringSql, out object cantFilas, -1);
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<String> getMiembrosPorSuscripcionEquipo(int idEquipo)
        {
            //Mapea los miembros suscritos a un equipo existente a los modelos, y los devuelve en una lista
            String dirCorreo;
            List<String> lista = new List<String>();
            String stringSql = "SELECT DirCorreo FROM Miembros_equipos WHERE IdEquipo = '" + idEquipo + "';";
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                ADODB.Recordset rs = cn.Execute(stringSql, out object cantFilas, -1);
                if (rs.RecordCount > 0)
                {
                    for (int i = 0; i < (int)cantFilas; i++)
                    {
                        dirCorreo = (String)rs.Fields[0].Value;
                        lista.Add(dirCorreo);
                        rs.MoveNext();
                    }
                }
                cn.Close();
            }
            catch { }
            return lista;
        }

        public bool eliminarSuscripcionAEquipo(String dirCorreo, int idEquipo)
        {
            //Intenta eliminar una suscripcion de un equipo a la BD con los datos dados
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "DELETE FROM Miembros_equipos (DirCorreo, IdEquipo) WHERE DirCorreo = '" + dirCorreo + "' AND IdEquipo = '" + idEquipo + "';";
                cn.Execute(stringSql, out object cantFilas, -1);
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool agregarSuscripcionAEncuentro(String dirCorreo, int idEncuentro)
        {
            //Intenta agregar una suscripcion de un encuentro a la BD con los datos dados
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "INSERT INTO Miembros_encuentros (DirCorreo, IdEncuentro) VALUES('" + dirCorreo + "', '" + idEncuentro + "');";
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

        public List<String> getMiembrosPorSuscripcionEncuentro(int idEncuentro)
        {
            //Mapea los miembros suscritos a un encuentro existente a los modelos, y los devuelve en una lista
            String dirCorreo;
            List<String> lista = new List<String>();
            String stringSql = "SELECT DirCorreo FROM Miembros_encuentros WHERE IdEncuentro = '" + idEncuentro + "';";
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                ADODB.Recordset rs = cn.Execute(stringSql, out object cantFilas, -1);
                if (rs.RecordCount > 0)
                {
                    for (int i = 0; i < (int)cantFilas; i++)
                    {
                        dirCorreo = (String)rs.Fields[0].Value;
                        lista.Add(dirCorreo);
                        rs.MoveNext();
                    }
                }
                cn.Close();
            }
            catch { }
            return lista;
        }

        public bool eliminarSuscripcionAEncuentro(String dirCorreo, int idEncuentro)
        {
            //Intenta eliminar una suscripcion de un encuentro a la BD con los datos dados
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "DELETE FROM Miembros_encuentro (DirCorreo, IdEncuentro) WHERE DirCorreo = '" + dirCorreo + "' AND IdEncuentro = '" + idEncuentro + "';";
                cn.Execute(stringSql, out object cantFilas, -1);
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool agregarSuscripcionATorneo(String dirCorreo, int idTorneo)
        {
            //Intenta agregar una suscripcion de un torneo a la BD con los datos dados
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "INSERT INTO Miembros_torneos (DirCorreo, IdTorneo) VALUES('" + dirCorreo + "', '" + idTorneo + "');";
                cn.Execute(stringSql, out object cantFilas, -1);
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<String> getMiembrosPorSuscripcionTorneo(int idTorneo)
        {
            //Mapea los miembros suscritos a un torneo existente a los modelos, y los devuelve en una lista
            String dirCorreo;
            List<String> lista = new List<String>();
            String stringSql = "SELECT DirCorreo FROM Miembros_torneos WHERE IdTorneo = '" + idTorneo + "';";
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                ADODB.Recordset rs = cn.Execute(stringSql, out object cantFilas, -1);
                if (rs.RecordCount > 0)
                {
                    for (int i = 0; i < (int)cantFilas; i++)
                    {
                        dirCorreo = (String)rs.Fields[0].Value;
                        lista.Add(dirCorreo);
                        rs.MoveNext();
                    }
                }
                cn.Close();
            }
            catch { }
            return lista;
        }

        public bool eliminarSuscripcionATorneo(String dirCorreo, int idTorneo)
        {
            //Intenta eliminar una suscripcion de un torneo a la BD con los datos dados
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "DELETE FROM Miembros_torneos (DirCorreo, IdTorneo) WHERE DirCorreo = '" + dirCorreo + "' AND IdTorneo = '" + idTorneo + "';";
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
