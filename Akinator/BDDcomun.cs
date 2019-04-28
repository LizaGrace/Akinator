using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akinator
{
    class BDDcomun
    {
        public static MySqlConnection ObtenerConexion()
        {
            //const string connMySql = "Data Source = (local); Initial Catalog = ai; Integrated Security = SSPI";
            const string connMySql = "datasource='localhost';port='3306';username='root';password='1060310';SslMode = none";
            
            MySqlConnection conectar = new MySqlConnection(connMySql);
            try
            {
                conectar.Open();
            }
            catch (MySqlException ex)
            {
                int errorcode = ex.Number;
                MessageBox.Show(ex.Message + "No. de error: " + errorcode);
            }
            return conectar;

        }
        public static MySqlDataReader reader(string _string, MySqlConnection conexion)
        {
            MySqlCommand _comando = new MySqlCommand(_string, conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            return _reader;
        }
        public static string GetMySqlString(string _string)
        {
            MySqlConnection conexion = ObtenerConexion();
            MySqlDataReader _reader = reader(_string, conexion);
            string _return = "0";
            try
            {
                while (_reader.Read())
                {
                    _return = _reader.IsDBNull(0) ? _string = "0" : _reader.GetString(0);
                }
                conexion.Close();
            }
            catch (MySqlException ex)
            {
                int errorcode = ex.Number;
                MessageBox.Show(ex.Message + "No. de error: " + errorcode);
            }
            return _return;
        }
        public static int GetMySqlInt(string _string)
        {
            return Convert.ToInt32(GetMySqlString(_string));
        }
        public static int SendCommandMySql(string _string)
        {
            int retorno = 0;
            MySqlConnection conexion = BDDcomun.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(_string, conexion);
            try
            {
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (MySqlException ex)
            {
                int errorcode = ex.Number;
                MessageBox.Show(ex.Message + "No. de error: " + errorcode);
            }
            return retorno;
        }
        public static DataTable GetMySqlTable(string _string)
        {
            MySqlConnection conexion = ObtenerConexion();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(_string, conexion);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);

            DataTable reporte = new DataTable();
            try
            {
                reporte.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(reporte);
                conexion.Close();
            }
            catch (MySqlException ex)
            {
                int errorcode = ex.Number;
                MessageBox.Show(ex.Message + "No. de error: " + errorcode);
            }
            return reporte;
        }
    }
}