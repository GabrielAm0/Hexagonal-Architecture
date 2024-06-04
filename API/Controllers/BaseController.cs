using Core.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class BaseController : ControllerBase
{
	protected CustomException RetornarModelBadRequest(Exception e)
	{
		return new CustomException()
		{
		StatusCode = 400,
		Title = "Bad Request",
		Message = e.Message,
		Date = DateTime.Now
		};
	}
	
	protected CustomException RetornarModelNotFound(Exception e)
	{
		return new CustomException
		{
		StatusCode = 404,
		Title = "Not Found",
		Message = e.Message,
		Date = DateTime.Now
		};
	}
}