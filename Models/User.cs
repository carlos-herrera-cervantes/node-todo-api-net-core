using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace node_todo_api_net_core.Models
{
    public class User
    {
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public int AgeInYears { get; set; }

        [Required]
        public string Password { get; set; }
    }
}