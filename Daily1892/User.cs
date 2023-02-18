using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily1892
{
    public class User
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Phone { get; set; }

        public User(string name, int id, string phone) => (Id, Name,  Phone) = (id, name, phone);
        //{
        //    Name = name;
        //    Id = id;
        //    Phone = phone;
        //}

    }

}
