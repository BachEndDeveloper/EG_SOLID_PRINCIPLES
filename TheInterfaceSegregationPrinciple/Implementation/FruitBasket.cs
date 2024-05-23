using DependencyInversionPrinciple.Interfaces;

namespace DependencyInversionPrinciple.Implementation;

public class FruitBasket : IFruitBasket
{
    private List<IFruit> fruits = new();

    public void AddFruit(IFruit fruit)
    {
        fruits.Add(fruit);
    }

    public List<IFruit> Fruits => fruits;
}