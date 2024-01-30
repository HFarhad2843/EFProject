using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp18.Core.Entity;

public class StudentGroup
{
    //public int Id { get; set; }
    //[ForeignKey(nameof(Student))]
    public int StudentId { get; set; }
    //[ForeignKey(nameof(Group))]
    public int GroupId {  get; set; }
    public Student Student { get; set; } = null!;
    public Group Group { get; set; } = null!;

}
