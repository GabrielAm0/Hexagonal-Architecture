using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models;

public class Produtc
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public required int Id { get; set; }
	public required string Name { get; set; }
	public required decimal Price { get; set; }
}