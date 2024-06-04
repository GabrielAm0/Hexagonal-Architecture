using Core.DTO;
using Core.Interfaces;
using Core.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class ProductRepository(AppDbContext context) : IProductRepository
{
    public async Task<Produtc> GetByIdAsync(int id)
    {
        try
        {
            return await context.Products.AsNoTracking().Where(p => p.Id == id).FirstOrDefaultAsync() ?? throw new Exception($"Nenhum produto encontrado com o id {id}");
        }
        catch (Exception e)
        {
            throw new Exception($"Nenhum produto encontrado com o id {id}", e);
        }
    }

    public async Task<IEnumerable<Produtc>> GetAllAsync()
    {
        try
        {
            var products = await context.Products.AsNoTracking().OrderBy(p => p.Id).ToListAsync();
            if(!products.Any())
            {
                throw new Exception("Nenhum produto encontrado");
            }

            return products;
        }
        catch (Exception e)
        {
            throw new Exception($"Erro ao buscar produtos", e);
        }
    }

    public async Task AddAsync(Produtc product)
    {
        try
        {
            await context.Products.AddAsync(product);
            await context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            throw new Exception("Erro ao adicionar produto.", e);
        }
    }

    public async Task UpdateAsync(int id, ProductDTO product)
    {
        try
        {
            Produtc entity = await context.Products.Where(p => p.Id == id).FirstOrDefaultAsync() ?? throw new InvalidOperationException("Produto não encontrado com o Id fornecido.");

            context.Entry(entity).CurrentValues.SetValues(product);
            
            await context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public async Task DeleteAsync(int id)
    {
        try
        {
            var entity = await context.Products.FirstOrDefaultAsync(p => p.Id == id) ?? throw new InvalidOperationException("Produto não encontrado com o Id fornecido.");
            
            context.Products.Remove(entity);
            await context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            throw new Exception($"Erro ao deletar produto com o id {id}", e);
        }
    }
}
