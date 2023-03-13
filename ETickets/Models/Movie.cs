using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ETickets.Data.Enums;

namespace ETickets.Models
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public string imgUrl { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndtDate { get; set; }

        //public List<Cinema> cinemaName { get; set; }

        public MovieCategory movieCategory { get; set; }

        //Relationships

        public List<Actor_Movie> Actor_Movies { get; set; }

        // Cinema
        public int CinemaID { get; set; }
        [ForeignKey("CinemaID")]
        public Cinema Cinema { get; set; }

        // producer
        public int ProducerID { get; set; }
        [ForeignKey("ProducerID")]
        public Producer producer { get; set; }

    }
}
