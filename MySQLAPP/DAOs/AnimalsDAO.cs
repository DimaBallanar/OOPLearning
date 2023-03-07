using MySql.Data.MySqlClient;
using MySQLAPP.Models;
using Mysqlx.Crud;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MySQLAPP.DAOs
{
    public class AnimalsDAO
    {
        private readonly string ConnectionString = "server=localhost;database=studies;uid=root;password=123qwe4r5t6YY;";
        private readonly string SQL_insertItem = "insert into animals(`name`, `type`) values {0};";
        private readonly string SQL_selectItems = "select id, name,type from animals;";
        private readonly string SQL_selectCode = "select*from animals where {0}={1};";
        private readonly string SQL_SelectParametrs = "select*from animals where type='{0}' and id between {1} and {2} ;";
        private readonly string SQL_DeleteParametrs = "delete from animals where Id=@id;";
        private readonly string SQL_UpdateParametrs = "UPDATE Animals Set Id=@id, Name=@name, Type=@type";
        public int Add(Animals animal)
        {

            if (animal == null) throw new ArgumentNullException(nameof(animal));
            MySqlConnection connection = Connection();
            if (connection == null) throw new Exception("connection error");
            try
            {
                MySqlCommand command = new MySqlCommand(string.Format(SQL_insertItem, "(@name0, @type0)"), connection);
                command.Parameters.AddWithValue("@name0", animal.Name);
                command.Parameters.AddWithValue("@type0", animal.Type);
                command.ExecuteNonQuery();
                return (int)command.LastInsertedId;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
        public void AddRange(List<Animals> animals)
        {
            if (animals == null) throw new ArgumentNullException(nameof(animals));
            if (animals.Count == 0) return;
            MySqlConnection connection = Connection();
            if (connection == null) throw new Exception("connection error");
            try
            {
                string[] insert = new string[animals.Count];
                for (int i = 0; i < animals.Count; i++)
                {
                    insert[i] = $"(@name{i}, @type{i})";
                }
                MySqlCommand command = new MySqlCommand(string.Format(SQL_insertItem, string.Join(",", insert)), connection);
                for (int i = 0; i < animals.Count; i++)
                {
                    var animal = animals[i];
                    command.Parameters.AddWithValue($"@name{i}", animal.Name);
                    command.Parameters.AddWithValue($"@type{i}", animal.Type);
                }
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
        public Animals GetAnimal(int num)
        {

            MySqlConnection connection = Connection();
            if (connection == null) throw new Exception("connection error");
            try
            {
                Animals animal = new Animals();
                MySqlCommand command = new MySqlCommand(string.Format(SQL_selectCode, "Id", num), connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (num == reader.GetInt32(0))
                    {
                        animal.ID = reader.GetInt32(0);
                        animal.Name = reader.GetString(1);
                        animal.Type = reader.GetString(2);                        
                    }
                }
                return animal;

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }
        public Animals GetAnimal(string type)
        {

            MySqlConnection connection = Connection();
            if (connection == null) throw new Exception("connection error");
            try
            {
                Animals animal = new Animals();
                MySqlCommand command = new MySqlCommand(string.Format(SQL_selectCode, "Type", type), connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (type == reader.GetString(2))
                    {
                        animal.ID = reader.GetInt32(0);
                        animal.Name = reader.GetString(1);
                        animal.Type = reader.GetString(2);
                    }
                }
                return animal;

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }
        public void DeleteAnimal(int num)
        {

            MySqlConnection connection = Connection();
            if (connection == null) throw new Exception("connection error");
            try
            {
                MySqlCommand command = new MySqlCommand(SQL_DeleteParametrs, connection);
                command.Parameters.AddWithValue("@id", num);
                command.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }
        public void UpdateAnimal(string name, string type, int id)
        {

            MySqlConnection connection = Connection();
            if (connection == null) throw new Exception("connection error");
            try
            {               
                MySqlCommand command = new MySqlCommand(SQL_UpdateParametrs, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@Type", type);
                command.ExecuteNonQuery();               

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }
       
        public List<Animals> GetAnimal(string type, int numStart, int numEnd)
        {

            MySqlConnection connection = Connection();
            if (connection == null) throw new Exception("connection error");
            try
            {
                List<Animals> animals = new List<Animals>();
                MySqlCommand command = new MySqlCommand(string.Format(SQL_SelectParametrs, type, numStart, numEnd), connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (type == reader.GetString(2) && numStart >= reader.GetInt32(0) && numEnd <= reader.GetInt32(0))
                    {
                        Animals animal = new Animals();
                        animal.ID = reader.GetInt32(0);
                        animal.Name = reader.GetString(1);
                        animal.Type = reader.GetString(2);
                        animals.Add(animal);
                    }
                }
                return animals;

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }
        public List<Animals> GetAll()
        {

            MySqlConnection connection = Connection();
            if (connection == null) throw new Exception("connection error");
            try
            {
                List<Animals> animals = new List<Animals>();
                MySqlCommand command = new MySqlCommand(SQL_selectItems, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Animals animal = new Animals();
                    animal.ID = reader.GetInt32(0);
                    animal.Name = reader.GetString(1);
                    animal.Type = reader.GetString(2);
                    animals.Add(animal);
                }
                return animals;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
        //public void ConsoleShow(GetAnimal())
        //{
        //    foreach(var animal in GetAll()) { Console.WriteLine(animal); }
        //}
        private MySqlConnection Connection()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(ConnectionString);
                connection.Open();
                return connection;
            }
            catch (MySqlException ex)
            {
                return null;
            }
        }
    }
}

