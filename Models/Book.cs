using System.ComponentModel.DataAnnotations;

namespace project6_dotnet_mvc.Models;

public class Book
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Title is required")]
    [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters")]
    public string? Title { get; set; }

    [Required(ErrorMessage = "Author is required")]
    [StringLength(50, ErrorMessage = "Author name cannot be longer than 50 characters")]
    public string? Author { get; set; }

    [Range(1450, 2100, ErrorMessage = "Year must be between 1450 and 2100")]
    public int Year { get; set; }
    
    [Url(ErrorMessage = "Please enter a valid URL for the image")]
    public string? ImageUrl { get; set; }
}
