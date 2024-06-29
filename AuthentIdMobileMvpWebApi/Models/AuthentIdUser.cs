using System.ComponentModel.DataAnnotations;

namespace AuthentIdMobileMvpWebApi.Models
{
    public class AuthentIdUser
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
