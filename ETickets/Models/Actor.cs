using System.ComponentModel.DataAnnotations;

namespace ETickets.Models
{
    public class Actor
    {
        [Key]
        public int ID { get; set; }
        public string imgUrl { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
