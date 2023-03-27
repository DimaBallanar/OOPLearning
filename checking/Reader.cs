using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MySqlConnection = MySqlConnector.MySqlConnection;
using MySqlException = MySqlConnector.MySqlException;

namespace checking
{
    public class Reader
    {
        private readonly string ConnectionString = "server=localhost;database=studies;uid=root;password=123qwe4r5t6YY;";
        private readonly string SQL_AddDataBase = "create database if not exists Scripts;";
        private readonly string SQL_UseDatabase= "use Scripts;";
        private readonly string SQL_CreateTable= "create table if not exists TableScripts (\r\n Id INT auto_increment not null,\r\n Name varchar(55) not null,\r\n primary key(id)\r\n );";


        public void ChekerScript(string path, string fileChecker)
        {
            List<string> list = new List<string>();
            //Directory.GetFiles(mypath, "*.txt", SearchOption.TopDirectoryOnly).ToList().ForEach(f => Console.WriteLine(Path.GetFileName(f)));
            string[] allfiles = Directory.GetFiles(path, "*.txt", SearchOption.TopDirectoryOnly);
            foreach (string filename in allfiles)
            {
                list.Add(Path.GetFileName(filename));
                
            }
            string[] listec = File.ReadAllLines(fileChecker);
            foreach (string line in listec)
            {
                if (!list.Contains(line))
                {
                    //запуск этого скрипта к выполнению
                    //добавление названия скрипта в файл со списком скриптов Files.txt
                   // File.AppendAllText(fileChecker, line);                                // открывает наш файл, добавляет в него строку

                }

            }
        }
            public void LoaderApp(string str)
        {
            List<string> list = new List<string>();            
            string[] allfiles = Directory.GetFiles(str, "*.txt", SearchOption.TopDirectoryOnly);
            foreach (string filename in allfiles)
            {
                list.Add(Path.GetFileName(filename));
                Process.Start(filename);
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
