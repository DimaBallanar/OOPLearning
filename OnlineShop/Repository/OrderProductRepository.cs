using MySql.Data.MySqlClient;
using OnlineShop.Models.Repository;
using Org.BouncyCastle.Asn1.X509;

namespace OnlineShop.Repository
{
    public class OrderProductRepository : BaseRepository
    {
        private readonly string SQL_SELECT_GET_ALL = "Select id,Id_User,Id_product,Date,Count, Discount from OrderProduct";
        private readonly string SQL_SELECT_GET_BY_ID = "Select id,Id_User,Id_product,Date,Count, Discount from OrderProduct where id=@id";

        private readonly string SQL_PUT_ORDER = "insert into OrderProduct( id,Id_User,Id_product,Date,Count, Discount) values (@Id_User,@Id_product,@Date,@Count, @Discount)";
        private readonly string SQL_UPDATE_ORDER_PRODUCT = "UPDATE OrderProduct Set Id_User=@Id_User, Id_product=@Id_product, Date=@Date,Count=@Count, Discount=@Discount where Id=@Id";
        private readonly string SQL_DELETE_ORDER_PRODUCT = "delete from OrderProduct where Id=@id;";
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
        public OrderProduct GetAll(int id)
        {
            try
            {
                m_Connection.Open();
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_GET_BY_ID, m_Connection);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    OrderProduct order = new OrderProduct()
                    {
                        Id = reader.GetInt32(0),
                        Id_User = reader.GetInt32(1),
                        Id_Product = reader.GetInt32(2),
                        Date = reader.GetDateTime(3),
                        Count = reader.GetInt32(4),
                        Discount = reader.GetInt32(5)
                    };
                    return order;
                }
                return null;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public int Put(OrderProduct order)
        {
            try
            {
                m_Connection.Open();
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_GET_ALL, m_Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetInt32(1) != order.Id_Product)
                    {
                        m_Connection.Close();
                        OrderProduct product1 = new OrderProduct();
                        m_Connection.Open();
                        MySqlCommand command = new MySqlCommand(SQL_PUT_ORDER, m_Connection);
                        command.Parameters.AddWithValue("@Id_User", order.Id_User);
                        command.Parameters.AddWithValue("@Id_product", order.Id_Product);
                        command.Parameters.AddWithValue("@Date", order.Date);
                        command.Parameters.AddWithValue("@Count", order.Count);
                        command.Parameters.AddWithValue("@Discount", order.Discount);
                        command.ExecuteNonQuery();
                        return (int)command.LastInsertedId;
                    }
                    //id,Id_User,Id_product,Date,Count, Discount
                }
                return -1;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public List<OrderProduct> Update(OrderProduct order)
        {
            try
            {
                m_Connection.Open();
                MySqlCommand command = new MySqlCommand(SQL_UPDATE_ORDER_PRODUCT, m_Connection);
                command.Parameters.AddWithValue("@Id_User", order.Id_User);
                command.Parameters.AddWithValue("@Id_product", order.Id_Product);
                command.Parameters.AddWithValue("@Date", order.Date);
                command.Parameters.AddWithValue("@Count", order.Count);
                command.Parameters.AddWithValue("@Discount", order.Discount);
                command.ExecuteNonQuery();
                m_Connection.Close();
                List<OrderProduct> products = GetAll();
                return products;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public List<OrderProduct> Delete(int code)
        {
            try
            {
                m_Connection.Open();
                MySqlCommand command = new MySqlCommand(SQL_DELETE_ORDER_PRODUCT, m_Connection);
                command.Parameters.AddWithValue("@id", code);
                command.ExecuteNonQuery();
                m_Connection.Close();
                List<OrderProduct> products = GetAll();
                return products;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }
    }
}
