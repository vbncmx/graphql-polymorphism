namespace GraphQL.Polymorphism.Models;

public class Pudel : IDog
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Weight { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int ExhibitionAttendedCount { get; set; }
}