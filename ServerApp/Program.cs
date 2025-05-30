var builder = WebApplication.CreateBuilder(args);

// 1. Add CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors();

app.MapGet("/api/productList", () =>

{

    return new[]

    {

        new { Id = 1, Name = "Laptop", Price = 1200.50, Stock = 25 },

        new { Id = 2, Name = "Headphones", Price = 50.00, Stock = 100 }

    };

});

app.Run();