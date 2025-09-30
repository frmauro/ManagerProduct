using AutoMapper;
using ManagerProduct.Application.DTOs;
using ManagerProduct.Application.Interfaces;
using ManagerProduct.Domain.Entities;
using ManagerProduct.Domain.Interfaces;

namespace ManagerProduct.Application.Services;

public class ProductService : IProductService
{
    private IProductRepository _productRepository;

    private readonly IMapper _mapper;
    public ProductService(IMapper mapper, IProductRepository productRepository)
    {
        _productRepository = productRepository ??
             throw new ArgumentNullException(nameof(productRepository));

        _mapper = mapper;
    }

    public async Task<IEnumerable<ProductDTO>> GetAllAsync()
    {
        var productsEntity = await _productRepository.GetAllAsync();
        return _mapper.Map<IEnumerable<ProductDTO>>(productsEntity);
    }

    public async Task<ProductDTO> GetByIdAsync(int id)
    {
        var productEntity = await _productRepository.GetByIdAsync(id);
        return _mapper.Map<ProductDTO>(productEntity);
    }

    public async Task<ProductDTO> GetProductCategoryAsync(int id)
    {
        var productEntity = await _productRepository.GetProductCategoryAsync(id);
        return _mapper.Map<ProductDTO>(productEntity);
    }

    public async Task AddAsync(ProductDTO productDto)
    {
        var productEntity = _mapper.Map<Product>(productDto);
        await _productRepository.AddAsync(productEntity);
    }

    public async Task UpdateAsync(ProductDTO productDto)
    {

        var productEntity = _mapper.Map<Product>(productDto);
        await _productRepository.UpdateAsync(productEntity);
    }

    public async Task DeleteAsync(int id)
    {
        var productEntity = _productRepository.GetByIdAsync(id).Result;
        await _productRepository.DeleteAsync(productEntity);
    }
}