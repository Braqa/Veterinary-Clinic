using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlinikaVeterinare.BO;
using KlinikaVeterinare.BO.Interfaces;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.Remoting;

namespace KlinikaVeterinare.DAL
{
    public class VeterinarianDAL
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["FaunaJoneDB"].ConnectionString;
        public static Veterinarian AddVeterinarian(BO.Veterinarian veterinarian, BO.User user, BO.User loggeduser)
        {
            Veterinarian vet = null;


            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("sp_AddVeterinarian", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@rolid", user.RoleId);
            cmd.Parameters.AddWithValue("@insertby", loggeduser.Username);
            cmd.Parameters.AddWithValue("@name", veterinarian.Name);
            cmd.Parameters.AddWithValue("@surname", veterinarian.Surname);
            cmd.Parameters.AddWithValue("@clinicid", veterinarian.ClinicID);
            cmd.Parameters.AddWithValue("@rankid", veterinarian.RankID);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                vet = new Veterinarian();
                vet.VeterinarianID = dr["VeterinarianID"].ToString();
            }

            con.Close();

            return vet;
        }

        public static Veterinarian UpdateVeterinarian(BO.Veterinarian veterinarian, BO.User user, BO.User loggeduser)
        {
            Veterinarian vet = null;


            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("sp_UpdateVeterinarian", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@veterinarianid", veterinarian.VeterinarianID);
            //cmd.Parameters.AddWithValue("@rolid", user.RoleId);
            //cmd.Parameters.AddWithValue("@insertby", loggeduser.Username);
            cmd.Parameters.AddWithValue("@clinicid", veterinarian.ClinicID);
            cmd.Parameters.AddWithValue("@rankid", veterinarian.RankID);
            cmd.Parameters.AddWithValue("@lub", loggeduser.Username);



            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                vet = new Veterinarian();
                vet.VeterinarianID = dr["VeterinarianID"].ToString();

            }

            con.Close();


            return vet;



        }

        public static List<BO.Veterinarian> GetAllVeterinarians()
        {
            List<BO.Veterinarian> veterinarians = new List<Veterinarian>();

            BO.Veterinarian veterinarian = null;



            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("sp_GetAllVeterinarians", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                veterinarian = new Veterinarian();

                veterinarian.VeterinarianID = dr["VeterinarianID"].ToString();
                veterinarian.Name = dr["Name"].ToString();
                veterinarian.Surname = dr["Surname"].ToString();
                veterinarian.ClinicID = dr["ClinicID"].ToString();
                veterinarian.RankID = Convert.ToInt32(dr["RankID"].ToString());
                veterinarian.InsertBy = dr["InsertBy"].ToString();
                veterinarian.InsertDate = Convert.ToDateTime(dr["InsertDate"].ToString());
                veterinarian.LUB = dr["LUB"].ToString();
                //geveterinarian.LUD = Convert.ToDateTime(dr["LUD"].ToString());
                veterinarian.UserID = Convert.ToInt32(dr["UserID"].ToString());

                veterinarians.Add(veterinarian);
            }

            return veterinarians;
        }

        public static Veterinarian Get(int id)
        {
            try
            {
                Veterinarian veterinarian = null;

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("usp_GetVeterinarianByID", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@userid", id));

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    veterinarian = ToObject(reader);
                }
                con.Close();
                return veterinarian;
            }

            catch (Exception e)
            {
                string x = e.Message.ToString();
                return null;
            }

        }

        public static Veterinarian ToObject(SqlDataReader reader)
        {
            Veterinarian veterinarian = new Veterinarian();

            veterinarian.VeterinarianID = reader["VeterinarianID"].ToString();
            veterinarian.Name = reader["Name"].ToString();
            veterinarian.Surname = reader["Surname"].ToString();
            veterinarian.ClinicID = reader["ClinicID"].ToString();
            veterinarian.RankID = Convert.ToInt32(reader["RankID"].ToString());
            veterinarian.InsertBy = reader["InsertBy"].ToString();
            //veterinarian.InsertDate = Convert.ToDateTime(reader["InsertDate"]);
            veterinarian.LUB = reader["LUB"].ToString();
            //veterinarian.LUD = Convert.ToDateTime(reader["LUD"].ToString());
            veterinarian.LUN = Convert.ToInt32(reader["LUN"].ToString());
            veterinarian.UserID = Convert.ToInt32(reader["UserId"].ToString());

            return veterinarian;
        }



    }
}
