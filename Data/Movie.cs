using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace BlazorApp5.Data
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(64, MinimumLength = 3, ErrorMessage = "Title must be between 3 and 64 characters")]
        [RegularExpression(@"^(?!^[0-9]+$)[^<>]+$", ErrorMessage = "Title cannot be a single number and cannot contain '<' or '>' characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Director is required")]
        [StringLength(64, MinimumLength = 2, ErrorMessage = "Director name must be between 2 and 64 characters")]
        [RegularExpression(@"^[^0-9]+$", ErrorMessage = "Director name cannot be a number")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        public string Image { get; set; }

        public string Language { get; set; }

        public int Status { get; set; } // Assuming validation for Status is handled elsewhere

        public int AgeId { get; set; }

        [Required(ErrorMessage = "Age name is required")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Age name must be a number")]
        public string AgeName { get; set; }

        public Movie()
        {

        }

        public Movie(int id, string title, string director, string description, string image, string language, int status, int age_id)
        {
            Id = id;
            Title = title;
            Director = director;
            Description = description;
            Image = image;
            Language = language;
            Status = status;
            AgeId = age_id;
        }
    }
}
