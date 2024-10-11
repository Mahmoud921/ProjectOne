using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online.Models
{
    public class CardItem
    {
        [Key]
        public int CartId { get; set; }

        // Foreign Key
        
        public int StudentId { get; set; }

        public DateTime CreatedDate { get; set; }

        // Navigation Properties
        public Student? Student { get; set; }
        public ICollection<Course> Course { get; set; }
    }
}
