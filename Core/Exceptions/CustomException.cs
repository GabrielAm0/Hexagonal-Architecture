namespace Core.Exceptions;

public class  CustomException : Exception
{
	public int StatusCode { get; set; }
	public string Title { get;  set; } = "Error";
	public new string Message { get;  set; } = "An error occurred";
	public DateTime Date { get;  set;  }
}