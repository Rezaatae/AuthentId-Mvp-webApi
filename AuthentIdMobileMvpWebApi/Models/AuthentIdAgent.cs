using System.ComponentModel.DataAnnotations;

namespace AuthentIdMobileMvpWebApi.Models
{
    public class AuthentIdAgent
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
        public string Sector { get; set; }
        [Required]
        public string PositionHeld { get; set; }
        public string PhotoUrl { get; set; }
    }
}
