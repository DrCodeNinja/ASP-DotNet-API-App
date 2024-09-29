using System.ComponentModel.DataAnnotations;

namespace TestApp.Models
{
    public class Todo
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string? Title { get; set; }
        [MaxLength(130)]
        public string? Description { get; set; }
        [Required]
        public DateTime Created {  get; set; }
        [Required]
        public DateTime Due { get; set; }
        [Required]
        public TodoStatus Status { get; set; }
        
        public int AuthorId { get; set; }

        public Author Author { get; set; }
    }
}
