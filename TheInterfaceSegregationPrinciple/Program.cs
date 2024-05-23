
using DependencyInversionPrinciple.Implementation;
using DependencyInversionPrinciple.Interfaces;
using System.Text.Json;

Console.WriteLine("Hello, World!");

IFruitBasket basket = new FruitBasket();
basket.AddFruit(new Orange("Orange"));
basket.AddFruit(new Apple("Red"));
basket.AddFruit(new Apple("Yellow"));
basket.AddFruit(new Apple("Green"));
basket.AddFruit(new Apple("Orange"));


Console.WriteLine(JsonSerializer.Serialize(basket.Fruits));