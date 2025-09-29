
using ManagerProduct.Application.DTOs;

namespace ManagerProduct.Application.Interfaces;
public interface ICategoryService
{
    Task<IEnumerable<CategoryDTO>> GetAllAsync();
    Task<CategoryDTO> GetByIdAsync(int? id);
    Task AddAsync(CategoryDTO categoryDto);
    Task UpdateAsync(CategoryDTO categoryDto);
    Task DeleteAsync(int? id);
}