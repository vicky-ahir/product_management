using Product_Management_System.Models.Admin;

namespace Product_Management_System.Repository.Admin
{
    public interface IProductRepository
    {
        Task<bool> AddProductDetails(Product product);

        Task<IEnumerable<Product>> GetAllProduct();

        Task<Product> GetProductById(int Id);

        Task<bool> EditProductDetails(Product product);

        Task<bool> DeleteProductDetails(int product_Id);
    }
}
