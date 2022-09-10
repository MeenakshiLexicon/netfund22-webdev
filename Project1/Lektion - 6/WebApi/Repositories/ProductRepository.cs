namespace WebApi.Controllers.Repositories
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAll();
        public Product Get(int id);
        public Product Get(string name);
        public Product Create(string name, decimal price);
    }

    public class ProductRepository : IProductRepository
    {
        private List<Product> _products = new List<Product>();


        public Product Create(string name, decimal price)
        {
            var product = new Product
            {
                Id = _products.Count + 1,
                Name = name,
                Price = price
            };

            _products.Add(product);
            return product;
        }

        public Product Get(int id)
        {
            return _products.FirstOrDefault(x => x.Id == id);
        }

        public Product Get(string name)
        {
            return _products.FirstOrDefault(x => x.Name == name);
        }

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }
    }
}

