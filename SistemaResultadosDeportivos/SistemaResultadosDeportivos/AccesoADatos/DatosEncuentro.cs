﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaResultadosDeportivos.Modelos;
using ADODB;

namespace SistemaResultadosDeportivos.AccesoADatos
{
    internal class DatosEncuentro
    {
        public List<Encuentro> getEncuentros()
        {
            //Mapea los encuentros existentes a los modelos, y los devuelve en una lista
            int idEncuentro;
            DateTime fecha;
            DateTime hora;
            bool pausado = false;
            int minActual;
            int segActual;
            bool comenzo = false;
            bool finalizo = false;
            String nombreEncuentro;
            int idDeporte;
            List<Encuentro> lista = new List<Encuentro>();
            String stringSql = "SELECT * FROM Encuentros;";
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                ADODB.Recordset rs = cn.Execute(stringSql, out object cantFilas, -1);
                if (rs.RecordCount > 0)
                {
                    for (int i = 0; i < (int)cantFilas; i++)
                    {
                        idEncuentro = (int)rs.Fields[0].Value;
                        fecha = rs.Fields[1].Value;
                        hora = rs.Fields[2].Value;
                        pausado = Convert.ToBoolean(rs.Fields[3].Value);
                        minActual = (int)rs.Fields[4].Value;
                        if (rs.Fields[5].Value != null)
                            segActual = (int)rs.Fields[5].Value;
                        else
                            segActual = 0;
                        comenzo = Convert.ToBoolean(rs.Fields[6].Value);
                        finalizo = Convert.ToBoolean(rs.Fields[7].Value);
                        nombreEncuentro = (String)rs.Fields[8].Value;
                        idDeporte = (int)rs.Fields[9].Value;
                        Encuentro encuentro = new Encuentro(idEncuentro, fecha, hora, pausado, minActual, segActual, comenzo, finalizo, nombreEncuentro, idDeporte);
                        lista.Add(encuentro);
                        rs.MoveNext();
                    }
                }
                cn.Close();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            return lista;
        }

