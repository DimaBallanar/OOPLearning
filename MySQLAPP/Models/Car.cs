using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLAPP.Models
{
    public  class Car
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string TimeCreate { get; set; }
        public string Type { get; set; }
        public double Mileage { get; set; }

        public override string ToString()
        {
            return $"код: {Code} Название: {Name}  Цвет: {Color}  Дата: {TimeCreate}  Тип кузова: {Type}  Пробег: {Mileage} миль";
        }

    }
}
