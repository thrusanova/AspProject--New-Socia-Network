namespace AspNetProject.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Experience
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
        
        [Required]
        [StringLength(50,MinimumLength = 5)]
        public string Company { get; set; }

        [Required]
        [StringLength(100,MinimumLength = 5)]
        public string Location { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? LeaveDate { get; set; }

        [Required]
        public string UserId { get; set; }

        public User User { get; set; }

    }
}