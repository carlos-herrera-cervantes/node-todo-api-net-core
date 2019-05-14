using System.ComponentModel.DataAnnotations;

namespace node_todo_api_net_core.Models
{
    public class Todo
    {
        public long Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
        public bool Completed { get; set; } = false;
    }
}