using ManagerProduct.Application.DTOs;

namespace ManagerProduct.Application.Interfaces;
public interface IProductService
{
    Task<IEnumerable<ProductDTO>> GetAllAsync();
    Task<ProductDTO> GetByIdAsync(int id);

    Task<ProductDTO> GetProductCategoryAsync(int id);
    Task AddAsync(ProductDTO productDto);
    Task UpdateAsync(ProductDTO productDto);
    Task DeleteAsync(int id);
}