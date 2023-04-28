﻿using MySql.Data.MySqlClient;
using OnlineShop.Models;
using System.Reflection.PortableExecutable;

namespace OnlineShop.Repository
{
    public class UserRepository
    {
        private readonly MySqlConnection m_Connection;
        private readonly string SQL_SELECT_GET_ALL = "Select id,name,surname,email,password from studaki";
        private readonly string SQL_PUT_ITEM="insert into studaki(name,surname,email,password) values (@name, @surname, @email, @password)";
        private readonly string SQL_UPDATE_USER = "UPDATE studaki Set name=@name, surname=@surname, email=@email,password=@password where Id={0}";
        private readonly string SQL_DELETE_USER = "delete from studaki where Id=@id;";

        public UserRepository(MySqlConnection connection)
        {
            m_Connection = connection;
        }

        public List<User> GetAll()
        {
            try
            {
                m_Connection.Open();
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_GET_ALL, m_Connection);
                List<User> users = new List<User>();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    users.Add(new User()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Surname = reader.GetString(2),
                        Email = reader.GetString(3),
                        Password = reader.GetString(4)
                    });
                }
                return users;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        public List<User> GetAll(int id)
        {
            try
            {
                m_Connection.Open();
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_GET_ALL, m_Connection);
                List<User> users = new List<User>();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id)
                    {
                        users.Add(new User()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Surname = reader.GetString(2),
                            Email = reader.GetString(3),
                            Password = reader.GetString(4)
                        });
                    }
                }
                return users;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public int Put(User user)
        {
            try
            {
                m_Connection.Open();
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_GET_ALL, m_Connection);               
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetString(3) != user.Email)
                    {
                        m_Connection.Close();
                        User user1 = new User();
                        m_Connection.Open();
                        MySqlCommand command=new MySqlCommand(SQL_PUT_ITEM, m_Connection);
                        //MySqlCommand command = m_Connection.CreateCommand();
                        //command.CommandText = SQL_PUT_ITEM;
                        command.Parameters.AddWithValue("@name", user.Name);
                        command.Parameters.AddWithValue("@surname", user.Surname);
                        command.Parameters.AddWithValue("@email", user.Email);
                        command.Parameters.AddWithValue("@password", user.Password);
                        
                        //cmd.ExecuteNonQuery();
                        command.ExecuteNonQuery();
                        return (int)command.LastInsertedId;
                    }
                    
                }
                return -1;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public List<User> Update(User user)
        {
            try
            {
                m_Connection.Open();
                MySqlCommand cmd = new MySqlCommand(string.Join(SQL_UPDATE_USER,user.Id), m_Connection);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@surname", user.Surname);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.ExecuteNonQuery();
                m_Connection.Close();
                List<User> users = GetAll();
                return users;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public List<User> Delete(int code)
        {
            try
            {
                m_Connection.Open();
               
                MySqlCommand command = new MySqlCommand(SQL_DELETE_USER, m_Connection);
                command.Parameters.AddWithValue("@id", code);
                command.ExecuteNonQuery();
                m_Connection.Close();
                List<User> users = GetAll();
                return users;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }           
        }
    }
}