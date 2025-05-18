using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor_Movie
    { 

        // Foreign key for Actor
        public int ActorId { get; set; }
        public Actor Actor { get; set; }

        // Foreign key for Movie
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
