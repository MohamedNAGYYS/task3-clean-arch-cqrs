using Task3.Domain.Entities;


namespace Task3.Application.Common.Interfaces
{
    public interface IProductRepository
    {
        Task<int> AddAsync(Product product);
        Task<Product?> GetByIdAsync(int id);
        Task<List<Product>> GetAllAsync();
    }
}