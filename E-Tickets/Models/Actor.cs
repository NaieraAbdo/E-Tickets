using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace E_Tickets.Models
{
    public class Actor
    {
        public int Id { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage ="Full Name is required.")]
        public string FullName { get; set; }
        [Display(Name ="Picture Profile")]
        [Required(ErrorMessage ="Profile Picture is required.")]
        public string ProfilePictureURL { get; set; }
        [Display(Name ="Biography")]
        [Required(ErrorMessage ="Bigraphy is required.")]
        public string Bio { get; set; }
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
