using _00_WebShop_Kenkata.Models;

namespace _00_Web_Kenkata.Models
{
    public class ShopByCategorySectionModel
    {
        public SectionTitleModel SectionTitle { get; set; }
        public List<CategoryModel> Categories { get; set; }
    }
}
