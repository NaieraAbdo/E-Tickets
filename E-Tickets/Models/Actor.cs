using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace E_Tickets.Models
{
    public class Actor
    {
        public int Id { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name ="Picture Profile")]
        public string ProfilePictureURL { get; set; }
        [Display(Name ="Biography")]
        public string Bio { get; set; }
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
