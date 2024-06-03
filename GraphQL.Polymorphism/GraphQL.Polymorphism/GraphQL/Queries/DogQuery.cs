using GraphQL.Polymorphism.Models;

namespace GraphQL.Polymorphism.GraphQL.Queries;

public class DogQuery
{
    public IQueryable<Dog> GetDobermans([Service(ServiceKind.Pooled)] DogDbContext dbContext)
    {
        IQueryable<Dog> dobermanQueryable = dbContext.Dobermans;
        IQueryable<Dog> labradorQueryable = dbContext.Labradors;
        return dobermanQueryable.Union(labradorQueryable);
    }
}