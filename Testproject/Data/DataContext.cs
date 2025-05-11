using Microsoft.EntityFrameworkCore;
using Testproject.Models;

namespace Testproject.Data;

public class DataContext : DbContext
{
    public DbSet<TodoTask> TodoTasks { get; set; }
    public DbSet<User> Users { get; set; }
    
    public DataContext(DbContextOptions<DataContext> options) : base(options) { } 
}