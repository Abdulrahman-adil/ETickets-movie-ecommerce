using ETickets.Data;
using ETickets.Models;

namespace ETickets.Repositoris.Actors
{
    public class ActorRepositry
    {
        AppDbContext context;

        public ActorRepositry()
        {
            context = new AppDbContext();
        }

        public List<Actor> GetAll()
        {
            return new List<Actor>();   
        }
    }
}
