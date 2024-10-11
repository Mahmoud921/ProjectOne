using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        // Foreign Keys
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }

        // Navigation Properties
        public Category? Category { get; set; }
        public Instructor? Instructor { get; set; }

        public ICollection<CardItem> cardItem { get; set; }
    }
}
