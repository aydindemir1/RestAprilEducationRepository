using RestAprilEducationRepository.Application.Products;
using RestAprilEducationRepository.Application.Products.GetList;
using RestAprilEducationRepository.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


// DI Container Framework ( Library ) -

// DI + IoC => DI - Dependency Injection Pattern

// Singleton
// Transient
// Scoped

// Transient => her seferinde yeni bir instance oluşturulur. ( stateless )
// Singleton => uygulama boyunca tek bir instance oluşturulur. ( stateful )
// Scoped => her istek için yeni bir instance oluşturulur. ( stateful )

// Transient >> Scoped > Singleton

//builder.Services.AddSingleton<CalculateService>();
builder.Services.AddSingleton<ICalculateService, CalculateService>();
builder.Services.AddScoped<IProductsApplication, ProductsApplication>();
builder.Services.AddScoped<IProductRepository, ProductRepositoryWithInMemory>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
