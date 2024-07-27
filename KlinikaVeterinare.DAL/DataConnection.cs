using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikaVeterinare.DAL
{
    public class DataConnection
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["FaunaJoneDB"].ConnectionString;


        public static string ConnectionString
        {
            get
            {
                return connectionString != "" ? connectionString : ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            }
            set
            {
                connectionString = ConfigurationManager.ConnectionStrings[value].ConnectionString;
            }
        }

        // Metoda per Connection
        public static SqlConnection GetConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
                return connection;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        // Metoda per Command                                                                           // Default Command StoreProcedure
        public static SqlCommand Command(SqlConnection connection, string cmdText, CommandType commandType = CommandType.StoredProcedure)
        {
            SqlCommand command = new SqlCommand(cmdText, connection);
            command.CommandType = commandType;
            return command;
        }

        // Metoda per shtimin e Parametrave
        public static void AddParameter(SqlCommand command, string parameterName, object value)
        {
            SqlParameter parameter = command.CreateParameter();
            parameter.ParameterName = parameterName;
            if (value != null)
            {
                if (value is DateTime)
                {
                    //mos me leju data me te vogel se sa 1900
                    if (DateTime.Parse(value.ToString()) <= DateTime.Parse("1/01/1900"))
                        value = null;
                }

                //if (value is Bitmap)
                //{
                //    //duhet me konvertu fotoon ne bytearray
                //}
            }

            parameter.Value = value ?? DBNull.Value;
            command.Parameters.Add(parameter);
        }

        public static void AddParameter(SqlCommand command, string parameterName, object value, ParameterDirection direction)
        {
            SqlParameter parameter = command.CreateParameter();
            parameter.ParameterName = parameterName;
            parameter.Direction = direction; // nese don me perdore per parametra output
            if (value != null)
            {
                if (value is DateTime)
                {
                    //mos me leju data me te vogel se sa 1900
                    if (DateTime.Parse(value.ToString()) <= DateTime.Parse("1/01/1900"))
                        value = null;
                }

                //if (value is Bitmap)
                //{
                //    //duhet me konvertu fotoon ne bytearray
                //}
            }

            parameter.Value = value ?? DBNull.Value;
            command.Parameters.Add(parameter);
        }
    }
}
