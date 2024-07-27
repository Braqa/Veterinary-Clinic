using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using KlinikaVeterinare.BO;
using KlinikaVeterinare.BO.Interfaces;

namespace KlinikaVeterinare.DAL
{
    public class ClinicDAL /*: IBaseCrud<Clinic>, IBaseConvertToObject<Clinic>*/
    {
        // CREATE - INSERT
        // Connection string me db
        public string connectionString = ConfigurationManager.ConnectionStrings["FaunaJoneDB"].ConnectionString;
        public static bool Add(Clinic clinic, User loggeduser)
        {
            string dbcon = ConfigurationManager.ConnectionStrings["FaunaJoneDB"].ConnectionString;
            SqlConnection con = new SqlConnection(dbcon);

            SqlCommand cmd = new SqlCommand("usp_Clinic_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@name", clinic.Name);
            cmd.Parameters.AddWithValue("@phoneNumber", clinic.PhoneNumber);
            cmd.Parameters.AddWithValue("@address", clinic.Address);
            cmd.Parameters.AddWithValue("@insertBy", loggeduser.Username);
            cmd.Parameters.AddWithValue("@LUB", loggeduser.LUB);
            //cmd.Parameters.AddWithValue("@LUD", )

            con.Open();

            int result = cmd.ExecuteNonQuery();

            if (result == 1)
                return true;
            else return false;
        }

        // READ/GETALL by id
        public Clinic Get(int id)
        {
            try
            {
                Clinic clinic = null;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("usp_Clinic_GetAll", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                clinic = ToObject(reader);
                            }
                        }
                    }
                }
                return clinic;
            }
            catch (Exception)
            {
                return null;
            }
        }

        // GET ALL ME LISTE
        public Clinic Get(Clinic model)
        {
            throw new NotImplementedException();
        }


        // Gentrit qito e ki bo ti mos e ki lon ngjys ?
        public static List<BO.Clinic> GetClinics ()
        {
            List<BO.Clinic> clinicsList = new List<BO.Clinic>();

            BO.Clinic clinic = null;

            string dbcon = ConfigurationManager.ConnectionStrings["FaunaJoneDB"].ConnectionString;

            SqlConnection con = new SqlConnection(dbcon);
            SqlCommand cmd = new SqlCommand("sp_getClinics", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                clinic = new BO.Clinic();

                clinic.ClinicID = dr["ClinicID"].ToString();
                clinic.Name = dr["Name"].ToString();
                clinic.Address = dr["Address"].ToString();
                clinic.PhoneNumber = dr["PhoneNo"].ToString();

                clinicsList.Add(clinic);
            }

            return clinicsList;
        }

        // Modify
        public int Modify(Clinic clinic)
        {
            using (var connection = DataConnection.GetConnection())
            {
                using (var command = DataConnection.Command(connection, "dbo.usp_Animal_Update"))
                {
                    command.Parameters.AddWithValue("@clinicID", clinic.ClinicID);
                    command.Parameters.AddWithValue("@name", clinic.Name);
                    command.Parameters.AddWithValue("@phoneNumber", clinic.PhoneNumber);
                    command.Parameters.AddWithValue("@address", clinic.Address);
                    command.Parameters.AddWithValue("@insertBy", clinic.InsertBy);
                    command.Parameters.AddWithValue("@insertDate", clinic.InsertDate);
                    command.Parameters.AddWithValue("@LUB", clinic.LUB);

                    int result = command.ExecuteNonQuery();
                    return result;
                }
            }
        }

        // REMOVE - menyra me e shkurte permes 
        public int Remove(int id)
        {
            using (var connection = DataConnection.GetConnection())
            {
                using (var command = DataConnection.Command(connection, "dbo.usp_Clinic_RemoveByID"))
                {
                    command.Parameters.AddWithValue("id", id);
                    int result = command.ExecuteNonQuery();
                    return result;
                }
            }
        }

        
        public int Remove(Owner model)
        {
            throw new NotImplementedException();
        }

        // Shendrimi ne object i parametrave
        public Clinic ToObject(SqlDataReader reader)
        {
            Clinic clinic = new Clinic();

            clinic.ClinicID = reader["clinicID"].ToString();
            if (reader["name"] != DBNull.Value)
            {
                clinic.Name = reader["name"].ToString();
            }
            if (reader["phoneNumber"] != DBNull.Value)
            {
                clinic.PhoneNumber = reader["phoneNumber"].ToString();
            }
            if (reader["address"] != DBNull.Value)
            {
                clinic.Address = reader["address"].ToString();
            }

            // Auditimi
            clinic.InsertBy = reader["insertBy"].ToString();
            clinic.InsertDate = (DateTime)reader["insertDate"];
            if (reader["LUB"] != DBNull.Value)
            {
                clinic.LUB = reader["LUB"].ToString();
            }
            if (reader["LUD"] != DBNull.Value)
            {
                clinic.LUD = (DateTime)reader["LUD"];
            }
            clinic.LUN = int.Parse(reader["LUN"].ToString());

            return clinic;
        }
    }

  
}
