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
    internal class DatosUsuario
    {
        public bool agregarUsuario(String email, String username, String pass, short rol)
        {
            try
            {
                ADODB.Connection cn = Conexion.Crear();

                String sql1 = "INSERT INTO Usuarios VALUES('" + email + "', '" + pass + "', '" + username + "', '" + rol + "');";
                Console.WriteLine(sql1);
                String sql2 = "CREATE USER '" + email + "'@'localhost' IDENTIFIED BY '" + pass + "';";
                cn.Execute(sql1, out object cantFilas, -1);
                cn.Execute(sql2, out cantFilas, -1);
                if (rol == 1)
                {
                    String sql3 = "GRANT ALL ON Usuarios TO '" + email + "'@'localhost';";
                    cn.Execute(sql3, out object cantFilas3, -1);
                }
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public bool eliminarUsuario(String email)
        {
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String sql = "DELETE FROM Usuarios WHERE dirCorreo = '" + email + "';";
                String sql2 = "DROP USER '" + email + "'@'localhost';";
                cn.Execute(sql, out object cantFilas, -1);
                cn.Execute(sql2, out object cantFilas2, -1);
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public ADODB.Recordset getAllUsuarios()
        {
            try
            {
                ADODB.Connection cn = Conexion.Crear();
                String sql = "SELECT * FROM USUARIOS;";
                ADODB.Recordset rs = cn.Execute(sql, out object cantFilas, -1);
                cn.Close();
                return rs;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /*public bool probarConexion(String email, String contrasena)
        {
            try
            {
                ADODB.Connection cn = new ADODB.Connection();
                cn.Open("miodbc", email, contrasena);
            }
        }*/

        /*public Usuario getUsuarioByID(string email)
        {
            ADODB.Connection cn = new ADODB.Connection();
            String sql = "SELECT * FROM USUARIOS WHERE dirCorreo = '" + email + "';";
            ADODB.Recordset rs = cn.Execute(sql, out object cantFilas, -1);
            return (short)rs.Fields[3].Value;
        }*/
    }
}
