using Microsoft.VisualBasic;
using System.Reflection.Emit;

namespace ConsoleApp18.Core.Entity;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public decimal Grade { get; set;}
    public DateTime Registration  { get; set; }
    public ICollection<StudentGroup> StudentGroups { get; set; }
}
