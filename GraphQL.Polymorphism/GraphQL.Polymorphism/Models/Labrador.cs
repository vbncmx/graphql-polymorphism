﻿namespace GraphQL.Polymorphism.Models;

public class Labrador : IDog
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Weight { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int BirdsRetrievedCount { get; set; }
}