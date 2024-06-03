using GraphQL.Polymorphism.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Polymorphism;

public class DogDbContext : DbContext
{
    public DogDbContext(DbContextOptions<DogDbContext> options) : base(options) { }
    public DbSet<Labrador>? Labradors { get; set; }
    public DbSet<Doberman>? Dobermans { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Labrador>().HasData(
            new Labrador
            {
                Id = 1,
                DateOfBirth = new DateTime(2020, 1, 1),
                Name = "Bulba",
                Weight = 35,
                BirdsRetrievedCount = 5
            });

        modelBuilder.Entity<Doberman>().HasData(
            new Doberman
            {
                Id = 2,
                DateOfBirth = new DateTime(2021, 1, 1),
                Name = "Rex",
                Weight = 50,
                BurglarsCaughtCount = 21
            });
    }
}