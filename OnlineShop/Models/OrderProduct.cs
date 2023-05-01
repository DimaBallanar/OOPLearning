namespace OnlineShop.Models
{
    public class OrderProduct
    {
        public int Id { get; set; }
        public int Id_User { get; set; }
        public int Id_Product { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }
        public int Discount { get; set; }
    }
}
