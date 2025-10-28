using System.ComponentModel.DataAnnotations;

namespace E_Tickets.Models
{
    public class Producer
    {
        public int Id { get; set; }
        [Display(Name ="Full Name")]
        public string FullName { get; set; }
        [Display(Name ="Picture Profile")]
        public string ProfilePictureURL { get; set; }
        [Display(Name ="Biography")]
        public string Bio { get; set; }
        public List<Movie> Movies { get; set; }

    }
}
