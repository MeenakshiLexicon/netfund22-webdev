namespace WebApplication5.Controllers.Models.Repositories
{
    internal interface IProductRepository
    {
        public void Create(Product product);
        public Product Read(int id);
        public IEnumerable<Product> Read();
        public void Update(int id, Product updatedProduct);
        public void Delete(int id);
    }

    internal class ProductRepository : IProductRepository
    {
        private List<Product> _products;

        public ProductRepository()
        {
            _products = new List<Product>();
        }

        public void Create(Product product)
        {
            product.Id = _products.Count + 1;
            _products.Add(product);
        }

        public void Delete(int id)
        {
            _products = _products.Where(x => x.Id != id).ToList();
        }

        public Product Read(int id)
        {
            return _products.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Product> Read()
        {
            return _products;
        }

        public void Update(int id, Product updatedProduct)
        {
            var _product = _products.FirstOrDefault(x => x.Id == id);
            if (_product != null)
            {
                _product.Name = updatedProduct.Name;
                _product.Price = updatedProduct.Price;

                _products = _products.Where(x => x.Id != _product.Id).ToList();
                _products.Add(_product);
                _products = _products.OrderBy(p => p.Id).ToList();
            }
        }
    }
}
