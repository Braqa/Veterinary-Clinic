using KlinikaVeterinare.BO.Interfaces;
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
    public class AnimalDAL// : IBaseCrud<Animal>, IBaseConvertToObject<Animal>
    {
        // CREATE - INSERT
        // Connectio nstring me db
        public static string connectionString = ConfigurationManager.ConnectionStrings["FaunaJoneDB"].ConnectionString;
        public static bool Add(Animal animal,Owner owner,User loggeduser)
        {
            string dbcon = ConfigurationManager.ConnectionStrings["FaunaJoneDB"].ConnectionString;
            SqlConnection con = new SqlConnection(dbcon);

            SqlCommand cmd = new SqlCommand("usp_Animal_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@sex", animal.SexID);
            cmd.Parameters.AddWithValue("@name", animal.Name);
            cmd.Parameters.AddWithValue("@familyID", animal.FamilyID);
            cmd.Parameters.AddWithValue("@raceID", animal.RaceID);
            cmd.Parameters.AddWithValue("@birthday",animal.Birthday);
            cmd.Parameters.AddWithValue("@ownerID", owner.OwnerID);
            cmd.Parameters.AddWithValue("@insertBy",loggeduser.Username);

            con.Open();

            int result = cmd.ExecuteNonQuery();

            if (result == 1)
                return true;
            else 
                return false;
        }

        // READ by id
        public static Animal Get(string id)
        {
            try
            {
                Animal animal = null;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("usp_GetAnimalByID", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@animalid", id));
                 
                    SqlDataReader reader = command.ExecuteReader();
                        
                    if (reader.Read())
                    {                               
                        animal = ToObject(reader);
                    }     
                }
                return animal;
            }
            catch (Exception e)
            {
                string x = e.Message.ToString();
                return null;
            }
        }

        public Animal Get(Animal model)
        {
            throw new NotImplementedException();
        }

        // READ as list
        public static List<Animal> GetAll()
        {
            string dbcon = ConfigurationManager.ConnectionStrings["FaunaJoneDB"].ConnectionString;
            SqlConnection con = new SqlConnection(dbcon);

            try
            {
                List<Animal> animals = new List<Animal>();

                Animal animal = null;
                using (SqlConnection connection = new SqlConnection(dbcon))
                {

                    connection.Open();
                    using (SqlCommand command = new SqlCommand("dbo.usp_Animal_GetAll", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                animal = new Animal();
                                animal.AnimalID = reader["AnimalID"].ToString();
                                animal.Name = reader["Name"].ToString();
                                animal.Birthday = Convert.ToDateTime(reader["Birthday"]);
                                animal.SexID = Convert.ToInt32(reader["SexID"].ToString());
                                animal.OwnerID =Convert.ToInt32(reader["OwnerID"].ToString());
                                animal.FamilyID = Convert.ToInt32(reader["FamilyID"].ToString());
                                animal.RaceID = Convert.ToInt32(reader["RaceID"].ToString());
                                animal.InsertDate = Convert.ToDateTime(reader["InsertDate"]);

                                animals.Add(animal);
                            }
                        }
                    }
                }
                return animals;
            }
            catch (Exception e)
            {
                string x = e.Message.ToString();
                return null;
            }
        }

        // Modify
        public static bool Modify(Animal model,Owner owner,User loggeduser)
        {
            using (var connection = DataConnection.GetConnection())
            {
                using (var command = DataConnection.Command(connection, "dbo.usp_Animal_Update"))
                {
                    command.Parameters.AddWithValue("@animalID", model.AnimalID);
              
                    command.Parameters.AddWithValue("@name", model.Name);
                    command.Parameters.AddWithValue("@familyID", model.FamilyID);
                    command.Parameters.AddWithValue("@raceID", model.RaceID);
                    command.Parameters.AddWithValue("@birthday", model.Birthday);
                    command.Parameters.AddWithValue("@ownerID", owner.OwnerID);
                    command.Parameters.AddWithValue("@LUB", loggeduser.Username);
                  

                    int result = command.ExecuteNonQuery();

                    if (result == 1)
                    {
                        return true;
                    }
                    else

                    return false;
                }
            }
        }

        // DELETE
        public int Remove(int id)
        {
            using (var connection = DataConnection.GetConnection())
            {
                using (var command = DataConnection.Command(connection, "dbo.usp_Animal_RemoveById"))
                {
                    command.Parameters.AddWithValue("id", id);
                    int result = command.ExecuteNonQuery();
                    return result;
                }
            }
        }

        public int Remove(Animal model)
        {
            throw new NotImplementedException();
        }

        public static Animal ToObject(SqlDataReader reader)
        {
            Animal animal = new Animal();

            animal.AnimalID = reader["AnimalID"].ToString();
            animal.SexID = int.Parse(reader["SexID"].ToString());
            if (reader["Name"] != DBNull.Value)
            {
                animal.Name = reader["Name"].ToString();
            }
            if (reader["FamilyID"] != DBNull.Value)
            {
                animal.FamilyID = int.Parse(reader["FamilyID"].ToString()); 
            }
            if (reader["RaceID"] != DBNull.Value)
            {
                animal.RaceID = int.Parse(reader["raceID"].ToString()); 
            }
            if (reader["birthday"] != DBNull.Value)
            {
                animal.Birthday = (DateTime)reader["birthday"];
            }
            animal.OwnerID = int.Parse(reader["ownerID"].ToString());
            // Auditimi
            animal.InsertBy = reader["insertBy"].ToString();
            animal.InsertDate = (DateTime)reader["insertDate"];
            if (reader["LUB"] != DBNull.Value)
            {
                animal.LUB = reader["LUB"].ToString();
            }
            if (reader["LUD"] != DBNull.Value)
            {
                animal.LUD = (DateTime)reader["LUD"];
            } 
            animal.LUN = int.Parse(reader["LUN"].ToString());
                                                                        
            return animal;
        }
    }
}
