using E_Tickets.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Tickets.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>()
                .HasKey(am => new
                {
                    am.MovieId,
                    am.ActorId
                });

            modelBuilder.Entity<Actor_Movie>()
                .HasOne(m => m.Movie)
                .WithMany();

            modelBuilder.Entity<Actor_Movie>()
                .HasOne(a => a.Actor)
                .WithMany();

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
    }
}
