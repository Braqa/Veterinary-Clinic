using KlinikaVeterinare.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace KlinikaVeterinare.DAL
{
    public class VisitDAL
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["FaunaJoneDB"].ConnectionString;
        public static bool AddVisit(Visit visit, User loggeduser)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("usp_AddVisit", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@visitdate", visit.VisitDate);
                cmd.Parameters.AddWithValue("@animalid", visit.AnimalID);
                cmd.Parameters.AddWithValue("@veterinarianid", visit.VeterinarianID);
                cmd.Parameters.AddWithValue("@clinicid", visit.ClinicID);
                cmd.Parameters.AddWithValue("@diagnosis", visit.Diagnosis);
                cmd.Parameters.AddWithValue("@insertby", loggeduser.Username);

                con.Open();

                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }



        }
        public static List<Visit> GetAll()
        {
            List<Visit> visits = new List<Visit>();

            Visit visit = null;

            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("usp_GetAllVisits", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                visit = new Visit();

                visit.VisitID = Convert.ToInt32(dr["VisitID"]);
                visit.VisitDate = Convert.ToDateTime(dr["VisitDate"]);
                visit.AnimalID = dr["AnimalID"].ToString();
                visit.ClinicID = dr["ClinicID"].ToString();
                visit.Diagnosis = dr["Diagnosis"].ToString();

                visits.Add(visit);

            }

            return visits;
        }

        public static Visit GetVisitById(int id)
        {
            Visit visit = null;

            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("usp_GetVisitById", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@visitid", id);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                visit = new Visit();

                visit.VisitID = Convert.ToInt32(dr["VisitID"]);
                visit.VisitDate = Convert.ToDateTime(dr["VisitDate"]);
                visit.AnimalID = dr["AnimalID"].ToString();
                visit.ClinicID = dr["ClinicID"].ToString();
                visit.Diagnosis = dr["Diagnosis"].ToString();
            }
            return visit;
        }

        public static bool UpdateVisit(Visit visit,User loggeduser)
        {

            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("usp_UpdateVisit", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@visitid", visit.VisitID);
            cmd.Parameters.AddWithValue("@animalid", visit.AnimalID);
            cmd.Parameters.AddWithValue("@veterinarianid", visit.VeterinarianID);
            cmd.Parameters.AddWithValue("@diagnosis", visit.Diagnosis);
            cmd.Parameters.AddWithValue("@lub", loggeduser.Username);

            con.Open();

            int result = cmd.ExecuteNonQuery();

            if(result==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
