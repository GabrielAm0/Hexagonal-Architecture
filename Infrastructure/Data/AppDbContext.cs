using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class AppDbContext : DbContext
{
	public DbSet<Produtc> Products { get; set; }

	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
	

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Produtc>(entity =>
		{
			entity.ToTable("Produtc");
			entity.HasKey(produtc => produtc.Id);
			entity.Property(produtc => produtc.Name).HasColumnType("VARCHAR").IsRequired();
			entity.Property(produtc => produtc.Price).HasColumnType("double precision").IsRequired();
		});
	}
}