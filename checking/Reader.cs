using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
//using MySQLAPP.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace checking
{
    public class Reader
    {
        string mypath = "D:\\ДЗ С#\\hschool\\hschool_beggining_csh\\OOPLearning\\checking\\Scripts";
        private readonly string ConnectionString = "server=localhost;database=Scripts;uid=root;password=123qwe4r5t6YY;";
        //private readonly string SQL_CreateTable = @"create table if not exists TableScripts (
                                                   //  Id INT auto_increment not null, 
                                                   //  Name varchar(255) not null, 
                                                   //  primary key(id) 
                                                   //);";
        private readonly string SQL_selectItems = "select name from TableScripts;";
        private readonly string SQL_AddItem = "insert into TableScripts (name) values (@name1);";

        // метод, который считает все названия скриптов с базы данных
        public void Start()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(ConnectionString);
                connection.Open();

                //MySqlConnection connection = Connection();
                //MySqlCommand command = new MySqlCommand(SQL_AddDataBase, connection);
                //command.CommandText = SQL_UseDatabase;
                //command.CommandText = SQL_CreateTable;
                //connection.Close();
                //GetScriptsName();    // названия скриптов с БД
                //ListNames();     //названия файлов с папки
                CheckFileNames(ListNames(), GetScriptsName(connection), connection);
            }

            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }
        }
        private List<string> GetScriptsName(MySqlConnection connection)   // тянем  все названия скриптов с базы данных
        {
            //MySqlConnection connection = Connection();
            if (connection == null) throw new Exception("connection error");
            try
            {
                List<string> scripts = new List<string>();
                MySqlCommand command = new MySqlCommand(SQL_selectItems, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    scripts.Add(reader.GetString(0));
                }
                return scripts;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
            
        }
        // метод считывания названий файлов в папке
        private List<string> ListNames()
        {

            List<string> listAllFileNames = new List<string>();
            //listAllFileNames.AddRange(Directory.GetFiles(mypath, "*.sql", SearchOption.TopDirectoryOnly));
            string[] fileAll = Directory.GetFiles(mypath, "*.sql", SearchOption.TopDirectoryOnly);
            foreach (string str in fileAll)
            {
                listAllFileNames.Add(Path.GetFileName(str));                           // REPLACE****************************
                //Console.WriteLine(Path.GetFileName(str));
            }
            return listAllFileNames;
        }



        // метод, который сравнит названия,если нет его в списке,то вызывает метод считывания и его выполнение, затем добавление записи в базу данных
        private void CheckFileNames(List<string> files, List<string> lists, MySqlConnection connection)
        {
            foreach (var st in files)
            {
                if (!lists.Contains(st))
                {
                    //метод считывания файла с командами и отработка
                    readSQLFile(st,connection);
                    Console.WriteLine(st);

                    //метод добавления названия скрипта в БД
                    AddScriptInTable(st,connection);
                }
            }
        }
        //метод добавления записи в базу данных
        private void AddScriptInTable(string scr, MySqlConnection connection)
        {
            if (scr == null) throw new ArgumentNullException(nameof(scr));
            //MySqlConnection connection = Connection();
            if (connection == null) throw new Exception("Connection Error");
            try
            {
                MySqlCommand command = new MySqlCommand(SQL_AddItem, connection);
                command.Parameters.AddWithValue("@name1", scr);
                command.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
            //finally
            //{
            //    connection.Close();
            //}
        }
        // метод считывания файла(скрипта) с папки и далее выполнение всех команд
        private void readSQLFile(string fileDirectory, MySqlConnection connection)
        {
            //string[] result = File.ReadAllText($"{mypath}\\{fileDirectory}").Split(';');
            string result = File.ReadAllText($"{mypath}\\{fileDirectory}");


            //Console.WriteLine(res.Replace("\n", "") + ";");
            ProcessLoader(result,connection);

        }
        // метод выполнения команд со считанного файла
        private void ProcessLoader(string text, MySqlConnection connection)
        {
            if (text == null) throw new ArgumentNullException(nameof(text));
            //MySqlConnection connection = Connection();
            if (connection == null) throw new Exception("Connection Error");
            try
            {
                MySqlCommand command = new MySqlCommand(text, connection);
                command.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
            //finally
            //{
            //    connection.Close();
            //}
        }
        //private MySqlConnection Connection()
        //{
        //    try
        //    {
        //        MySqlConnection connection = new MySqlConnection(ConnectionString);
        //        connection.Open();
        //        return connection;
        //    }
        //    catch (MySqlException ex)
        //    {
        //        return null;
        //    }
        //}
       

    }

}
