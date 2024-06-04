using Application.Services;
using Core.DTO;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ProductsController(ProductServices productServices) : BaseController
{
	[HttpGet("{id}")]
	public async Task<ActionResult<Produtc>> GetProductById(int id)
	{
		try
		{
			return Ok(await productServices.GetProductByIdAsync(id));

		}
		catch (Exception e)
		{
			return NotFound(RetornarModelNotFound(e));
		}
	}
	
	[HttpGet]
	public async Task<ActionResult<IEnumerable<Produtc>>> GetAll()
	{
		try
		{
			return Ok(await productServices.GetAllProductsAsync());
		}
		catch (Exception e)
		{
			return NotFound(RetornarModelNotFound(e));
		}
	}

	
	[HttpPost]
	public async Task<ActionResult<Produtc>> AddProduct(ProductDTO produto)
	{
		try
		{
			await productServices.AddProductAsync(produto);
			return Created("", produto);
		}
		catch (Exception e)
		{
			return BadRequest(RetornarModelBadRequest(e));
		}
	}
	
	[HttpPut ("{id}")]
	public async Task<ActionResult<Produtc>> UpdateProduct(int id, ProductDTO produto)
	{
		try
		{
			await productServices.UpdateProductAsync(id, produto);
			return Ok(produto);
		}
		catch (Exception e)
		{
			return BadRequest(RetornarModelBadRequest(e));
		}
	}
	
	
	[HttpDelete ("{id}")]
	public async Task<ActionResult> DeleteProduct(int id)
	{
		try
		{
			await productServices.DeleteProductAsync(id);
			return NoContent();
		}
		catch (Exception e)
		{
			return BadRequest(RetornarModelBadRequest(e));
		}
	}
}