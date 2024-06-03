using GraphQL.Polymorphism.Models;

namespace GraphQL.Polymorphism.GraphQL.Types;

public class DogType : ObjectType<Dog>
{
    protected override void Configure(IObjectTypeDescriptor<Dog> descriptor)
    {
        descriptor.Field(d => d.Name);
        descriptor.Field(d => d.DateOfBirth);
    }
}