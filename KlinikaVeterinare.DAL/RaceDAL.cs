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
    public class RaceDAL
    {
        public static List<Race> GetAllRaces()
        {
            List<Race> races = new List<Race>();

            Race race = null;

            string dbcon = ConfigurationManager.ConnectionStrings["FaunaJoneDB"].ConnectionString;
            SqlConnection con = new SqlConnection(dbcon);

            SqlCommand cmd = new SqlCommand("usp_GetAllRaces", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                race = new Race();

                race.FamilyID = Convert.ToInt32(dr["FamilyID"].ToString());
                race.RaceID = Convert.ToInt32(dr["RaceID"].ToString());
                race.Race_AL = dr["Race_AL"].ToString();
                race.Race_EN = dr["Race_EN"].ToString();

                races.Add(race);

            }

            return races;
        }
    }
}
