using GraphQL.Polymorphism.Models;
namespace GraphQL.Polymorphism.GraphQL.Types;

public class LabradorType : ObjectType<Labrador>
{
    protected override void Configure(IObjectTypeDescriptor<Labrador> descriptor)
    {
        descriptor.Field(d => d.BirdsRetrievedCount);
    }
}
