using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlinikaVeterinare.BO;
using KlinikaVeterinare.BO.Interfaces;

namespace KlinikaVeterinare.DAL
{
    public class UserDAL //: IBaseCrud<User>, IBaseConvertToObject<User>
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["FaunaJoneDB"].ConnectionString;
        public static User Login(string username, string password)
        {
            User user = null;

            string dbstring = ConfigurationManager.ConnectionStrings["FaunaJoneDB"].ConnectionString;

            try
            {
                SqlConnection con = new SqlConnection(dbstring);

                SqlCommand cmd = new SqlCommand("sp_LogInCheck", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        user = new User();
                        user.UserID = Convert.ToInt32(dr["UserId"].ToString());
                        user.Username = dr["Username"].ToString();
                        user.RoleId = Convert.ToInt32(dr["RoleId"].ToString());
                        user.InsertBy = dr["InsertBy"].ToString();
                        //user.InsertDate = Convert.ToDateTime(dr["InsertDate"].ToString());
                        user.LUB = dr["LUB"].ToString();
                        //user.LUD = Convert.ToDateTime(dr["LUD"].ToString());
                    }
                    return user;
                }
                else
                    return null;


            }
            catch (Exception)
            {
                throw;
            }
        }
        public static bool DeactivateUser(BO.User user, BO.User loggeduser)
        {
            string dbcon = ConfigurationManager.ConnectionStrings["FaunaJoneDB"].ConnectionString;
            SqlConnection con = new SqlConnection(dbcon);

            SqlCommand cmd = new SqlCommand("sp_DeactivateUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", user.UserID);
            cmd.Parameters.AddWithValue(@"updateby", loggeduser.Username);

            int result = Convert.ToInt32(cmd.ExecuteScalar());

            if (result == 1)
                return true;
            else return false;
        }
        public static bool ActivateUser(BO.User user, BO.User loggeduser)
        {
            string dbcon = ConfigurationManager.ConnectionStrings["FaunaJoneDB"].ConnectionString;
            SqlConnection con = new SqlConnection(dbcon);

            SqlCommand cmd = new SqlCommand("sp_ActivateUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", user.UserID);
            cmd.Parameters.AddWithValue(@"updateby", loggeduser.Username);

            int result = Convert.ToInt32(cmd.ExecuteScalar());

            if (result == 1)
                return true;
            else return false;
        }

        public static bool Add(User user, User loggeduser)
        {
            string dbcon = ConfigurationManager.ConnectionStrings["FaunaJoneDB"].ConnectionString;
            SqlConnection con = new SqlConnection(dbcon);

            SqlCommand cmd = new SqlCommand("usp_InsertUser", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@rolid", 1);
            cmd.Parameters.AddWithValue("@insertby", loggeduser.Username);
            //Duhet te shtohet edhe emer e mbiemer per vetem si user
            cmd.Parameters.AddWithValue("@name", "");
            cmd.Parameters.AddWithValue("@surname", "");
            int result = cmd.ExecuteNonQuery();

            con.Close();
            if (result == 1)
                return true;
            else
                return false;
        }

        //public User Get(int id)
        //{
        //    throw new NotImplementedException();
        //}

        public static User Get(int id)
        {
            try
            {
                User user = null;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand cmd = new SqlCommand("usp_GetUserById", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@userid", id));
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    user = ToObject(reader);
                }

                return user;

            }
            catch (Exception e)
            {
                string x = e.Message.ToString();
                return null;
            }
        }

        public static List<User> GetAll()
        {
            List<User> users = new List<User>();

            User user = null;

            string dbcon = ConfigurationManager.ConnectionStrings["FaunaJoneDB"].ConnectionString;
            SqlConnection con = new SqlConnection(dbcon);

            SqlCommand cmd = new SqlCommand("usp_GetAllUsers", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                user = new User();

                user.UserID = Convert.ToInt32(dr["UserID"].ToString());
                user.Username = dr["Username"].ToString();
                user.RoleId = Convert.ToInt32(dr["RoleId"].ToString());
                user.IsActive = Convert.ToBoolean(dr["IsActive"].ToString());

                users.Add(user);
            }
            con.Close();
            return users;
        }

        public static bool Update(User user, User loggeduser, bool changePassword)
        {
            try
            {
                string dbcon = ConfigurationManager.ConnectionStrings["FaunaJoneDB"].ConnectionString;
                SqlConnection con = new SqlConnection(dbcon);

                if (changePassword)
                {
                    SqlCommand cmd = new SqlCommand("usp_UpdateUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();

                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@password", user.Password);
                    cmd.Parameters.AddWithValue("@LUB", loggeduser.Username);
                    cmd.Parameters.AddWithValue("@roleid", user.RoleId);
                    cmd.Parameters.AddWithValue("@status", user.IsActive);

                    int result = cmd.ExecuteNonQuery();

                    if (result == 1)
                        return true;
                    else return false;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("usp_UpdateUserWithouthPass", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();

                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@LUB", loggeduser.Username);
                    cmd.Parameters.AddWithValue("@roleid", user.RoleId);
                    cmd.Parameters.AddWithValue("@status", user.IsActive);

                    int result = cmd.ExecuteNonQuery();

                    if (result == 1)
                        return true;
                    else return false;
                }


            }

            catch(Exception e)
            {
                string x = e.Message.ToString();
                return false;
            }
        }

        public int Remove(int id)
        {
            throw new NotImplementedException();
        }

        public int Remove(User model)
        {
            throw new NotImplementedException();
        }

        public static User ToObject(SqlDataReader reader)
        {
            User user = new User();

            user.UserID = int.Parse(reader["UserId"].ToString());
            user.Username = reader["Username"].ToString();
            user.RoleId = int.Parse(reader["RoleId"].ToString());
            user.IsActive = (bool)reader["IsActive"];
            user.InsertBy = reader["InsertBy"].ToString();
            user.InsertDate = (DateTime)reader["InsertDate"];

            //if (reader["LastLoginDate"] != DBNull.Value)
            //    user.LastLoginDate = (DateTime)reader["LastLoginDate"];

            //if (reader["LastPasswordChangeDate"] != DBNull.Value)
            //    user.LastPasswordChangeDate = (DateTime)reader["LastPasswordChangeDate"];

            //if (reader["IsPasswordChanged"] != DBNull.Value)
            //    user.IsPasswordChanged = reader["IsPasswordChanged"].ToString() == "1";

            return user;

        }
    }
}
