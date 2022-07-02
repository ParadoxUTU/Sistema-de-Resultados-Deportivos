using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaResultadosDeportivos.AccesoADatos
{
    public class Conexion
    {
        private static String origenDatos = "miodbc";
        public static byte tipoConexion;

        public static ADODB.Connection Crear()
        {
            ADODB.Connection cn = new ADODB.Connection();
            try
            {
                String usuario = "root";
                String contrasena = "";

                switch (tipoConexion)
                {
                    case 0:
                        usuario = "root";
                        contrasena = "";
                        break;
                    case 1:
                        usuario = "aficionado";
                        contrasena = "passAficionado";
                        break;
                    case 2:
                        usuario = "administrador";
                        contrasena = "passAdministrador";
                        break;
                }
                cn.Open(origenDatos, usuario, contrasena);
            }
            catch
            {
            }
            cn.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
            return cn;
        }
    }
}
