using MySql.Data.MySqlClient;
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
        private readonly string SQL_AddItems = "insert into User (name,password,email,lastlogin,money) values {0};";
        private readonly string SQL_AddItem = "insert into User (name,password,email,lastlogin,money) values ( @name, @password,@email, @lastlogin, @money);";
        private readonly string SQL_selectItems = "select id,name,password,email,lastlogin,money from User;";
        private readonly string SQL_selectItem = "select id,name,password,email,lastlogin,money from User where Id=@id;";
        private readonly string SQL_UpdateParametrs = "UPDATE User Set Name=@name, password=@password,email=@email,lastlogin=@lastlogin,money=@money where id={0}";
        private readonly string SQL_DeleteParametrs = "delete from User where Id=@id;";





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
