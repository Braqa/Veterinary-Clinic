using KlinikaVeterinare.BO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlinikaVeterinare.BO;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace KlinikaVeterinare.DAL
{
    public class VaccineDAL /*: IBaseCrud<Vaccine>, IBaseConvertToObject<Vaccine>*/
    {
        // CREATE - INSERT
        // Connectio nstring me db
        public static string connectionString = ConfigurationManager.ConnectionStrings["FaunaJoneDB"].ConnectionString;
        public static bool Add(Vaccine vaccine, User loggeduser)
        {

            string dbcon = ConfigurationManager.ConnectionStrings["FaunaJoneDB"].ConnectionString;
            SqlConnection con = new SqlConnection(dbcon);

            SqlCommand cmd = new SqlCommand("usp_InsertVaccine", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            cmd.Parameters.AddWithValue("@serialno", vaccine.SerialNo);
            cmd.Parameters.AddWithValue("@vaccineid", vaccine.VaccineID);
            cmd.Parameters.AddWithValue("@insertby", loggeduser.Username);

            int result = cmd.ExecuteNonQuery();

            con.Close();
            if (result == 1)
                return true;
            else
                return false;
        }

        // READ by id
        public Vaccine Get(int id)
        {
            try
            {
                Vaccine vaccine = null;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("dbo.usp_Vaccine_GetAll", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                // thirrja e objektit 
                                vaccine = ToObject(reader);
                            }
                        }
                    }
                }
                return vaccine;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Vaccine Get(Vaccine model)
        {
            throw new NotImplementedException();
        }


        // READ as list
        public static List<Vaccine> GetAll()
        {
            try
            {
                List<Vaccine> result = null;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("usp_GetAllVaccines", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // nese ska informata kthehet e zbrazt
                            result = new List<Vaccine>();
                            while (reader.Read())
                            {

                                // thirrja e objektit
                                Vaccine vaccine = ToObject(reader);
                                result.Add(vaccine);
                            }
                        }
                    }
                }
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Modify - Update
        public int Modify(Vaccine vaccine)
        {
            using (var connection = DataConnection.GetConnection())
            {
                using (var command = DataConnection.Command(connection, "dbo.usp_Vaccine_Update"))
                {

                    command.Parameters.AddWithValue("@serialno", vaccine.SerialNo);
                    command.Parameters.AddWithValue("@vaccineid", vaccine.VaccineID);
                    command.Parameters.AddWithValue("@insertby", vaccine.InsertBy);
                    command.Parameters.AddWithValue("@insertDate", vaccine.InsertDate);
                    command.Parameters.AddWithValue("@LUB", vaccine.LUB);

                    int result = command.ExecuteNonQuery();
                    return result;
                }
            }
        }

        // DELETE
        public int Remove(int id)
        {
            using (var connection = DataConnection.GetConnection())
            {
                using (var command = DataConnection.Command(connection, "dbo.usp_Vaccine_Update"))
                {
                    command.Parameters.AddWithValue("id", id);
                    int result = command.ExecuteNonQuery();
                    return result;
                }
            }
        }

        public int Remove(Vaccine model)
        {
            throw new NotImplementedException();
        }


        // Gentriti - get vaccines
        public List<Vaccine> AllVaccines()
        {
            List<BO.Vaccine> veterinarians = new List<Vaccine>();

            BO.Vaccine vaccine = null;

            string dbcon = ConfigurationManager.ConnectionStrings["FaunaJoneDB"].ConnectionString;

            SqlConnection con = new SqlConnection(dbcon);
            SqlCommand cmd = new SqlCommand("usp_GetVacines", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                vaccine = new Vaccine();
                veterinarians.Add(vaccine);
            }

            return veterinarians;
        }



        // Shendrimi ne object i parametrave
        public static Vaccine ToObject(SqlDataReader reader)
        {
            Vaccine vaccine = new Vaccine();


            vaccine.VaccineID = int.Parse(reader["VaccineID"].ToString());
            vaccine.SerialNo = reader["serialno"].ToString();
           
           

            

            return vaccine;
        }
    }
}
