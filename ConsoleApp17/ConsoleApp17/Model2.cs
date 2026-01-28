using System.ComponentModel.DataAnnotations;

public class Book
{
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    public string Genre { get; set; }

    public int PublishedYear { get; set; }

    public int AuthorId { get; set; }
    public Author Author { get; set; }
}
