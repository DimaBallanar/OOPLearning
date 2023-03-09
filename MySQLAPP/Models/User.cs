using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLAPP.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime LastLogin { get; set; }
        public double Money { get; set; }

        public override string ToString()
        {
            return $"id: {Id} Имя: {Name}  Пароль: {Password}  Мыло: {Email}  Последний логин: {LastLogin}  баланс: {Money} евро";
        }

    }
}
