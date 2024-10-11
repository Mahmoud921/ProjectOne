using System.ComponentModel.DataAnnotations;

namespace Online.Models
{
    public class ApplicationUser
    {
        
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        public string Password { get; set; }

        public bool IsInstructor { get; set; }
    }

}
