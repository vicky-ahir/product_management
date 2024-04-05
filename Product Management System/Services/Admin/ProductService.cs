using Product_Management_System.Models.Admin;
using Product_Management_System.Repository.Admin;

namespace Product_Management_System.Services.Admin
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<bool> AddProductDetails(Product product)
        {
            return await _productRepository.AddProductDetails(product);
        }

        public async Task<IEnumerable<Product>> GetAllProduct()
        {
            return await _productRepository.GetAllProduct();
        }

        public async Task<Product> GetProductById(int Id)
        {
            return await _productRepository.GetProductById(Id);
        }

        public async Task<bool> EditProductDetails(Product product)
        {
            return await _productRepository.EditProductDetails(product);
        }

        public async Task<bool> DeleteProductDetails(int product_Id)
        {
            return await _productRepository.DeleteProductDetails(product_Id);
        }

    }
}
