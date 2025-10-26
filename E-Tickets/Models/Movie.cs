using E_Tickets.Data.Enums;

namespace E_Tickets.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public double Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
        //Relations
        public List<Actor_Movie> Actors_Movies { get; set; }
        //Cinema
        public Cinema Cinema { get; set; }
        public int CinemaId { get; set; }
        //Producer
        public Producer Producer { get; set; }
        public int ProducerId { get; set; }
    }
}
