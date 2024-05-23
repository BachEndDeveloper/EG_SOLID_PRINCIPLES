using DependencyInversionPrinciple.Interfaces;

namespace DependencyInversionPrinciple.Implementation
{
    public class Orange(string color) : IFruit
    {
        public string Name { get; } = nameof(Orange);
        public string Color { get; set; } = color;
    }
}