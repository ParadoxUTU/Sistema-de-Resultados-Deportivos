using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaResultadosDeportivos.Modelos;
using ADODB;
using System.Security.Cryptography;

namespace SistemaResultadosDeportivos.AccesoADatos
{
    internal class DatosUsuario
    {
        public Usuario getPorId(String correo)
        {
            //Devuelve un usuario mapeado al modelo, dado su correo
            try
            {
                Usuario usuario = null;
                ADODB.Connection cn = Conexion.Crear();
                String sql = "SELECT * FROM Usuarios WHERE dirCorreo = '" + correo + "';";
                if (cn != null)
                {
                    ADODB.Recordset rs = cn.Execute(sql, out object cantFilas, -1);
                    if (rs.RecordCount > 0)
                    {
                        String c = rs.Fields[0].Value.ToString();
                        String n = rs.Fields[1].Value.ToString();
                        int r;
                        int.TryParse(rs.Fields[2].Value.ToString(), out r);
                        String co = rs.Fields[3].Value.ToString();
                        usuario = new Usuario(c, n, r, co);
                    }
                    else
                    {
                        usuario = null;
                    }
                    rs.Close();
                    cn.Close();
                }
                return usuario;
            }
            catch
            {
                return null;
            }
        }

        public bool agregarMiembro(String correo)
        {
            //Intenta agregar un miembro a la BD 
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "INSERT INTO Miembros VALUES('" + correo + "');";
                cn.Execute(stringSql, out object cantFilas, -1);
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool eliminarMiembro(String correo)
        {
            //Intenta agregar un miembro a la BD 
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "DELETE FROM Miembros WHERE DirCorreo = '" + correo + "';";
                cn.Execute(stringSql, out object cantFilas, -1);
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool esMiembro(String correo)
        {
            //Devuelve un usuario mapeado al modelo, dado su correo
            try
            {
                bool esMiembro;
                ADODB.Connection cn = Conexion.Crear();
                String sql = "SELECT * FROM Miembros WHERE dirCorreo = '" + correo + "';";
                ADODB.Recordset rs = cn.Execute(sql, out object cantFilas, -1);
                if (rs.RecordCount > 0)
                {
                    String c = rs.Fields[0].Value.ToString();
                    esMiembro = true;
                }
                else
                {
                    esMiembro = false;
                }
                rs.Close();
                cn.Close();
                return esMiembro;
            }
            catch
            {
                return false;
            }
        }

        public List<Usuario> getUsuarios()
        {
            //Mapea los usuarios existentes a los modelos, y los devuelve en una lista
            string correo;
            string nombre;
            int rol;
            string contrasena;
            List<Usuario> lista = new List<Usuario>();
            String stringSql = "SELECT * FROM Usuarios;";
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                ADODB.Recordset rs = cn.Execute(stringSql, out object cantFilas, -1);
                if (rs.RecordCount > 0)
                {
                    for (int i = 0; i < (int)cantFilas; i++)
                    {
                        correo = (string)rs.Fields[0].Value;
                        if (correo != Conexion.usuario)
                        {
                            nombre = (string)rs.Fields[1].Value;
                            rol = (int)rs.Fields[2].Value;
                            contrasena = (string)rs.Fields[3].Value;
                            Usuario usuario = new Usuario(correo, nombre, rol, contrasena);
                            lista.Add(usuario);
                        }
                        rs.MoveNext();
                    }
                    cn.Close();
                }
                else
                {
                    cn.Close();
                    return null;
                }
            }
            catch { }
            return lista;
        }

        public void darPermisos(string correo, int rol)
        {
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                if (rol == 0)
                {
                    String stringSql = "GRANT SELECT ON " + getBaseDeDatosSeleccionada() + ".* TO '" + correo + "'@'localhost';";
                    cn.Execute(stringSql, out object cantFilas, -1);
                    /*String stringSql = "GRANT SELECT ON Usuarios TO '" + correo + "'@'localhost';";
                    cn.Execute(stringSql, out object cantFilas, -1);
                    stringSql = "GRANT SELECT ON Publicidad TO '" + correo + "'@'localhost';";
                    cn.Execute(stringSql, out cantFilas, -1);
                    stringSql = "GRANT SELECT ON Encuentros TO '" + correo + "'@'localhost';";
                    cn.Execute(stringSql, out cantFilas, -1);
                    stringSql = "GRANT SELECT ON Equipos TO '" + correo + "'@'localhost';";
                    cn.Execute(stringSql, out cantFilas, -1);
                    stringSql = "GRANT SELECT ON Alineaciones TO '" + correo + "'@'localhost';";
                    cn.Execute(stringSql, out cantFilas, -1);
                    stringSql = "GRANT SELECT ON Anotaciones TO '" + correo + "'@'localhost';";
                    cn.Execute(stringSql, out cantFilas, -1);
                    stringSql = "GRANT SELECT ON Sets TO '" + correo + "'@'localhost';";
                    cn.Execute(stringSql, out cantFilas, -1);
                    stringSql = "GRANT SELECT ON Enc_eq_sets TO '" + correo + "'@'localhost';";
                    cn.Execute(stringSql, out cantFilas, -1);
                    stringSql = "GRANT SELECT ON Enc_jug_sets TO '" + correo + "'@'localhost';";
                    cn.Execute(stringSql, out cantFilas, -1);
                    stringSql = "GRANT SELECT ON Encuentros_equipos TO '" + correo + "'@'localhost';";
                    cn.Execute(stringSql, out cantFilas, -1);
                    stringSql = "GRANT SELECT ON Deportes TO '" + correo + "'@'localhost';";
                    cn.Execute(stringSql, out cantFilas, -1);*/
                }
                if (rol == 1)
                {
                    String stringSql = "GRANT CREATE USER ON *.* TO '" + correo + "'@'localhost' WITH GRANT OPTION;";
                    cn.Execute(stringSql, out object cantFilas, -1);
                    stringSql = "GRANT ALL PRIVILEGES ON " + getBaseDeDatosSeleccionada() + ".* TO '" + correo + "'@'localhost';";
                    cn.Execute(stringSql, out cantFilas, -1);
                }
                cn.Close();
            }
            catch(Exception ex) 
            {
            }
        }

