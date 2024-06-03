using GraphQL.Polymorphism.GraphQL.Queries;
using GraphQL.Polymorphism.GraphQL.Types;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Polymorphism
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<DogDbContext>(o => o.UseInMemoryDatabase("dogs"));

            builder.Services
                .AddGraphQLServer()
                .AddQueryType<DogQuery>()
                .AddType<DogType>()
                .AddType<DobermanType>()
                .AddType<LabradorType>(); ;

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();
            app.MapControllers();
            app.MapGraphQL("/graphql");

            app.Run();
        }
    }
}