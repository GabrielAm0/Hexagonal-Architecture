using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Data;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
	public AppDbContext CreateDbContext(string[] args)
	{
		var configuration = new ConfigurationBuilder().SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../API"))
													  .AddJsonFile("appsettings.json")
													  .Build();

		var connectionString = configuration.GetConnectionString("DefaultConnection");
		
		var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
		
		optionsBuilder.UseNpgsql(connectionString);

		return new AppDbContext(optionsBuilder.Options);
	}
}