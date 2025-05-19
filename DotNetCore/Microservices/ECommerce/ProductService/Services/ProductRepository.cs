using ProductService.Models;

namespace ProductService.Services
{
    public interface IProductRepository
    {
        // Define methods for product-related operations here
        Task<Product> GetProductByIdAsync(int productId);
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(int productId);
    }
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new List<Product>();
        public Task<Product> GetProductByIdAsync(int productId)
        {
            var product = _products.FirstOrDefault(p => p.Id == productId);
            return Task.FromResult(product);
        }
        public Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return Task.FromResult<IEnumerable<Product>>(_products);
        }
        public Task AddProductAsync(Product product)
        {
            _products.Add(product);
            return Task.CompletedTask;
        }
        public Task UpdateProductAsync(Product product)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
                existingProduct.Description = product.Description;
            }
            return Task.CompletedTask;
        }
        public Task DeleteProductAsync(int productId)
        {
            var product = _products.FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                _products.Remove(product);
            }
            return Task.CompletedTask;
        }
    }
}
