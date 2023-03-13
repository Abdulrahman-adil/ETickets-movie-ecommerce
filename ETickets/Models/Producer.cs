using System.ComponentModel.DataAnnotations;

namespace ETickets.Models
{
    public class Producer
    {
        [Key]
        public int ID { get; set; }
        public string imgUrl { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }

        //Relationships => producer has more movies
        public List<Movie> movies { get; set; }
    }
}
