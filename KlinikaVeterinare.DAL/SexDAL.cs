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
    public class SexDAL
    {
        public static List<Sex> GetSexes()
        {
            try
            {
                List<Sex> sexes = new List<Sex>();

                Sex sex = null;

                string dbcon = ConfigurationManager.ConnectionStrings["FaunaJoneDB"].ConnectionString;
                SqlConnection con = new SqlConnection(dbcon);

                SqlCommand cmd = new SqlCommand("usp_GetSexes", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    sex = new Sex();
                    sex.SexID = Convert.ToInt32(dr["SexID"].ToString());
                    sex.Sex_Al = dr["Sex_AL"].ToString();
                    sex.Sex_En = dr["Sex_EN"].ToString();

                    sexes.Add(sex);
                }

                con.Close();

                return sexes;
            }

            catch
            {
                return null;
            }

           
        }
    }
}
