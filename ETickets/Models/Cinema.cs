using System.ComponentModel.DataAnnotations;

namespace ETickets.Models
{
    public class Cinema
    {
        [Key]
        public int ID { get; set; } // this identyfir 
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Relationships => Cinema has more movies
        public List<Movie> movies { get; set; }
    }
}
