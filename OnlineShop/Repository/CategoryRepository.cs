using MySql.Data.MySqlClient;
using OnlineShop.Models;

namespace OnlineShop.Repository
{
    public class CategoryRepository : BaseRepository
    {
        private readonly string SQL_SELECT_GET_ALL = "Select id,name from Category";
        private readonly string SQL_PUT_ITEM = "insert into Category(name) values (@name)";
        private readonly string SQL_UPDATE_CATEGORY = "UPDATE Category Set name=@name where Id={0}";
        private readonly string SQL_DELETE_CATEGORY = "delete from Category where Id=@id;";

        public CategoryRepository(MySqlConnection connection) : base(connection)
        {
        }

        public List<Category> GetAll()
        {
            try
            {
                m_Connection.Open();
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_GET_ALL, m_Connection);
                List<Category> categories = new List<Category>();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    categories.Add(new Category()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1)
                    });
                }
                return categories;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public List<Category> GetAll(int id)
        {
            try
            {
                m_Connection.Open();
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_GET_ALL, m_Connection);
                List<Category> categories = new List<Category>();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id)
                    {
                        categories.Add(new Category()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1)
                        });
                    }
                }
                return categories;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public int Put(Category category)
        {
            try
            {
                m_Connection.Open();
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_GET_ALL, m_Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetString(1) != category.Name)
                    {
                        m_Connection.Close();
                        Category category1 = new Category();
                        m_Connection.Open();
                        MySqlCommand command = new MySqlCommand(SQL_PUT_ITEM, m_Connection);
                        command.Parameters.AddWithValue("@name", category.Name);
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

        public List<Category> Update(Category category)
        {
            try
            {
                m_Connection.Open();
                MySqlCommand cmd = new MySqlCommand(string.Format(SQL_UPDATE_CATEGORY, category.Id), m_Connection);
                cmd.Parameters.AddWithValue("@name", category.Name);
                cmd.ExecuteNonQuery();
                m_Connection.Close();
                List<Category> categories = GetAll();
                return categories;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public List<Category> Delete(int code)
        {
            try
            {
                m_Connection.Open();

                MySqlCommand command = new MySqlCommand(SQL_DELETE_CATEGORY, m_Connection);
                command.Parameters.AddWithValue("@id", code);
                command.ExecuteNonQuery();
                m_Connection.Close();
                List<Category> categories = GetAll();
                return categories;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }
    }
}
