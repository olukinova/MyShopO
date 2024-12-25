﻿namespace MyShop.Models
{
    public class Goods
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string producer { get; set; }
        public int price { get; set; }

        // should be changed to one to one?
        public int ProducersId { get; set; }
        public Producers Producer { get; set; }

        public List<Orders> Orders { get; set; }
        
    }
}
