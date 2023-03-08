using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySQLAPP.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLAPP.DAOs
{
    public class CarsDao
    {
        private readonly string ConnectionString = "server=localhost;database=studies;uid=root;password=123qwe4r5t6YY;";
        private readonly string SQL_AddItems = "insert into Car (name,color,datecreate,type,mileage) values {0};";
        private readonly string SQL_AddItem = "insert into Car (code,name,color,datecreate,type,mileage) values (@code1, @name1, @color1,@datecreate1, @type1, @mileage1);";
        private readonly string SQL_selectItems = "select code,name,color,datecreate,type,mileage from car;";
        private readonly string SQL_DeleteParametrs = "delete from car where Code=@code;";
        public int Add(Car car)
        {
            if (car == null) throw new ArgumentNullException(nameof(car));
            MySqlConnection connection = Connection();
            if (connection == null) throw new Exception("Connection Error");
            try
            {
                //MySqlCommand command=new MySqlCommand(string.Format(SQL_AddItem,"(@code1, @name1, @color1, @datacreate1, @type1, @mileage)"), connection);
                MySqlCommand command = new MySqlCommand(SQL_AddItem, connection);
                command.Parameters.AddWithValue("@code1", car.Code);
                command.Parameters.AddWithValue("@name1", car.Name);
                command.Parameters.AddWithValue("@color1", car.Color);
                command.Parameters.AddWithValue("@datecreate1", car.TimeCreate);
                command.Parameters.AddWithValue("@type1", car.Type);
                command.Parameters.AddWithValue("@mileage1", car.Mileage);
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

        public int AddFew(List<Car> cars)
        {
            if (cars == null) throw new ArgumentNullException(nameof(cars));
            MySqlConnection connection = Connection();
            if (connection == null) throw new Exception("Connection Error");
            try
            {
                string[] insert = new string[cars.Count];
                for (int i = 0; i < cars.Count; i++)
                {
                    insert[i] = $"(@name1{i}, @color1{i},@datecreate1{i}, @type1{i}, @mileage1{i})";
                }
                //MySqlCommand command=new MySqlCommand(string.Format(SQL_AddItem,"(@code1, @name1, @color1, @datacreate1, @type1, @mileage)"), connection);
                MySqlCommand command = new MySqlCommand(string.Format(SQL_AddItems, string.Join(",", insert)), connection);
                for (int i = 0; i < cars.Count; i++)
                {
                    var car = cars[i];
                    //command.Parameters.AddWithValue("@code1", car.Code);
                    command.Parameters.AddWithValue($"@name1{i}", car.Name);
                    command.Parameters.AddWithValue($"@color1{i}", car.Color);
                    command.Parameters.AddWithValue($"@datecreate1{i}", car.TimeCreate);
                    command.Parameters.AddWithValue($"@type1{i}", car.Type);
                    command.Parameters.AddWithValue($"@mileage1{i}", car.Mileage);
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

        public List<Car> GetCars()
        {

            MySqlConnection connection = Connection();
            if (connection == null) throw new Exception("connection error");
            try
            {
                List<Car> cars = new List<Car>();
                MySqlCommand command = new MySqlCommand(SQL_selectItems, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Car car = new Car();
                    car.Code = reader.GetInt32(0);
                    car.Name = reader.GetString(1);
                    car.Color = reader.GetString(2);
                    car.TimeCreate = reader.GetDateTime(3);
                    car.Type = reader.GetString(4);
                    car.Mileage = reader.GetDouble(5);
                    cars.Add(car);
                }
                return cars;
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