        public Encuentro getEncuentroById(int id)
        {
            //Devuelve un encuentro dependiendo de su ID
            DateTime fecha;
            DateTime hora;
            bool pausado = false;
            int minActual;
            int segActual;
            bool comenzo = false;
            bool finalizo = false;
            String nombreEncuentro;
            int idDeporte;
            Encuentro encuentro = null;
            String stringSql = "SELECT * FROM Encuentros WHERE IdEncuentro = '" + id + "';";
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                ADODB.Recordset rs = cn.Execute(stringSql, out object cantFilas, -1);
                if (rs.RecordCount > 0)
                {
                    fecha = rs.Fields[1].Value;
                    hora = rs.Fields[2].Value;
                    pausado = Convert.ToBoolean(rs.Fields[3].Value);
                    minActual = (int)rs.Fields[4].Value;
                    segActual = (int)rs.Fields[5].Value;
                    comenzo = Convert.ToBoolean(rs.Fields[6].Value);
                    finalizo = Convert.ToBoolean(rs.Fields[7].Value);
                    nombreEncuentro = (String)rs.Fields[8].Value;
                    idDeporte = (int)rs.Fields[9].Value;
                    encuentro = new Encuentro(id, fecha, hora, pausado, minActual, segActual, comenzo, finalizo, nombreEncuentro, idDeporte);
                    rs.MoveNext();

                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return encuentro;
        }

        public List<EncuentroTorneo> getEncuentrosByTorneo(int idTorneo)
        {
            //Mapea los encuentros existentes a los modelos, y los devuelve en una lista
            int idEncuentro;
            DateTime fecha;
            DateTime hora;
            bool pausado;
            int minActual;
            int segActual;
            bool comenzo;
            bool finalizo;
            String nombreEncuentro;
            int idDeporte;
            String etapa;
            List<EncuentroTorneo> lista = new List<EncuentroTorneo>();
            String stringSql = "SELECT * FROM Encuentros_Torneos INNER JOIN Encuentros ON Encuentros_Torneos.IdEncuentro=Encuentros.IdEncuentro WHERE IdTorneo = '" + idTorneo + "';";
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                ADODB.Recordset rs = cn.Execute(stringSql, out object cantFilas, -1);
                if (rs.RecordCount > 0)
                {
                    for (int i = 0; i < (int)cantFilas; i++)
                    {
                        etapa = (string)rs.Fields[2].Value;
                        idEncuentro = (int)rs.Fields[3].Value;
                        fecha = rs.Fields[4].Value;
                        hora = rs.Fields[5].Value;
                        pausado = Convert.ToBoolean(rs.Fields[6].Value);
                        minActual = (int)rs.Fields[7].Value;
                        segActual = (int)rs.Fields[8].Value;
                        comenzo = Convert.ToBoolean(rs.Fields[9].Value);
                        finalizo = Convert.ToBoolean(rs.Fields[10].Value);
                        nombreEncuentro = (String)rs.Fields[11].Value;
                        idDeporte = (int)rs.Fields[9].Value;
                        EncuentroTorneo encuentro = new EncuentroTorneo(etapa, idEncuentro, fecha, hora, pausado, minActual, segActual, comenzo, finalizo, nombreEncuentro, idDeporte);
                        lista.Add(encuentro);
                        rs.MoveNext();
                    }
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return lista;
        }

        public List<Encuentro> getEncuentrosByDeporte(int idDeporte)
        {
            //Mapea los encuentros existentes a los modelos, y los devuelve en una lista
            int idEncuentro;
            DateTime fecha;
            DateTime hora;
            bool pausado;
            int minActual;
            int segActual;
            bool comenzo;
            bool finalizo;
            String nombreEncuentro;
            List<Encuentro> lista = new List<Encuentro>();
            String stringSql = "SELECT * FROM Encuentros WHERE IdDeporte = '" + idDeporte + "';";
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                ADODB.Recordset rs = cn.Execute(stringSql, out object cantFilas, -1);
                if (rs.RecordCount > 0)
                {
                    for (int i = 0; i < (int)cantFilas; i++)
                    {
                        idEncuentro = (int)rs.Fields[0].Value;
                        fecha = rs.Fields[1].Value;
                        hora = rs.Fields[2].Value;
                        pausado = Convert.ToBoolean(rs.Fields[3].Value);
                        minActual = (int)rs.Fields[4].Value;
                        segActual = (int)rs.Fields[5].Value;
                        comenzo = Convert.ToBoolean(rs.Fields[6].Value);
                        finalizo = Convert.ToBoolean(rs.Fields[7].Value);
                        nombreEncuentro = (String)rs.Fields[8].Value;
                        idDeporte = (int)rs.Fields[9].Value;
                        Encuentro encuentro = new Encuentro(idEncuentro, fecha, hora, pausado, minActual, segActual, comenzo, finalizo, nombreEncuentro, idDeporte);
                        lista.Add(encuentro);
                        rs.MoveNext();
                    }
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return lista;
        }

        public int getCountEncuentrosEquipos(int idEncuentro)
        {
            //Devuelve la cantidad de equipos que hay seleccionados en un encuentro
            int cantidadEquipos = 0;
            String stringSql = "SELECT * FROM Encuentros_Equipos WHERE IdEncuentro = '" + idEncuentro + "';";
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                ADODB.Recordset rs = cn.Execute(stringSql, out object cantFilas, -1);
                cantidadEquipos = rs.RecordCount;
            }
            catch
            {
                cantidadEquipos = 0;
            }
            return cantidadEquipos;
        }

        public int getCountEncuentrosJugadores(int idEncuentro)
        {
            //Devuelve la cantidad de equipos que hay seleccionados en un encuentro
            int cantidadJugadores = 0;
            String stringSql = "SELECT * FROM Encuentros_Jugadores WHERE IdEncuentro = '" + idEncuentro + "';";
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                ADODB.Recordset rs = cn.Execute(stringSql, out object cantFilas, -1);
                cantidadJugadores = rs.RecordCount;
            }
            catch
            {
                cantidadJugadores = 0;
            }
            return cantidadJugadores;
        }

        public int getMinActual(int idEncuentro)
        {
            //Devuelve el minuto actual de un encuentro
            int minActual = 0;
            String stringSql = "SELECT MinActual FROM Encuentros WHERE IdEncuentro = '" + idEncuentro + "';";
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                ADODB.Recordset rs = cn.Execute(stringSql, out object cantFilas, -1);
                minActual = Convert.ToInt16(rs.Fields[0]);
            }
            catch{}
            return minActual;
        }

