namespace MiniSuperMarket.Models
{
    public class Product
    {
        public int Pid { get; set; }
        public string  Pname { get; set; }
        public PCategory ProductCategory { get; set; }
        public string  ProductDescription { get; set; }
        public int price { get; set; }
        public string Pimage { get; set; }
    }

    public enum PCategory
    {
        Electronics = 1,
        Clothing = 2,
        Groceries = 3,
        HomeAppliances = 4,
        Books = 5,
        Toys = 6,
        Sports = 7,
        HealthAndBeauty = 8,
        Automotive = 9,
        Furniture = 10
    }
}
