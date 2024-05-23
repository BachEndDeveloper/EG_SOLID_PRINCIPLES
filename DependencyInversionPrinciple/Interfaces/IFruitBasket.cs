namespace DependencyInversionPrinciple.Interfaces;

public interface IFruitBasket
{
    public void AddFruit(IFruit fruit);
    public List<IFruit> Fruits { get; }
}