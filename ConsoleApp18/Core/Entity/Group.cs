namespace ConsoleApp18.Core.Entity;

public class Group
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Capacity { get; set; }
    public ICollection<StudentGroup> StudentGroups  { get; set; }

}
