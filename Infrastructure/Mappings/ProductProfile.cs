using AutoMapper;
using Core.DTO;
using Core.Models;

namespace Infrastructure.Mappings;

public class ProductProfile : Profile
{
	public ProductProfile()
	{
		CreateMap<Produtc, ProductDTO>().ReverseMap();
	}
}