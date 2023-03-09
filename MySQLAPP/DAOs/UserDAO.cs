using MySql.Data.MySqlClient;
using MySQLAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLAPP.DAOs
{
    public class UserDAO
    {
        private readonly string ConnectionString = "server=localhost;database=studies;uid=root;password=123qwe4r5t6YY;";
        private readonly string SQL_AddItems = "insert into User (name,password,email,lastlogin,money) values {0};";
        private readonly string SQL_AddItem = "insert into User (name,password,email,lastlogin,money) values ( @name, @password,@email, @lastlogin, @money);";
        private readonly string SQL_selectItems = "select id,name,password,email,lastlogin,money from User;";
        private readonly string SQL_selectItem = "select id,name,password,email,lastlogin,money from User where Id=@id;";
        private readonly string SQL_UpdateParametrs = "UPDATE User Set Name=@name, password=@password,email=@email,lastlogin=@lastlogin,money=@money where id={0}";
        private readonly string SQL_DeleteParametrs = "delete from User where Id=@id;";

        public int Add(User user)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));
            MySqlConnection connection = Connection();
            if (connection == null) throw new Exception("Connection Error");
            try
            {
                MySqlCommand command = new MySqlCommand(SQL_AddItem, connection);
                command.Parameters.AddWithValue("@name", user.Name);
                command.Parameters.AddWithValue("@password", user.Password) ;
                command.Parameters.AddWithValue("@email", user.Email);
                command.Parameters.AddWithValue("@lastlogin",user.LastLogin);
                command.Parameters.AddWithValue("@money", user.Money);
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

        public int AddFew(List<User> user)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));
            MySqlConnection connection = Connection();
            if (connection == null) throw new Exception("Connection Error");
            try
            {
                string[] insert = new string[user.Count];
                for (int i = 0; i < user.Count; i++)
                {
                    insert[i] = $"(@name{i}, @password{i},@email{i}, @lastlogin{i}, @money{i})";
                }                
                MySqlCommand command = new MySqlCommand(string.Format(SQL_AddItems, string.Join(",", insert)), connection);
                for (int i = 0; i < user.Count; i++)
                {
                    var car = user[i];
                    //command.Parameters.AddWithValue("@code1", car.Code);
                    command.Parameters.AddWithValue($"@name{i}", car.Name);
                    command.Parameters.AddWithValue($"@password{i}", car.Password);
                    command.Parameters.AddWithValue($"@email{i}", car.Email);
                    command.Parameters.AddWithValue($"@lastlogin{i}", car.LastLogin);
                    command.Parameters.AddWithValue($"@money{i}", car.Money);
                }
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

        public List<User> GetUsers()
        {

            MySqlConnection connection = Connection();
            if (connection == null) throw new Exception("connection error");
            try
            {
                List<User> users = new List<User>();
                MySqlCommand command = new MySqlCommand(SQL_selectItems, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User();
                    user.Id = reader.GetInt32(0);
                    user.Name = reader.GetString(1);
                    user.Password = reader.GetString(2);
                    user.Email = reader.GetString(3);
                   user.LastLogin = reader.GetDateTime(4);
                    user.Money = reader.GetDouble(5);
                    users.Add(user);
                }
                return users;
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

        public User GetUser(int id)
        {

            MySqlConnection connection = Connection();
            if (connection == null) throw new Exception("connection error");
            try
            {
                User user = new User();
                MySqlCommand command = new MySqlCommand(SQL_selectItem, connection);
                command.Parameters.AddWithValue("@Id", id);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (id == reader.GetInt32(0))
                    {
                        user.Id = reader.GetInt32(0);
                        user.Name = reader.GetString(1);
                        user.Password = reader.GetString(2);
                        user.Email = reader.GetString(3);
                        user.LastLogin = reader.GetDateTime(4);
                        user.Money = reader.GetDouble(5);
                    }
                }
                return user;
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

        public void Delete(int code)
        {
            MySqlConnection connection = Connection();
            if (connection == null) throw new Exception("connection error");
            try
            {
                MySqlCommand command = new MySqlCommand(SQL_DeleteParametrs, connection);
                command.Parameters.AddWithValue("@id", code);
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

        public void UpdateCar(int id)
        {
            MySqlConnection connection = Connection();
            if (connection == null) throw new Exception("connection error");
            try
            {
                MySqlCommand command = new MySqlCommand(string.Join(SQL_UpdateParametrs, id), connection);
                Console.WriteLine("введите имя");
                command.Parameters.AddWithValue($"@name", Convert.ToString(Console.ReadLine()));
                Console.WriteLine("введите пароль");
                command.Parameters.AddWithValue($"@password", Convert.ToString(Console.ReadLine()));
                Console.WriteLine("введите email");
                command.Parameters.AddWithValue($"@email", Convert.ToString(Console.ReadLine()));
                command.Parameters.AddWithValue($"@lastlogin", DateTime.Now);                
                Console.WriteLine("введите наличку");
                command.Parameters.AddWithValue($"@money", Convert.ToDouble(Console.ReadLine()));
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
