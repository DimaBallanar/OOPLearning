﻿using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
//using MySQLAPP.Models;
using System;
using System.Collections;
using System.Collections.Generic;
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
        private readonly string ConnectionString = "server=localhost;database=studies;uid=root;password=123qwe4r5t6YY;";
        private readonly string SQL_AddDataBase = "create database if not exists Scripts;";
        private readonly string SQL_UseDatabase= "use Scripts;";
        private readonly string SQL_CreateTable= "create table if not exists TableScripts (\r\n Id INT auto_increment not null,\r\n Name varchar(255) not null,\r\n primary key(id)\r\n );";
        private readonly string SQL_selectItems = "select name from TableScripts;";
        private readonly string SQL_AddItem = "insert into TableScripts (name) values (@name1);";

        // метод, который считает все названия скриптов с базы данных
        public List<string> GetScriptsName()
        {
            MySqlConnection connection = Connection();
            if (connection == null) throw new Exception("connection error");
            try
            {
                List<string> scripts = new List<string>();
                MySqlCommand command = new MySqlCommand(SQL_selectItems, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {                                    
                     scripts.Add( reader.GetString(0));                   
                }
                return scripts;
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
        // метод считывания названий файлов в папке
        public List<string> ListNames()
        {
            string mypath = "D:\\ДЗ С#\\hschool\\hschool_beggining_csh\\OOPLearning\\checking\\Scripts";
            List<string> listAllFileNames = new List<string>();
            listAllFileNames.AddRange(Directory.GetFiles(mypath, "*.sql", SearchOption.TopDirectoryOnly));
            return listAllFileNames;
        }

        

        // метод, который сравнит названия,если нет его в списке,то вызывает метод считывания и его выполнение, затем добавление записи в базу данных

        //метод добавления записи в базу данных
        void AddScriptInTable(string scr)
        {
            if (scr == null) throw new ArgumentNullException(nameof(scr));
            MySqlConnection connection = Connection();
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
            finally
            {
                connection.Close();
            }
        }



        static void ChekerScript(string path, string fileChecker)
        {
            List<string> list = new List<string>();
            //Directory.GetFiles(mypath, "*.txt", SearchOption.TopDirectoryOnly).ToList().ForEach(f => Console.WriteLine(Path.GetFileName(f)));
            string[] allfiles = Directory.GetFiles(path, "*.sql", SearchOption.TopDirectoryOnly);
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
