using DependencyInversionPrinciple.Interfaces;

namespace DependencyInversionPrinciple.Implementation
{
    public class FruitBasket
    {
        private List<IFruit> fruits = new();
        
        public void AddFruit(IFruit fruit)
        {
            this.fruits.Add(fruit);
        }
        
        public List<IFruit> WhatsInMyBasket => fruits;
    }
}