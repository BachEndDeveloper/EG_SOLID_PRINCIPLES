namespace TheInterfaceSegregationPrinciple.Interfaces;

public interface IMartinsSerialization
{
    public int CustomerNumber { get; set; }
    public string Serialize(object obj) => throw new NotImplementedException();
}