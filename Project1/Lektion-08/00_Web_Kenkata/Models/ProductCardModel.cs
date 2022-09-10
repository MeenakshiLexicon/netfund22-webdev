namespace _00_Web_Kenkata.Models
{
    public class ProductCardModel
    {
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string ImageName { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal DiscountPrice { get; set; }
        public int Rating { get; set; }
        public bool InStock { get; set; }
    }
}
