using Microsoft.EntityFrameworkCore;
using node_todo_api_net_core.Models;

namespace node_todo_api_net_core.Contexts
{
    public class TodoAppContext : DbContext
    {
        public TodoAppContext(DbContextOptions<TodoAppContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}