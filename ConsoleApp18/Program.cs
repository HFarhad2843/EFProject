
using ConsoleApp18.Core.Entity;
using ConsoleApp18.DataAccess;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

AppDbContext context = new AppDbContext();

//Student s1 = new()
//{
//    Name = "Seymur",
//    Surname = "Aliyev",
//    Age = 27,
//    Grade = 87,
//    Registration = DateTime.Now
//};

//await context.Students.AddAsync(s1);
//await context.SaveChangesAsync();


//Student s2 = new()
//{
//    Name = "Ali",
//    Surname = "Aliyev",
//    Age = 23,
//    Grade = 77,
//    Registration = DateTime.Now
//};

//await context.Students.AddAsync(s2);
//await context.SaveChangesAsync();


//Student s3 = new()
//{
//    Name = "Farid",
//    Surname = "Valiyev",
//    Age = 31,
//    Grade = 95,
//    Registration = DateTime.Now
//};

//context.Students.Add(s3);
//context.SaveChanges();


//Group g1 = new()
//{
//    Name = "P238",
//    Description = "Backend",
//    Capacity = 17,

//};

//await context.Groups.AddAsync(g1);
//await context.SaveChangesAsync();

//Group g2 = new()
//{
//    Name = "P233",
//    Description = "Frontend",
//    Capacity = 15,

//};

//await context.Groups.AddAsync(g2);
//await context.SaveChangesAsync();

//Group g3 = new()
//{
//    Name = "P255",
//    Description = "Design",
//    Capacity = 20,

//};

//await context.Groups.AddAsync(g3);
//await context.SaveChangesAsync();

//Student student = await context.Students.FindAsync();
//Student student = await context.Students.FindAsync(3);
//Group group = context.Groups.FirstOrDefault(g => g.Capacity == 15);
//Console.WriteLine(group.Name);

Student s1 = new()
{
    Id = 4,
    Name = "Test Test1",
    Age = 19,
    Grade = 76
};
context.Entry(s1).State=EntityState.Modified;
Console.WriteLine(context.Entry(s1).State);
await context.SaveChangesAsync();
