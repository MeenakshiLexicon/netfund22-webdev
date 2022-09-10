using _00_Web_Kenkata.Models;
using _00_WebShop_Kenkata.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _00_WebShop_Kenkata.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }






        public IActionResult Index()
        {
            ViewData["Title"] = "Shopping is more fun";

            var viewModel = new HomeIndexViewModel()
            {
                ShopByCategory = new ShopByCategorySectionModel()
                {
                    SectionTitle = new SectionTitleModel { Title = "SHOP BY", SpanTitle = "CATEGORY", Text = "We always try to give you the best product within a fast and reliable way" },
                    Categories = new List<CategoryModel>()
                    {
                        new CategoryModel { CategoryName = "Men", AmountOfProducts = 350 },
                        new CategoryModel { CategoryName = "Women", AmountOfProducts = 2500 },
                        new CategoryModel { CategoryName = "Kids", AmountOfProducts = 1000 },
                        new CategoryModel { CategoryName = "Shoes", AmountOfProducts = 3000 },
                        new CategoryModel { CategoryName = "Hats", AmountOfProducts = 100 },
                        new CategoryModel { CategoryName = "Sunglasses", AmountOfProducts = 200 },
                        new CategoryModel { CategoryName = "Watches", AmountOfProducts = 100 }
                    }
                },

                NewArrivals = new ProductCardSectionModel()
                {
                    SectionTitle = new SectionTitleModel { Title = "NEW", SpanTitle = "ARRIVALS", Text = "Check out our latest products from top fashion designers" },
                    Products = new List<ProductCardModel>()
                    {
                        new ProductCardModel{
                            ProductName = "Blue silk flare sleeved top",
                            CategoryName = "Fashion",
                            ImageName = "placeholder-male-body.png",
                            OriginalPrice = 50,
                            DiscountPrice = 20,
                            Rating = 3,
                            InStock = true
                        },
                        new ProductCardModel
                        {
                            ProductName = "New look men's coat",
                            CategoryName = "Fashion",
                            ImageName = "placeholder-male-chest.png",
                            OriginalPrice = 64,
                            DiscountPrice = 56,
                            Rating = 4,
                            InStock = true
                        },
                        new ProductCardModel
                        {
                            ProductName = "New look women's coat",
                            CategoryName = "Fashion",
                            ImageName = "placeholder-female-body.png",
                            OriginalPrice = 35,
                            DiscountPrice = 15,
                            Rating = 5,
                            InStock = true
                        },
                        new ProductCardModel
                        {
                            ProductName = "Circle pattern girls shirt",
                            CategoryName = "Fashion",
                            ImageName = "placeholder-female-body.png",
                            OriginalPrice = 150,
                            DiscountPrice = 99,
                            Rating = 4,
                            InStock = false
                        }
                    }
                },

                FeaturedProducts = new ProductCardSectionModel()
                {
                    SectionTitle = new SectionTitleModel { Title = "FEATURED", SpanTitle = "PRODUCTS", Text = "Check out our monthly featured products from top brands" },
                    Products = new List<ProductCardModel>()
                    {
                                                new ProductCardModel{
                            ProductName = "Blue silk flare sleeved top",
                            CategoryName = "Fashion",
                            ImageName = "placeholder-male-body.png",
                            OriginalPrice = 50,
                            DiscountPrice = 20,
                            Rating = 3,
                            InStock = true
                        },
                        new ProductCardModel
                        {
                            ProductName = "New look men's coat",
                            CategoryName = "Fashion",
                            ImageName = "placeholder-male-chest.png",
                            OriginalPrice = 64,
                            DiscountPrice = 56,
                            Rating = 4,
                            InStock = true
                        },
                        new ProductCardModel
                        {
                            ProductName = "New look women's coat",
                            CategoryName = "Fashion",
                            ImageName = "placeholder-female-body.png",
                            OriginalPrice = 35,
                            DiscountPrice = 15,
                            Rating = 5,
                            InStock = true
                        },
                        new ProductCardModel
                        {
                            ProductName = "Circle pattern girls shirt",
                            CategoryName = "Fashion",
                            ImageName = "placeholder-female-body.png",
                            OriginalPrice = 150,
                            DiscountPrice = 99,
                            Rating = 4,
                            InStock = false
                        }
                    }
                }
            };

            return View(viewModel);
        }















        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}