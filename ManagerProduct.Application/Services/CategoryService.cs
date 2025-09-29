using AutoMapper;
using System.Collections.Generic;
using ManagerProduct.Application.DTOs;
using ManagerProduct.Domain.Entities;
using ManagerProduct.Domain.Interfaces;
using ManagerProduct.Application.Interfaces;

namespace ManagerProduct.Application.Services;

public class CategoryService : ICategoryService
{
    private ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;
    public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<CategoryDTO>> GetAllAsync()
    {
        var categoriesEntity = await _categoryRepository.GetAllAsync();
        return _mapper.Map<IEnumerable<CategoryDTO>>(categoriesEntity);
    }

    public async Task<CategoryDTO> GetByIdAsync(int? id)
    {
        var categoryEntity = await _categoryRepository.GetByIdAsync(id);
        return _mapper.Map<CategoryDTO>(categoryEntity);
    }

    public async Task AddAsync(CategoryDTO categoryDto)
    {
        var categoryEntity = _mapper.Map<Category>(categoryDto);
        await _categoryRepository.AddAsync(categoryEntity);
    }

    public async Task UpdateAsync(CategoryDTO categoryDto)
    {
        var categoryEntity = _mapper.Map<Category>(categoryDto);
        await _categoryRepository.UpdateAsync(categoryEntity);
    }

    public async Task DeleteAsync(int? id)
    {
        var categoryEntity = _categoryRepository.GetByIdAsync(id).Result;
        await _categoryRepository.DeleteAsync(categoryEntity);
    }
}