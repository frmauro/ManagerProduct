using AutoMapper;
using ManagerProduct.Application.DTOs;
using ManagerProduct.Domain.Entities;

namespace ManagerProduct.Application.Mappings;
public class DomainToDTOMappingProfile : Profile
{
    public DomainToDTOMappingProfile()
    {
        CreateMap<Product, ProductDTO>().ReverseMap();
        CreateMap<Category, CategoryDTO>().ReverseMap();
    }
}