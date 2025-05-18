using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Navigation property to establish a many-to-many relationship with Movie
        public List<Movie> Movies { get; set; }
    }
}
