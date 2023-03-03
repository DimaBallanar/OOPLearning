using MySql.Data.MySqlClient;
using MySQLAPP.Models;
using Mysqlx.Crud;
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
        //private readonly string SQL_insertItem = "insert into animals('name', 'type') values('@name', '@type');";
        //public int Add(Animals animal)
        //{
        //    if (animal == null) throw new ArgumentNullException(nameof(animal));
        //    MySqlConnection connection = Connection();
        //    if (connection == null) throw new Exception("404");
        //    try
        //    {

        //        connection.Open();
        //        MySqlCommand command = new MySqlCommand(string.Format(SQL_insertItem, "(@name, @type)"), connection);
        //        command.Parameters.AddWithValue("@name", animal.Name);
        //        command.Parameters.AddWithValue("@type", animal.Type);
        //        command.ExecuteNonQuery();
        //        return (int)command.LastInsertedId; ;
        //    }
        //    catch (MySqlException ex)
        //    {
        //        Console.WriteLine(ex);
        //        throw ex;
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //}
        //public void AddRange(List<Animals> animals)
        //{
        //    if (animals == null) throw new ArgumentNullException(nameof(animals));
        //    if (animals.Count == 0) return;
        //    MySqlConnection connection = Connection();
        //    if (connection == null) throw new Exception("connection error");
        //    try
        //    {
        //        string[] insert = new string[animals.Count];
        //        for (int i = 0; i < animals.Count; i++)
        //        {
        //            insert[i] = $"(@name{i},@type{i})";
        //        }
        //        MySqlCommand command = new MySqlCommand(string.Format(SQL_insertItem, string.Join(",", insert)), connection);
        //        for (int i = 0; i < animals.Count; i++)
        //        {
        //            var animal = animals[i];
        //            command.Parameters.AddWithValue("@name", animal.Name);
        //            command.Parameters.AddWithValue("@type", animal.Type);
        //        }

        //        command.ExecuteNonQuery();
        //    }
        //    catch (MySqlException ex)
        //    {
        //        Console.WriteLine(ex);
        //        throw ex;
        //    }
        //}
        //private MySqlConnection Connection()
        //{
        //    try
        //    {
        //        MySqlConnection connection = new MySqlConnection(ConnectionString);
        //        connection.Open();
        //        return connection;
        //    }
        //    catch (MySqlException ex)
        //    {
        //        return null;
        //    }
        //}
        private readonly string SQL_insertItem = "insert into animals(`name`, `type`) values {0};";
        private readonly string SQL_selectItems = "select id, 'name','type' from animals;";
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
        public List<Animals> GetAnimals()
        {

            MySqlConnection connection = Connection();
            if (connection == null) throw new Exception("connection error");
            try
            {
                MySqlCommand command = new MySqlCommand(SQL_selectItems, connection);
                List<Animals> animals = new List<Animals>();
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
        public List<Animals> GetAll()
        {
            List<Animals> animals = new List<Animals>();
            MySqlConnection connection = Connection();
            if (connection == null) throw new Exception("connection error");
            try
            {
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





