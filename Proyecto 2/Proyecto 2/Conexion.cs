using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto_2
{
    internal class Conexion
    {
        private string cadenaConexion = "server=127.0.0.1;database=pos; uid=root; pwd=Holasoyjose123@;";

        public MySqlConnection ObtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            return conexion;
        }
    }
}
