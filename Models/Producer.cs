using eTickets.Models;
using System.ComponentModel.DataAnnotations;

public class Producer
{
    [Key]
    public int Id { get; set; }
    public string ProfilePictureURL { get; set; }
    public string FullName { get; set; }
    public string Bio { get; set; }

    // Navigation property to establish a many-to-many relationship with Movie
    public List<Movie> Movies { get; set; }

}