        public bool actualizarMinActual(int id, int minActual, int segActual)
        {
            //Intenta actualizar el minuto actual de un encuentro
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "UPDATE Encuentros SET MinActual = '" + minActual + "', SegActual = '" + segActual + "' WHERE IdEncuentro = '" + id + "';";
                cn.Execute(stringSql, out object cantFilas, -1);
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool pausarEncuentro(int id)
        {
            //Intenta pausar el encuentro
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "UPDATE Encuentros SET Pausado = '1' WHERE IdEncuentro = '" + id + "';";
                cn.Execute(stringSql, out object cantFilas, -1);
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool reanudarEncuentro(int id)
        {
            //Intenta pausar el encuentro
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "UPDATE Encuentros SET Pausado = '0' WHERE IdEncuentro = '" + id + "';";
                cn.Execute(stringSql, out object cantFilas, -1);
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool iniciarEncuentro(int id)
        {
            //Intenta iniciar el encuentro
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "UPDATE Encuentros SET Comenzo = '1' WHERE IdEncuentro = '" + id + "';";
                cn.Execute(stringSql, out object cantFilas, -1);
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool finalizarEncuentro(int id)
        {
            //Intenta iniciar el encuentro
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "UPDATE Encuentros SET Finalizo = '1' WHERE IdEncuentro = '" + id + "';";
                cn.Execute(stringSql, out object cantFilas, -1);
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Alineacion> getAlineacion(int idEquipo, int idEncuentro)
        {
            //Devuelve la alineacion de un equipo en un encuentro dado
            int idJugador;
            List<Alineacion> lista = new List<Alineacion>();
            String stringSql = "SELECT * FROM Alineaciones WHERE IdEquipo = '" + idEquipo + "' AND IdEncuentro = '" + idEncuentro + "';";
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                ADODB.Recordset rs = cn.Execute(stringSql, out object cantFilas, -1);
                if (rs.RecordCount > 0)
                {
                    for (int i = 0; i < (int)cantFilas; i++)
                    {
                        idJugador = (int)rs.Fields[0].Value;
                        Alineacion alineacion = new Alineacion(idEquipo, idEncuentro, idJugador, 0);
                        lista.Add(alineacion);
                        rs.MoveNext();
                    }
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return lista;
        }

        public List<Alineacion> getJugando(int idEquipo, int idEncuentro)
        {
            //Devuelve los jugadores que están jugando de un equipo en un encuentro dado
            int idJugador;
            List<Alineacion> lista = new List<Alineacion>();
            String stringSql = "SELECT IdJugador FROM Alineaciones WHERE IdEquipo = '" + idEquipo + "' AND (Alineaciones.IdJugador NOT IN (SELECT JugadorSaliente FROM Enc_eq_cambios WHERE IdEncuentro = '" + idEncuentro + "') AND IdEncuentro = '" + idEncuentro + "'); ";
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                ADODB.Recordset rs = cn.Execute(stringSql, out object cantFilas, -1);
                if (rs.RecordCount > 0)
                {
                    for (int i = 0; i < (int)cantFilas; i++)
                    {
                        idJugador = (int)rs.Fields[0].Value;
                        Alineacion alineacion = new Alineacion(idEquipo, idEncuentro, idJugador, 0);
                        lista.Add(alineacion);
                        rs.MoveNext();
                    }
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return lista;
        }

        public List<Alineacion> getBanco(int idEquipo, int idEncuentro)
        {
            //Devuelve los jugadores que están jugando de un equipo en un encuentro dado
            int idJugador;
            List<Alineacion> lista = new List<Alineacion>();
            String stringSql = "SELECT * FROM Plantel WHERE IdEquipo = '" + idEquipo + "' AND (Plantel.IdJugador NOT IN (SELECT Alineaciones.IdJugador FROM Alineaciones WHERE Alineaciones.IdJugador NOT IN (SELECT JugadorSaliente FROM Enc_eq_cambios WHERE IdEncuentro = '" + idEncuentro + "') AND IdEncuentro = '" + idEncuentro + "')) AND Plantel.IdJugador NOT IN (SELECT JugadorSaliente FROM Enc_eq_cambios WHERE IdEquipo = '" + idEquipo + "' AND IdEncuentro = '" + idEncuentro + "');";
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                ADODB.Recordset rs = cn.Execute(stringSql, out object cantFilas, -1);
                if (rs.RecordCount > 0)
                {
                    for (int i = 0; i < (int)cantFilas; i++)
                    {
                        idJugador = (int)rs.Fields[1].Value;
                        MessageBox.Show(idJugador.ToString());
                        Alineacion alineacion = new Alineacion(idEquipo, idEncuentro, idJugador, 0);
                        lista.Add(alineacion);
                        rs.MoveNext();
                    }
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return lista;
        }

        public bool agregarEncuentro(String fecha, String hora, bool pausado, int minActual, int segActual, bool comenzo, bool finalizo, String nombreEncuentro, int idDeporte)
        {
            //Intenta agregar un encuentro a la BD con los datos dados
            sbyte p = Convert.ToSByte(pausado);
            sbyte c = Convert.ToSByte(comenzo);
            sbyte f = Convert.ToSByte(finalizo);
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "INSERT INTO Encuentros (Fecha, Hora, Pausado, MinActual, SegActual, Comenzo, Finalizo, NombreEncuentro, IdDeporte) VALUES('" + fecha + "', '" + hora + "', '" + p + "', '" + minActual + "', '" + segActual + "', '" + c + "', '" + f + "', '" + nombreEncuentro + "', '" + idDeporte + "');";
                cn.Execute(stringSql, out object cantFilas, -1);
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool agregarEncInd(int idEncuentro)
        {
            //Intenta agregar un encuentro individual a la BD con los datos dados
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "INSERT INTO Enc_ind (IdEncuentro) VALUES('" + idEncuentro + "');";
                cn.Execute(stringSql, out object cantFilas, -1);
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool agregarEncCol(int idEncuentro, int cantCambios)
        {
            //Intenta agregar un encuentro colectivo a la BD con los datos dados
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "INSERT INTO Enc_col (IdEncuentro, CantCambios) VALUES('" + idEncuentro + "', '" + cantCambios +"');";
                cn.Execute(stringSql, out object cantFilas, -1);
                cn.Close();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool agregarEncuentroTorneo(int idEncuentro, int idTorneo, String etapa)
        {
            //Intenta agregar un encuentro de torneo a la BD con los datos dados
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "INSERT INTO Encuentros_Torneos (IdEncuentro, IdTorneo, Etapa) VALUES('" + idEncuentro + "', '" + idTorneo + "', '" + etapa + "');";
                cn.Execute(stringSql, out object cantFilas, -1);
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool agregarEncuentroJugador(int idEncuentro, int idJugador, int puesto, int puntuacion)
        {
            //Intenta agregar un encuentro de jugador a la BD con los datos dados
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "INSERT INTO Encuentros_Jugadores (IdEncuentro, IdJugador, Puesto, Puntuacion) VALUES('" + idEncuentro + "', '" + idJugador + "', '" + puesto + "', '" + puntuacion + "');";
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

        public bool eliminarEncuentroJugadorPorEncuentro(int idEncuentro)
        {
            //Intenta eliminar un encuentro de jugador de la BD, dada una id
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "DELETE FROM Encuentros_Jugadores WHERE IdEncuentro = '" + idEncuentro + "';";
                cn.Execute(stringSql, out object cantFilas, -1);
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool agregarEncuentroEquipo(int idEncuentro, int idEquipo, int ganador, int puntuacion)
        {
            //Intenta agregar un encuentro de jugador a la BD con los datos dados
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "INSERT INTO Encuentros_Equipos(IdEncuentro, IdEquipo, Ganador, Puntuacion) VALUES('" + idEncuentro + "', '" + idEquipo + "', '" + ganador + "', '" + puntuacion + "');";
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

        public bool eliminarEncuentroEquipoPorEncuentro(int idEncuentro)
        {
            //Intenta eliminar un encuentro de equipo de la BD, dada una id
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "DELETE FROM Encuentros_Equipos WHERE IdEncuentro = '" + idEncuentro + "';";
                cn.Execute(stringSql, out object cantFilas, -1);
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool eliminarEncuentro(int id)
        {
            //Intenta eliminar un encuentro de la BD, dada una id
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "DELETE FROM Encuentros WHERE IdEncuentro = '" + id + "';";
                cn.Execute(stringSql, out object cantFilas, -1);
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool eliminarEncInd(int id)
        {
            //Intenta eliminar un encuentro individual de la BD, dada una id
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "DELETE FROM Enc_ind WHERE IdEncuentro = '" + id + "';";
                cn.Execute(stringSql, out object cantFilas, -1);
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool eliminarEncCol(int id)
        {
            //Intenta eliminar un encuentro colectivo de la BD, dada una id
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "DELETE FROM Enc_col WHERE IdEncuentro = '" + id + "';";
                cn.Execute(stringSql, out object cantFilas, -1);
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool eliminarEncuentroTorneo(int id)
        {
            //Intenta eliminar un encuentro de torneo de la BD, dada una id
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "DELETE FROM Encuentros_Torneos WHERE IdEncuentro = '" + id + "';";
                cn.Execute(stringSql, out object cantFilas, -1);
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool eliminarAlineacionesDeEncuentro(int idEncuentro)
        {
            //Intenta eliminar las alineaciones de un encuentro en la BD
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "DELETE FROM Alineaciones WHERE IdEncuentro = '" + idEncuentro + "';";
                cn.Execute(stringSql, out object cantFilas, -1);
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool modificarEncuentro(int id, String fecha, String hora, bool pausado, int minActual, bool comenzo, bool finalizo, String nombreEncuentro, int idDeporte)
        {
            //Intenta modificar un encuentro existente en la BD con los datos dados
            sbyte p = Convert.ToSByte(pausado);
            sbyte c = Convert.ToSByte(comenzo);
            sbyte f = Convert.ToSByte(finalizo);
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "UPDATE Encuentros SET Fecha = '" + fecha + "', Hora = '" + hora + "', pausado = '" + p + "', MinActual = '" + minActual + "', Comenzo = '" + c + "', Finalizo = '" + f + "', NombreEncuentro = '" + nombreEncuentro + "', IdDeporte = '" + idDeporte + "' WHERE IdEncuentro = '" + id + "';";
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

        public int getLastID()
        {
            //Devuelve el ID generado tras el último insert.
            int id = 0;
            String stringSql = "SELECT LAST_INSERT_ID() FROM Encuentros;";
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                ADODB.Recordset rs = cn.Execute(stringSql, out object cantFilas, -1);
                id = (int)rs.Fields[0].Value;
                cn.Close();                
                return id;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
            return id;
        }
    }
}
