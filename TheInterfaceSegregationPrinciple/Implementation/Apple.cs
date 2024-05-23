using DependencyInversionPrinciple.Interfaces;

public class Apple(string color = "Green") : IFruit
{
    public string Name { get; } = nameof(Apple);
    public string Color { get; set; } = color;
}