using eTickets.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Display(Name = "Movie Name")]
        public string Name { get; set; }
        [Display(Name = "Movie Description")]
        public string Description { get; set; }
        public double Price { get; set; }
        [Display(Name = "Movie Image")]
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime lastDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        // Foreign key for Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        // Foreign key for Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }

        // Navigation property to establish a many-to-many relationship with Actor 
        public List<Actor_Movie> Actors_Movies { get; set; }
        public DateTime EndDate { get; internal set; }
    }
}
