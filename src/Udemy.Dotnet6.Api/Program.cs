using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
//Service configuration
builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();
var configuration = app.Configuration;
ProductRepository.Init(configuration);

app.MapGet("/products", ([FromQuery] string dateStart, [FromQuery] string dateEnd) =>
{
    var products = ProductRepository.GetAll();
    return products != null ? Results.Ok(products) : Results.NotFound();
});

app.MapGet("/products/{code}", ([FromRoute] string code) =>
{
    var product = ProductRepository.GetByCode(code);
    return product != null ? Results.Ok(product) : Results.NotFound();
});

app.MapPost("/products", (Product product) =>
{
    ProductRepository.Add(product);
    return Results.Created($"/products/{product.Code}", product.Code);
});

app.MapPut("/products", (Product product) =>
{
    var productToUpdaye = ProductRepository.GetByCode(product.Code);
    productToUpdaye.Name = product.Name;
    return Results.Ok();
});

app.MapDelete("/products/{code}", ([FromRoute] string code) =>
{
    var productToDelete = ProductRepository.GetByCode(code);
    ProductRepository.Delete(productToDelete);
    return Results.Ok();
});


app.Run();