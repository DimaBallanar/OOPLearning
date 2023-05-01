using MySql.Data.MySqlClient;
using OnlineShop.Models;

namespace OnlineShop.Repository
{
    public class OrderProductRepository : BaseRepository
    {
        private readonly string SQL_SELECT_GET_ALL = "Select id,name,description,price,brand_id,category_id from OrderProduct";
        private readonly string SQL_PUT_ORDER = "insert into OrderProduct(name,description,price,brand_id,category_id) values (@name, @description, @price, @brand_id, @category_id)";
        private readonly string SQL_UPDATE_ORDERPRODUCT = "UPDATE OrderProduct Set name=@name, description=@description, price=@price,brand_id=@brand_id, category_id=@category_id where Id={0}";
        private readonly string SQL_DELETE_ORDERPRODUCT = "delete from OrderProduct where Id=@id;";
        public OrderProductRepository(MySqlConnection connection) : base(connection)
        {
        }

        public List<OrderProduct> GetAll()
        {
            try
            {
                m_Connection.Open();
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_GET_ALL, m_Connection);
                List<OrderProduct> orders = new List<OrderProduct>();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    orders.Add(new OrderProduct()
                    {
                        Id = reader.GetInt32(0),
                        Id_User = reader.GetInt32(1),
                        Id_Product = reader.GetInt32(2),
                        Date = reader.GetDateTime(3),
                        Count = reader.GetInt32(4),
                        Discount = reader.GetInt32(5)

                    });
                }
                return orders;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        public List<OrderProduct> GetAll(int id)
        {
            try
            {
                m_Connection.Open();
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_GET_ALL, m_Connection);
                List<OrderProduct> orders = new List<OrderProduct>();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id)
                    {
                        orders.Add(new OrderProduct()
                        {
                            Id = reader.GetInt32(0),
                            Id_User = reader.GetInt32(1),
                            Id_Product = reader.GetInt32(2),
                            Date = reader.GetDateTime(3),
                            Count = reader.GetInt32(4),
                            Discount = reader.GetInt32(5)
                        });
                    }
                }
                return orders;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        //public int Put(OrderProduct order)
        //{
        //    try
        //    {
        //        m_Connection.Open();
        //        MySqlCommand cmd = new MySqlCommand(SQL_SELECT_GET_ALL, m_Connection);
        //        MySqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            if (reader.GetInt32(1) != order.Id_Product)
        //            {
        //                m_Connection.Close();
        //                OrderProduct product1 = new OrderProduct();
        //                m_Connection.Open();
        //                MySqlCommand command = new MySqlCommand(SQL_PUT_ORDER, m_Connection);
        //                command.Parameters.AddWithValue("@name", order.Id_User);
        //                command.Parameters.AddWithValue("@description", product.Description);
        //                command.Parameters.AddWithValue("@price", product.Price);
        //                command.Parameters.AddWithValue("@brand_id", product.Brand);
        //                command.Parameters.AddWithValue("@category_id", product.Category);
        //                command.ExecuteNonQuery();
        //                return (int)command.LastInsertedId;
        //            }

        //        }
        //        return -1;
        //    }
        //    catch (MySqlException e)
        //    {
        //        throw e;
        //    }
        //}

        //public List<Product> Update(Product product)
        //{
        //    try
        //    {
        //        m_Connection.Open();
        //        MySqlCommand command = new MySqlCommand(string.Format(SQL_UPDATE_PRODUCT, product.Id), m_Connection);
        //        command.Parameters.AddWithValue("@name", product.Name);
        //        command.Parameters.AddWithValue("@description", product.Description);
        //        command.Parameters.AddWithValue("@price", product.Price);
        //        command.Parameters.AddWithValue("@brand_id", product.Brand);
        //        command.Parameters.AddWithValue("@category_id", product.Category);
        //        command.ExecuteNonQuery();
        //        m_Connection.Close();
        //        List<Product> products = GetAll();
        //        return products;
        //    }
        //    catch (MySqlException e)
        //    {
        //        throw e;
        //    }
        //}

        //public List<Product> Delete(int code)
        //{
        //    try
        //    {
        //        m_Connection.Open();
        //        MySqlCommand command = new MySqlCommand(SQL_DELETE_PRODUCT, m_Connection);
        //        command.Parameters.AddWithValue("@id", code);
        //        command.ExecuteNonQuery();
        //        m_Connection.Close();
        //        List<Product> products = GetAll();
        //        return products;
        //    }
        //    catch (MySqlException ex)
        //    {
        //        Console.WriteLine(ex);
        //        throw ex;
        //    }
        //}
    }
}
