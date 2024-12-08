namespace MyShop.Models
{
    public class Orders
    {
        public int id { get; set; }
        public List<Goods> goods { get; set; }
        public string status { get; set; }
    }
}
