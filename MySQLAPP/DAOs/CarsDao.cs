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
        private readonly string SQL_AddItem = "insert into Car ('name','color','datecreate','type','mileage') values {0};";
        
        public int Add(Car car)
        {
            if (car == null) throw new ArgumentNullException(nameof(car));
            MySqlConnection connection = Connection();
            if(connection==null) throw new Exception("Connection Error");
            try
            {
                MySqlCommand command=new MySqlCommand(string.Format(SQL_AddItem,"(@name1, @color1, @datacreate1, @type1, @mileage)"), connection);
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
