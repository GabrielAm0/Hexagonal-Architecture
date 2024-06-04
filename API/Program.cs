using Application.Services;
using AutoMapper;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Mappings;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

ConfigurarServices(builder);

ConfigurarInjecaoDeDependencia(builder);

var app = builder.Build();

ConfigurarAplicacao(app);

app.Run();

static void ConfigurarInjecaoDeDependencia(WebApplicationBuilder builder)
{
	//Configura DbContext
	builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Transient, ServiceLifetime.Transient);

	var config = new MapperConfiguration(cfg =>
	{
		// Adicionar os profiles aquí
		cfg.AddProfile<ProductProfile>();
	});

	//Adiciona repositório e serviços
	builder.Services.AddScoped<IProductRepository, ProductRepository>()
		   .AddScoped<ProductServices>()
		   .AddSingleton(config.CreateMapper());
}

static void ConfigurarServices(WebApplicationBuilder builder)
{
	builder.Services.AddCors()
					.AddEndpointsApiExplorer()
					.AddControllers()
					.AddNewtonsoftJson(options =>
					{
						options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
						options.SerializerSettings.DefaultValueHandling = DefaultValueHandling.Ignore;
					});


	builder.Services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo { Title = "Hexagonal.Api", Version = "v1" }); });


}

static void ConfigurarAplicacao(WebApplication app)
{
	app.UseDeveloperExceptionPage()
	   .UseRouting();

	if (app.Environment.IsDevelopment())
	{
		app.UseSwagger()
		   .UseSwaggerUI(c =>
		   {
			   c.SwaggerEndpoint("/swagger/v1/swagger.json", "Hexagonal.Api v1");
		   });
	}
	
	app.UseCors(x => x
	   .AllowAnyOrigin() // Permite todas as origens
	   .AllowAnyMethod() // Permite todos os métodos
	   .AllowAnyHeader()); // Permite todos os cabeçalhos
	
	app.MapControllers(); 
}