        public bool agregarUsuario(String correo, String nombre, String contrasena, int rol)
        {
            //Intenta agregar una usuario a la BD con los datos dados
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "INSERT INTO Usuarios VALUES('" + correo + "', '" + nombre + "', '" + rol + "', '" + encriptar(contrasena) + "');";
                cn.Execute(stringSql, out object cantFilas, -1);
                //darPermisos(correo, rol);
                cn.Close();
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        public string getBaseDeDatosSeleccionada()
        {
            string nombreBaseDeDatos = null;
            String stringSql = "SELECT DATABASE() FROM DUAL;";
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                ADODB.Recordset rs = cn.Execute(stringSql, out object cantFilas, -1);
                nombreBaseDeDatos = (string)rs.Fields[0].Value;
                cn.Close();
            }
            catch { }
            return nombreBaseDeDatos;
        }

        public bool eliminarUsuario(String correo)
        {
            //Intenta eliminar un usuario de la BD, dado su correo
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "DELETE FROM Usuarios WHERE dirCorreo = '" + correo + "';";
                cn.Execute(stringSql, out object cantFilas, -1);
                stringSql = "DROP USER '" + correo + "'@'localhost';";
                cn.Execute(stringSql, out cantFilas, -1);
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool modificarUsuario(String correo, String nombre, int rol)
        {
            //Intenta modificar un usuario existente en la BD con los datos dados
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "UPDATE Usuarios SET NombreUsuario = '" + nombre + "', rol = '" + rol + "' WHERE dirCorreo = '" + correo + "';";
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

        public bool modificarContrasena(String correo, String contrasena)
        {
            //Intenta modificar la contrasena de un usuario existente en la BD con los datos dados
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "UPDATE Usuarios SET Contrasena = '" + encriptar(contrasena) + "' WHERE dirCorreo = '" + correo + "';";
                cn.Execute(stringSql, out object cantFilas, -1);
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public bool testConexion(String correo, String contrasena)
        {
            //Devuelve true si se logra establecer la conexion a la BD con los datos dados, false si no
            bool resultado;
            ADODB.Connection cn = Conexion.Crear(correo, contrasena);
            if (cn != null)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            return resultado;
        }

        public bool autenticar(String correo, String contrasena)
        {
            bool exito;
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String stringSql = "SELECT * FROM Usuarios WHERE DirCorreo = '" + correo + "' AND contrasena = '" + encriptar(contrasena) + "';";
                cn.Execute(stringSql, out object cantFilas, -1);
                if((int)cantFilas > 0)
                {
                    exito = true;
                }
                else
                {
                    exito = false;
                }
                cn.Close();
                return exito;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        public string encriptar(string contrasena)
        {
            string hash = "paradox mejor empresa";
            byte[] data = UTF8Encoding.UTF8.GetBytes(contrasena);
            MD5 md5 = MD5.Create(); 
            TripleDES tripledes = TripleDES.Create();
            tripledes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripledes.Mode = CipherMode.ECB;
            ICryptoTransform transform = tripledes.CreateEncryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
            return Convert.ToBase64String(result);
        }

        public void actualizarConexion(String usuario, String contrasena)
        {
            //Cambia las credenciales de conexion por defecto a las dadas
            Conexion.usuario = usuario;
            Conexion.contrasena = contrasena;
        }

        public void volverAutenticador()
        {
            //Cambia las credenciales de conexion por defecto a las del usuario autenticador
            Conexion.volverAutenticador();
        }
    }
}