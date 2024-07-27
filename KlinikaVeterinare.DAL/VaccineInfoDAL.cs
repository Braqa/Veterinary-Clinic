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
    public class VaccineInfoDAL
    {

        // ADD ALL - INSERT
        // Connection string per DB
        public string connectionString = ConfigurationManager.ConnectionStrings["FaunaJoneDB"].ConnectionString;
        public int Add(VaccineInfo vaccineInfo)
        {
            try
            {
                // krijimi i lidhjes
                SqlConnection connection = new SqlConnection(connectionString);
                // hapja e lidhjes
                connection.Open();
                // komanda per procedure
                SqlCommand command = new SqlCommand("dbo.usp_VaccineInfo_Insert", connection);
                // lloji se cfar komande eshte
                command.CommandType = CommandType.StoredProcedure;
                // pasimi i vlerave nga db ne objekt dhe anasjelltas
                command.Parameters.AddWithValue("SerialNo", vaccineInfo.SerialNo);
                command.Parameters.AddWithValue("VaccineName_EN", vaccineInfo.Name_EN);
                command.Parameters.AddWithValue("VaccineDescription_EN", vaccineInfo.Description_EN);

                int rowAffected = command.ExecuteNonQuery();
                // mbyllja dhe shkatrrimi i lidhjes dhe komandes
                command.Dispose();
                connection.Close();
                connection.Dispose();

                return rowAffected;
            }
            catch (Exception)
            {
                return -1;
            }
        }


        // Gentriti
        public static List<VaccineInfo> GetAllVaccines()
        {
            List<VaccineInfo> vaccines = new List<VaccineInfo>();
            VaccineInfo vaccine = null;

            string dbcon = ConfigurationManager.ConnectionStrings["FaunaJoneDB"].ConnectionString;
            SqlConnection con = new SqlConnection(dbcon);

            SqlCommand cmd = new SqlCommand("usp_GetAllVaccinesInfo", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                vaccine = new VaccineInfo();

                vaccine.VaccineID = Convert.ToInt32(dr["VaccineID"].ToString());
                vaccine.Name_EN = dr["VaccineName_EN"].ToString();
                vaccine.Description_EN = dr["VaccineDescription_EN"].ToString();

                vaccines.Add(vaccine);
            }

            return vaccines;
        }

        // int (>0 mire, =0 asgje, -1 gabim), bool (true/false), void(throw)
        public int Modify(VaccineInfo vaccineInfo)
        {
            using (var connection = DataConnection.GetConnection())
            {
                using (var command = DataConnection.Command(connection, "dbo.usp_VaccineInfo_Update"))
                {
                    command.Parameters.AddWithValue("vaccineInfoID", vaccineInfo.VaccineID);
                    command.Parameters.AddWithValue("SerialNo", vaccineInfo.SerialNo);
                    command.Parameters.AddWithValue("VaccineName_EN", vaccineInfo.Name_EN);
                    command.Parameters.AddWithValue("VaccineDescription_EN", vaccineInfo.Description_EN);
                    command.Parameters.AddWithValue("@insertBy", vaccineInfo.InsertBy);
                    command.Parameters.AddWithValue("@LUB", vaccineInfo.LUB);

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
                using (var command = DataConnection.Command(connection, "dbo.usp_VaccineInfo_RemoveByID"))
                {
                    command.Parameters.AddWithValue("id", id);
                    int result = command.ExecuteNonQuery();
                    return result;
                }
            }
        }

        // Shendrimi ne object i parametrave
        public VaccineInfo ToObject(SqlDataReader reader)
        {
            VaccineInfo vaccineInfo = new VaccineInfo();

            vaccineInfo.VaccineID = int.Parse(reader["vaccineInfoID"].ToString());
            if (reader["SerialNo"] != DBNull.Value)
            {
                vaccineInfo.SerialNo = reader["SerialNo"].ToString();
            }

            if (reader["VaccineName_EN"] != DBNull.Value)
            {
                vaccineInfo.Name_EN = reader["VaccineName_EN"].ToString();
            }
            if (reader["VaccineDescription_EN"] != DBNull.Value)
            {
                vaccineInfo.Description_EN = reader["VaccineDescription_EN"].ToString();
            }

            // Auditimi
            vaccineInfo.InsertBy = reader["insertBy"].ToString();
            vaccineInfo.InsertDate = (DateTime)reader["insertDate"];
            if (reader["LUB"] != DBNull.Value)
            {
                vaccineInfo.LUB = reader["LUB"].ToString();
            }
            if (reader["LUD"] != DBNull.Value)
            {
                vaccineInfo.LUD = (DateTime)reader["LUD"];
            }
            vaccineInfo.LUN = int.Parse(reader["LUN"].ToString());

            return vaccineInfo;
        }

    }
}
