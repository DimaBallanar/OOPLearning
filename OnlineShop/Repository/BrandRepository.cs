using MySql.Data.MySqlClient;
using OnlineShop.Models.Repository;

namespace OnlineShop.Repository
{
    public class BrandRepository : BaseRepository
    {
        private readonly string SQL_SELECT_GET_ALL = "Select id,name from brand";
        private readonly string SQL_PUT_ITEM = "insert into brand(name) values (@name)";
        private readonly string SQL_UPDATE_BRAND = "UPDATE brand Set name=@name where Id={0}";
        private readonly string SQL_DELETE_BRAND = "delete from brand where Id=@id;";

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

        public List<Brand> GetAll(int id)
        {
            try
            {
                m_Connection.Open();
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_GET_ALL, m_Connection);
                List<Brand> brands = new List<Brand>();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id)
                    {
                        brands.Add(new Brand()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1)                           
                        });
                    }
                }
                return brands;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public int Put(Brand brand)
        {
            try
            {
                m_Connection.Open();
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_GET_ALL, m_Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetString(1) != brand.Name)
                    {
                        m_Connection.Close();
                        Brand brand1 = new Brand();
                        m_Connection.Open();
                        MySqlCommand command = new MySqlCommand(SQL_PUT_ITEM, m_Connection);                      
                        command.Parameters.AddWithValue("@name", brand.Name);                    
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

        public List<Brand> Update(Brand brand)
        {
            try
            {
                m_Connection.Open();
                MySqlCommand cmd = new MySqlCommand(string.Format(SQL_UPDATE_BRAND, brand.Id), m_Connection);
                cmd.Parameters.AddWithValue("@name", brand.Name);               
                cmd.ExecuteNonQuery();
                m_Connection.Close();
                List<Brand> brands = GetAll();
                return brands;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public List<Brand> Delete(int code)
        {
            try
            {
                m_Connection.Open();

                MySqlCommand command = new MySqlCommand(SQL_DELETE_BRAND, m_Connection);
                command.Parameters.AddWithValue("@id", code);
                command.ExecuteNonQuery();
                m_Connection.Close();
                List<Brand> brands = GetAll();
                return brands;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }
    }
}
