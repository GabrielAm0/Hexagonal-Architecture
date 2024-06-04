using AutoMapper;
using Core.DTO;
using Core.Interfaces;
using Core.Models;

namespace Application.Services;

public class ProductServices(IProductRepository productRepository, IMapper mapper)
{
	public async Task<Produtc> GetProductByIdAsync(int id)
	{
		return await productRepository.GetByIdAsync(id);
	}
	public async Task<IEnumerable<Produtc>> GetAllProductsAsync()
	{
		return await productRepository.GetAllAsync();
	}

	public async Task AddProductAsync(ProductDTO product)
	{
		var produto = mapper.Map<Produtc>(product);

		await productRepository.AddAsync(produto);
	}

	public async Task UpdateProductAsync(int id, ProductDTO product)
	{
		await productRepository.UpdateAsync(id, product);
	}

	public async Task DeleteProductAsync(int id)
	{
		await productRepository.DeleteAsync(id);
	}
}