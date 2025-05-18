using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class AppDbContext : DbContext
    {
        // Constructor to pass options to the base DbContext
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSet for Movies
        public DbSet<Movie> Movies { get; set; }
        // DbSet for Cinemas    
        public DbSet<Cinema> Cinemas { get; set; }
        // DbSet for Producers
        public DbSet<Producer> Producers { get; set; }
        // DbSet for Actors
        public DbSet<Actor> Actors { get; set; }
        // DbSet for Actor_Movie (many-to-many relationship)
        public DbSet<Actor_Movie> Actors_Movies { get; set; }

        // Override OnModelCreating if needed for custom configurations
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>()
                .HasKey(am => new { am.ActorId, am.MovieId }); // Composite key for Actor_Movie

            modelBuilder.Entity<Actor_Movie>().HasOne(am => am.Actor)
                .WithMany(a => a.Actors_Movies)
                .HasForeignKey(am => am.ActorId);

            modelBuilder.Entity<Actor_Movie>().HasOne(am => am.Movie)
                .WithMany(m => m.Actors_Movies)
                .HasForeignKey(am => am.MovieId);
           

            base.OnModelCreating(modelBuilder);
 
        }
    }
}
