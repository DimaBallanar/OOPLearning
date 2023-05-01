using MySql.Data.MySqlClient;
using OnlineShop.Models;

namespace OnlineShop.Repository
{
    public class BrandRepository : BaseRepository
    {
        private readonly string SQL_SELECT_GET_ALL = "Select id,name from brand";
        private readonly string SQL_PUT_ITEM = "insert into brand(name) values (@name)";
        private readonly string SQL_UPDATE_USER = "UPDATE brand Set name=@name where Id={0}";
        private readonly string SQL_DELETE_USER = "delete from brand where Id=@id;";

        public BrandRepository(MySqlConnection connection) : base(connection)
        {

        }
        public List<Brand> GetAll()
        {
            try
            {
                m_Connection.Open();
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_GET_ALL, m_Connection);
                List<Brand> brands = new List<Brand>();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    brands.Add(new Brand()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1)                        
                    });
                }
                return brands;
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
                            Name = reader.GetString(1)                           
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

        public int Put(User user)
        {
            try
            {
                m_Connection.Open();
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_GET_ALL, m_Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetString(3) != user.Email)
                    {
                        m_Connection.Close();
                        User user1 = new User();
                        m_Connection.Open();
                        MySqlCommand command = new MySqlCommand(SQL_PUT_ITEM, m_Connection);                      
                        command.Parameters.AddWithValue("@name", user.Name);                    
                        command.ExecuteNonQuery();
                        return (int)command.LastInsertedId;
                    }

                }
                return -1;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
    }
}
