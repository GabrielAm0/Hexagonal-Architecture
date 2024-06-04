using Core.DTO;
using Core.Models;

namespace Core.Interfaces;

public interface IProductRepository
{
	Task<Produtc> GetByIdAsync(int id);
	Task<IEnumerable<Produtc>> GetAllAsync();
	Task AddAsync(Produtc product);
	Task UpdateAsync(int id, ProductDTO product);
	Task DeleteAsync(int id);
}