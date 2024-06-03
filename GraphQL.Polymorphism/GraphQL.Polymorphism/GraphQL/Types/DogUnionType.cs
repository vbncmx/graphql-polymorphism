using GraphQL.Polymorphism.Models;

namespace GraphQL.Polymorphism.GraphQL.Types;

using HotChocolate.Types;

public class DogUnionType : UnionType
{
    protected override void Configure(IUnionTypeDescriptor descriptor)
    {
        descriptor.Name("DogUnion");
        descriptor.Type<DobermanType>();
        descriptor.Type<LabradorType>();


        descriptor.ResolveAbstractType(context =>
        {
            var dog = context.Object as Dog;
            if (dog is Doberman)
            {
                return context.Schema.GetType<DobermanType>();
            }
            else if (dog is Labrador)
            {
                return context.Schema.GetType<LabradorType>();
            }
            return null;
        });
    }
}
