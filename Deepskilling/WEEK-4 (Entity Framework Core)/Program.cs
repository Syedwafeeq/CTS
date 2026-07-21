using WEEK_4_Entity_Framework_Core.Data;

Console.WriteLine("Entity Framework Core Demo");

using var context = new AppDbContext();

context.Database.EnsureCreated();

Console.WriteLine("Database created successfully.");