using System.ComponentModel.DataAnnotations;

namespace Task1_Backend.Models
{
    public class TodoItems
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string? Heading { get; set; }
        public string? Description { get; set; }
        [Required]
        public string Status { get; set; }

    }
}
