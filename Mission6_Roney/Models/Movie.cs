using System.ComponentModel.DataAnnotations;

namespace Mission6_Roney.Models
{
    public class Movie
    {
        [Key] // Primary Key
        public int MovieId { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; } // Dropdown (G, PG, PG-13, R)

        public bool Edited { get; set; } = false;  // Ensure it’s never null

        public string? LentTo { get; set; } // Optional

        [StringLength(25, ErrorMessage = "Notes cannot exceed 25 characters.")]
        public string? Notes { get; set; } // Optional, Max 25 characters
    }
}