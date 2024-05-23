using DependencyInversionPrinciple.Interfaces;

namespace DependencyInversionPrinciple.Implementation;

public class FruitBasket2 : IFruitBasket
{
    private List<IFruit> fruits = new();

    public void AddFruit(IFruit fruit)
    {
        Console.WriteLine("Added new fruit to basket");
        fruits.Add(fruit);
    }

    public List<IFruit> Fruits => fruits;
}