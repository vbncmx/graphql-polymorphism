using GraphQL.Polymorphism.Models;

namespace GraphQL.Polymorphism.GraphQL.Queries;

public class DogQuery
{
    private readonly IDog[] _dogs;
    public DogQuery()
    {
        var dogList = new List<IDog>();

        for (var i = 0; i < 5; i++)
        {
            dogList.Add(new Labrador
            {
                Id = i,
                DateOfBirth = new DateTime(2020, i + 1, i + 1),
                Name = $"Lab {i}",
                Weight = 30 + i,
                BirdsRetrievedCount = i * 2
            });
        }

        for (var i = 0; i < 5; i++)
        {
            dogList.Add(new GermanShepherd
            {
                Id = 5 + i,
                DateOfBirth = new DateTime(2021, i + 1, i + 1),
                Name = $"Rex {i}",
                Weight = 40 + i,
                BurglarsCaughtCount = i * 2
            });
        }

        for (var i = 0; i < 5; i++)
        {
            dogList.Add(new Pudel
            {
                Id = 10 + i,
                DateOfBirth = new DateTime(2022, i + 1, i + 1),
                Name = $"Rex {i}",
                Weight = 25 + i,
                ExhibitionAttendedCount = i * 2
            });
        }

        _dogs = dogList.OrderBy(d => d.GetHashCode()).ToArray();
    }

    public IQueryable<IDog> GetDogs()
    {
        return _dogs.AsQueryable();
    }
}