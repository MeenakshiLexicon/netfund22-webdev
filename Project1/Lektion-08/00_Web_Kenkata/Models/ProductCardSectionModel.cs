using _00_WebShop_Kenkata.Models;

namespace _00_Web_Kenkata.Models
{
    public class ProductCardSectionModel
    {
        public SectionTitleModel SectionTitle { get; set; }
        public List<ProductCardModel> Products { get; set; }
    }
}
