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
    public class FamilyDAL
    {
        public static List<Family> GetAllFamilies()
        {
            List<Family> families = new List<Family>();

            Family family = null;
            string dbcon = ConfigurationManager.ConnectionStrings["FaunaJoneDB"].ConnectionString;
            SqlConnection con = new SqlConnection(dbcon);

            SqlCommand cmd = new SqlCommand("usp_GetAllFamilies", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                family = new Family();

                family.FamilyID = Convert.ToInt32(dr["FamilyID"]);
                family.Family_AL = dr["Family_AL"].ToString();
                family.Family_EN = dr["Family_EN"].ToString();

                families.Add(family);
            }

            con.Close();

            return families;

        }
    }
}
