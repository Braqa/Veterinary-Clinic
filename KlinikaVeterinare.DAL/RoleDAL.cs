using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using KlinikaVeterinare.BO;
using KlinikaVeterinare.BO.Interfaces;
using System.Configuration;

namespace KlinikaVeterinare.DAL
{
    public class RoleDAL// : IBaseCrud<Role>, IBaseConvertToObject<Role>
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["FaunaJoneDB"].ConnectionString;
        public int Add(Role model)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    using (var command = DataConnection.Command(connection, "", CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "name", model.Name);
                        DataConnection.AddParameter(command, "description", model.Description);
                        int rowAffected = command.ExecuteNonQuery();
                        return rowAffected;
                    }
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public Role Get(int id)
        {
            try
            {
                Role role = null;

                using (var connection = DataConnection.GetConnection())
                {
                    using (var command = DataConnection.Command(connection, "", CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                                role = ToObject(reader);
                        }
                    }
                }

                return role;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Role Get(Role model)
        {
            throw new NotImplementedException();
        }

        public static List<Role> GetAll()
        {
            try
            {
                List<Role> roles = null;
                using (var connection = DataConnection.GetConnection())
                {
                    using (var command = DataConnection.Command(connection, "usp_GetAllRoles", CommandType.StoredProcedure))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            roles = new List<Role>();
                            while (reader.Read())
                            {
                                roles.Add(ToObject(reader));
                            }
                        }
                    }
                }

                return roles;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Modify(Role model)
        {
            throw new NotImplementedException();
        }

        public int Remove(int id)
        {
            using (var connection = DataConnection.GetConnection())
            {
                using (var command = DataConnection.Command(connection, "", CommandType.StoredProcedure))
                {
                    DataConnection.AddParameter(command, "id", id);
                    int result = command.ExecuteNonQuery();
                    return result;
                }
            }
        }

        public int Remove(Role model)
        {
            throw new NotImplementedException();
        }

        public static Role ToObject(SqlDataReader reader)
        {
            Role role = new Role();
            role.RoleID = int.Parse(reader["RoleId"].ToString());
            role.Name = reader["Name"].ToString();

            if (reader["Description"] != DBNull.Value)
                role.Description = reader["Description"].ToString();


            return role;
        }
    }
}
