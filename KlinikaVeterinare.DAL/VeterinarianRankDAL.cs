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
    public class VeterinarianRankDAL
    {

        public static List<BO.VeterinarianRank> GetVetRanks()
        {
            List<BO.VeterinarianRank> vetrankList = new List<BO.VeterinarianRank>();

            BO.VeterinarianRank vetrank = null;

            string dbcon = ConfigurationManager.ConnectionStrings["FaunaJoneDB"].ConnectionString;

            SqlConnection con = new SqlConnection(dbcon);
            SqlCommand cmd = new SqlCommand("sp_getVeterianrianRanks", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                vetrank = new BO.VeterinarianRank();

                vetrank.VeterinarianRankID = Convert.ToInt32(dr["RankID"].ToString());
                vetrank.Rank_Al = dr["Rank_AL"].ToString();

                vetrankList.Add(vetrank);
            }

            return vetrankList;
        }
    }
}
