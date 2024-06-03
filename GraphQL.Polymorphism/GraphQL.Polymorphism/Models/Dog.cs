namespace GraphQL.Polymorphism.Models;

public abstract class Dog
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Weight { get; set; }
    public DateTime DateOfBirth { get; set; }
}