﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        // Navigation property to establish a many-to-many relationship with Movie
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
