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
                        Name = reader.GetString(1)                        
                    });
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
