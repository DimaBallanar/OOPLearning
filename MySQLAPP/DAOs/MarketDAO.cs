using MySql.Data.MySqlClient;
using MySQLAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLAPP.DAOs
{
    public class MarketDAO
    {

        private readonly string ConnectionString = "server=localhost;database=studies;uid=root;password=123qwe4r5t6YY;";
        private readonly string SQL_AddItems = "insert into Market (name,adress,phone,countplace,timefrom,timeto) values {0};";
        private readonly string SQL_AddItem = "insert into Market (name,adress,phone,countplace,timefrom,timeto) values (@name,@adress,@phone,@countplace, @timefrom, @timeto);";
        private readonly string SQL_selectItems = "select id,name,adress,phone,countplace,timefrom,timeto from Market;";
        private readonly string SQL_selectItem = "select id,name,adress,phone,countplace,timefrom,timeto from Market where Id=@id;";
        private readonly string SQL_UpdateParametrs = "UPDATE Market Set Name=@name, password=@password,email=@email,lastlogin=@lastlogin,money=@money where id={0}";
        private readonly string SQL_DeleteParametrs = "delete from Market where Id=@id;";

        public int Add(Market market)
        {
            if (market == null) throw new ArgumentNullException(nameof(market));
            MySqlConnection connection = Connection();
            if (connection == null) throw new Exception("Connection Error");
            try
            {
                MySqlCommand command = new MySqlCommand(SQL_AddItem, connection);
                command.Parameters.AddWithValue("@name", market.Name);
                command.Parameters.AddWithValue("@adress", market.Adress);
                command.Parameters.AddWithValue("@phone", market.Phone);
                command.Parameters.AddWithValue("@countplace", market.CountPlace);
                command.Parameters.AddWithValue("@timefrom", market.TimeFrom);
                command.Parameters.AddWithValue("@timeto", market.TimeTo);

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

        public int AddFew(List<Market> markets)
        {
            if (markets == null) throw new ArgumentNullException(nameof(markets));
            MySqlConnection connection = Connection();
            if (connection == null) throw new Exception("Connection Error");
            try
            {
                string[] insert = new string[markets.Count];
                for (int i = 0; i < markets.Count; i++)
                {
                    insert[i] = $"(@name{i}, @adress{i},@phone{i}, @countplace{i}, @timefrom{i},@timeto{i})";
                }
                MySqlCommand command = new MySqlCommand(string.Format(SQL_AddItems, string.Join(",", insert)), connection);
                for (int i = 0; i < markets.Count; i++)
                {
                    var market = markets[i];
                    command.Parameters.AddWithValue($"@name{i}", market.Name);
                    command.Parameters.AddWithValue($"@adress{i}", market.Adress);
                    command.Parameters.AddWithValue($"@phone{i}", market.Phone);
                    command.Parameters.AddWithValue($"@countplace{i}", market.CountPlace);
                    command.Parameters.AddWithValue($"@timefrom{i}", market.TimeFrom);
                    command.Parameters.AddWithValue($"@timeto{i}", market.TimeTo);

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

        public List<Market> GetMarkets()
        {

            MySqlConnection connection = Connection();
            if (connection == null) throw new Exception("connection error");
            try
            {
                List<Market> markets = new List<Market>();
                MySqlCommand command = new MySqlCommand(SQL_selectItems, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Market market = new Market();
                    market.Id = reader.GetInt32(0);
                    market.Name = reader.GetString(1);
                    market.Adress = reader.GetString(2);
                    market.Phone = reader.GetString(3);
                    market.CountPlace = reader.GetInt32(4);
                    market.TimeFrom = reader.GetDateTime(5);
                    market.TimeTo = reader.GetDateTime(6);
                    markets.Add(market);
                }
                return markets;
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

        public Market GetMarket(int id)
        {

            MySqlConnection connection = Connection();
            if (connection == null) throw new Exception("connection error");
            try
            {
                Market market = new Market();
                MySqlCommand command = new MySqlCommand(SQL_selectItem, connection);
                command.Parameters.AddWithValue("@Id", id);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (id == reader.GetInt32(0))
                    {
                        market.Id = reader.GetInt32(0);
                        market.Name = reader.GetString(1);
                        market.Adress = reader.GetString(2);
                        market.Phone = reader.GetString(3);
                        market.CountPlace = reader.GetInt32(4);
                        market.TimeFrom = reader.GetDateTime(5);
                        market.TimeTo = reader.GetDateTime(6);
                    }
                }
                return market;
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

        public void UpdateMarket(int id)
        {
            MySqlConnection connection = Connection();
            if (connection == null) throw new Exception("connection error");
            try
            {
                MySqlCommand command = new MySqlCommand(string.Join(SQL_UpdateParametrs, id), connection);
                Console.WriteLine("введите название:");

                command.Parameters.AddWithValue($"@name", Convert.ToString(Console.ReadLine()));
                Console.WriteLine("введите адрес");

                command.Parameters.AddWithValue($"@adress", Convert.ToString(Console.ReadLine()));
                Console.WriteLine("введите номер телефона в формате +375");


                command.Parameters.AddWithValue($"@phone", Convert.ToString(Console.ReadLine()));
                Console.WriteLine("введите количество мест");
                command.Parameters.AddWithValue($"@countplace", Convert.ToInt32(Console.ReadLine()));
                command.Parameters.AddWithValue($"@TimeFrom", DateTime.Now);
                Console.WriteLine("введите через сколько дней");
                command.Parameters.AddWithValue($"@Timeto", DateTime.Now.AddDays(Convert.ToInt32(Console.ReadLine())));
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
