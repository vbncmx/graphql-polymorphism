using GraphQL.Polymorphism.Models;

namespace GraphQL.Polymorphism.GraphQL.Types;

public class DobermanType : ObjectType<Doberman>
{
    protected override void Configure(IObjectTypeDescriptor<Doberman> descriptor)
    {
        descriptor.Field(d => d.BurglarsCaughtCount);
    }
}