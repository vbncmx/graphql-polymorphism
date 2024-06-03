namespace GraphQL.Polymorphism.Models;

[UnionType("Dog")]
public interface IDog
{
    int Id { get; set; }
    string? Name { get; set; }
    int Weight { get; set; }
    DateTime DateOfBirth { get; set; }
}