using DotNetCoreWebAPI.Models;
using DotNetCoreWebAPI.Repositories;

namespace DotNetCoreWebAPI.Services
{
    public interface IProductService
    {
        public IEnumerable<Product> GetProducts();
        public Product GetProductById(int id);
        public string CreateProduct(Product product);
        public string UpdateProduct(int id, Product product);
        public string DeleteProduct(int id);
    }

    public class ProductService : IProductService
    {

        private readonly DotNetCoreWebAPIDBContext _dbContext;

        public ProductService(DotNetCoreWebAPIDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string CreateProduct(Product product)
        {
            _dbContext.Products.Add(product); // Add the product to the database
            _dbContext.SaveChanges(); // Save changes to persist the product
            return "Product created successfully";
        }

        public string DeleteProduct(int id)
        {
            var product = _dbContext.Products.Find(id);
            if (product == null)
            {
                return "Product not found";
            }

            _dbContext.Products.Remove(product);
            _dbContext.SaveChanges();
            return "Product deleted successfully";
        }


        public Product GetProductById(int id)
        {
            return _dbContext.Products.Find(id) ?? new Product
            {
                Id = id,
                Name = "Sample Product",
                Price = 19.99m,
                Description = "This is a sample product.",
                Category = "Sample Category",
                ImageUrl = "https://example.com/sample.jpg"
            };
        }

        public IEnumerable<Product> GetProducts()
        {
            return _dbContext.Products.ToList();
        }

        public string UpdateProduct(int id, Product product)
        {
            var existingProduct = _dbContext.Products.Find(id);
            if (existingProduct == null)
            {
                return "Product not found";
            }

            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            existingProduct.Description = product.Description;
            existingProduct.Category = product.Category;
            existingProduct.ImageUrl = product.ImageUrl;

            _dbContext.SaveChanges();
            return "Product updated successfully";
        }
    }
}
