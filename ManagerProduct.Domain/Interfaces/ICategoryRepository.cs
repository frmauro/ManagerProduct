using ManagerProduct.Domain.Entities;

namespace ManagerProduct.Domain.Interfaces;
public interface ICategoryRepository
{
    Task<IEnumerable<Category>> GetAllAsync();
    Task<Category> GetByIdAsync(int? id);
    Task<Category> AddAsync(Category category);
    Task<Category> UpdateAsync(Category category);
    Task<Category> DeleteAsync(Category category);
}