using MySql.Data.MySqlClient;
using MySQLAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLAPP.DAOs
{
    public class CarsDao
    {
        private readonly string ConnectionString = "server=localhost;database=studies;uid=root;password=123qwe4r5t6YY;";
        private readonly string SQL_AddItem = "insert into Car ('code','name','color','datecreate','type','mileage');";
        
        public int Add(Car car)
        {
            if (car == null) throw new ArgumentNullException(nameof(car));
            MySqlConnection connection = Connection();
            if(connection==null) throw new Exception("Connection Error");
            try
            {
                MySqlCommand command=new MySqlCommand(string.Format(SQL_AddItem,"(@code1, @name1, @color1, @datacreate1, @type1, @mileage)"), connection);
                command.Parameters.AddWithValue("@code1", command.LastInsertedId-1);
                command.Parameters.AddWithValue("@name1", car.Name);
                command.Parameters.AddWithValue("@color1", car.Color);
                command.Parameters.AddWithValue("@datecreate1", car.TimeCreate);
                command.Parameters.AddWithValue("@type1", car.Type);
                command.Parameters.AddWithValue("@mileage1", car.Mileage);
                command.ExecuteNonQuery();
                return (int)command.LastInsertedId;
            }
            catch(MySqlException ex)
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
                MySqlConnection connection=new MySqlConnection(ConnectionString);
                connection.Open();
                return connection;
            }
            catch(MySqlException ex)
            {
                return null;
            }
        }
    }
}
