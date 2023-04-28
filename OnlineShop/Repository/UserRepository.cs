using MySql.Data.MySqlClient;
using OnlineShop.Models;

namespace OnlineShop.Repository
{
    public class UserRepository
    {
        private readonly MySqlConnection m_Connection;
        private readonly string SQL_SELECT_GET_ALL = "Select id,name,surname,email,password from studaki";
        public UserRepository(MySqlConnection connection)
        {
            m_Connection = connection;
        }

        public List<User> GetAll()
        {
            try
            {
                m_Connection.Open();
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_GET_ALL, m_Connection);
                List<User> users = new List<User>();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    users.Add(new User()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Surname = reader.GetString(2),
                        Email = reader.GetString(3),
                        Password = reader.GetString(4)
                    });
                }
                return users;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        public List<User> GetAll(int id)
        {
            try
            {
                m_Connection.Open();
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_GET_ALL, m_Connection);
                List<User> users = new List<User>();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id)
                    {
                        users.Add(new User()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Surname = reader.GetString(2),
                            Email = reader.GetString(3),
                            Password = reader.GetString(4)
                        });
                    }
                }
                return users;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
    }
}
