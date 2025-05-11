namespace Testproject.Models;

public class TodoTask
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public int UserId { get; set; }
    public bool Completed { get; set; }
}