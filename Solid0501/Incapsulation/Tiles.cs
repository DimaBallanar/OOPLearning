// Создать класс Tiles (кафель), который будет содержать свойства с открытым 
// доступом: Brand, SizeH, SizeW, Price, метод класса GetData() возвращающий 
// полную информацию о плитке и метод класса GetCountTiles() принимающий 
// площадь и возвращающий количество клиток необходимое для данной площади. 
// В главном методе объявить пару объектов класса и внести данные в поля. Затем 
// отобразить их, вызвав методы GetData() и GetCountTiles().

namespace Incapsulation;

public class Tiles
{
    public string Brand{get;set;}
    public double SizeH{get;set;}
    public double SizeW{get;set;}
    public double Price{get;set;}

    public Tiles(string brand, double sizeh, double sizew,double price)
    {
        Brand=brand;
        SizeH=sizeh;
        SizeW=sizew;
        Price=price;
    }
     public string GetData()
        {
            return $"brand: {Brand}  size: {SizeH}*{SizeW}   price {Price}";
        }

        public int GetCountTiles(double s)
        {
            
            return (int)Math.Ceiling(s/(SizeH*SizeW));
        }

}