using KlinikaVeterinare.BO;
using KlinikaVeterinare.BO.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace KlinikaVeterinare.DAL
{
    public class OwnerDAL //: IBaseCrud<Owner>, IBaseConvertToObject<Owner>
    {
        // ADD ALL - INSERT
        // Connection string per DB
        public static string connectionString = ConfigurationManager.ConnectionStrings["FaunaJoneDB"].ConnectionString;
        public static bool Add(Owner model, User loggeduser)
        {
            try
            {
                string dbcon = ConfigurationManager.ConnectionStrings["FaunaJoneDB"].ConnectionString;
                SqlConnection con = new SqlConnection(dbcon);

                SqlCommand cmd = new SqlCommand("usp_Owner_Insert", con);
                cmd.CommandType = CommandType.StoredProcedure;

                string dob;

                DateTime dt = model.Birthday;

                dob = dt.Year + "-" + dt.Month + "-" + dt.Day;
                con.Open();
                cmd.Parameters.AddWithValue("@Name", model.Name);
                cmd.Parameters.AddWithValue("@Surname", model.Surname);
                cmd.Parameters.AddWithValue("@Birthday", dob);
                cmd.Parameters.AddWithValue("@PersonalNo", model.PersonalNo.ToString());
                cmd.Parameters.AddWithValue("@PhoneNo", model.PhoneNo);
                cmd.Parameters.AddWithValue("@email", model.Email);
                cmd.Parameters.AddWithValue("@sex", model.SexID);
                cmd.Parameters.AddWithValue("@insertby", loggeduser.Username);
                //command.Parameters.AddWithValue("name", model.Name);
                int rowAffected = cmd.ExecuteNonQuery();
                // mbyllja dhe shkatrrimi i lidhjes dhe komandes

                con.Close();
                if (rowAffected == 1)
                    return true;
                else
                    return false; ;

            }
            catch (Exception ex)
            {
                string x = ex.Message.ToString();
                return false;
            }
        }

        // GET ALL ME ID
        public static Owner Get(int id)
        {
            try
            {
                Owner owner = null;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("usp_Owner_GetById", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("id", id));
                    SqlDataReader reader = command.ExecuteReader();
                       
                    if (reader.Read())
                        {                           
                                owner = ToObject(reader);  
                        }
                    
                }
                return owner;
            }
            catch (Exception e)
            {
                string x = e.Message.ToString();
                return null;
            }
        }

        // GET ALL ME LISTE
        public Owner Get(Owner model)
        {
            throw new NotImplementedException();
        }

        public static List<Owner> GetAll()
        {
            try
            {
                List<Owner> owners = new List<Owner>();
                string dbcon = ConfigurationManager.ConnectionStrings["FaunaJoneDB"].ConnectionString;
                SqlConnection con = new SqlConnection(dbcon);

                Owner owner = null;
                using (SqlConnection connection = new SqlConnection(dbcon))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("dbo.usp_Owner_GetAll", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // nese ska informata kthehet e zbrazt

                            while (reader.Read())
                            {
                                // i lexon rresht per rresht ne DB dhe i kthen ne object C#

                                owner = new Owner();
                                owner.OwnerID = int.Parse(reader["personID"].ToString());
                                owner.Name = reader["name"].ToString();
                                owner.Surname = reader["surname"].ToString();
                                if (reader["birthday"] != DBNull.Value)
                                {
                                    owner.Birthday = (DateTime)reader["birthday"];
                                }
                                owner.PersonalNo = int.Parse(reader["PersonalNo"].ToString());
                                owner.SexID = int.Parse(reader["SexID"].ToString());
                                if (reader["phoneNo"] != DBNull.Value)
                                {
                                    owner.PhoneNo = reader["PhoneNo"].ToString();
                                }
                                if (reader["email"] != DBNull.Value)
                                {
                                    owner.Email = reader["email"].ToString();
                                }

                                // nese ka informata kthen objekt

                                owners.Add(owner);
                            }
                        }
                    }
                }
                return owners;
            }
            catch (Exception)
            {
                return null;
            }
        }

        // int (>0 mire, =0 asgje, -1 gabim), bool (true/false), void(throw)
        public static bool Modify(Owner model,User loggeduser)
        {
            using (var connection = DataConnection.GetConnection())
            {
                using (var command = DataConnection.Command(connection, "dbo.usp_Owner_Update"))
                {
                    command.Parameters.AddWithValue("@personID", model.OwnerID);
                    command.Parameters.AddWithValue("@name", model.Name);
                    command.Parameters.AddWithValue("@surname", model.Surname);
                    command.Parameters.AddWithValue("@birthday", model.Birthday);
                    command.Parameters.AddWithValue("@personalNo", model.PersonalNo);
                    command.Parameters.AddWithValue("@sex", model.SexID);
                    command.Parameters.AddWithValue("@phoneNo", model.PhoneNo);
                    command.Parameters.AddWithValue("@email", model.Email);
                    command.Parameters.AddWithValue("@LUB", loggeduser.Username);

                    int result = command.ExecuteNonQuery();
                    if (result == 1)
                    {
                        return true;
                    }
                    else return false;
                  

                }
            }
        }

        // REMOVE - menyra me e shkurte permes 
        public int Remove(int id)
        {
            using (var connection = DataConnection.GetConnection())
            {
                using (var command = DataConnection.Command(connection, "dbo.usp_Owner_RemoveByID"))
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
        public static Owner ToObject(SqlDataReader reader)
        {
            Owner owner = new Owner();

            owner.OwnerID = int.Parse(reader["personID"].ToString());
            owner.Name = reader["name"].ToString();
            owner.Surname = reader["surname"].ToString();
            if (reader["birthday"] != DBNull.Value)
            {
                owner.Birthday = (DateTime)reader["birthday"];
            }
            owner.PersonalNo = int.Parse(reader["personalNo"].ToString());
            owner.SexID = int.Parse(reader["SexID"].ToString());
            if (reader["phoneNo"] != DBNull.Value)
            {
                owner.PhoneNo = reader["phoneNo"].ToString();
            }
            if (reader["email"] != DBNull.Value)
            {
                owner.Email = reader["email"].ToString();
            }
            // Auditimi
            owner.InsertBy = reader["insertBy"].ToString();
            owner.InsertDate = (DateTime)reader["insertDate"];
            if (reader["LUB"] != DBNull.Value)
            {
                owner.LUB = reader["LUB"].ToString();
            }
            if (reader["LUD"] != DBNull.Value)
            {
                owner.LUD = (DateTime)reader["LUD"];
            }
            owner.LUN = int.Parse(reader["LUN"].ToString());

            return owner;
        }
    }
}
