using DependencyInversionPrinciple.Implementation;
using DependencyInversionPrinciple.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/getapples", () =>
    {
        var basket = new FruitBasket();
        basket.AddFruit(new Apple());
        basket.AddFruit(new Apple("Red"));
        basket.AddFruit(new Apple("Yellow"));
        basket.AddFruit(new Apple("Green"));
        basket.AddFruit(new Apple("Orange"));
        return Results.Ok(basket.WhatsInMyBasket);
    })
    .WithName("Apples")
    .WithOpenApi();

app.Run();
