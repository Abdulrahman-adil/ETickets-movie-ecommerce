using ETickets.Data.Enums;
using ETickets.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ETickets.Data
{
    public class AppDbInitialzer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //we Going to Add
                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"
                        },new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the first cinema"
                        },new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the first cinema"
                        },new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the first cinema"
                        },new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.actors.Any())
                {
                    context.actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            Name = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            imgUrl = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Actor()
                        {
                            Name = "Actor 2",
                            Bio = "This is the Bio of the first actor",
                            imgUrl = "http://dotnethow.net/images/actors/actor-2.jpeg"

                        },
                        new Actor()
                        {
                            Name = "Actor 3",
                            Bio = "This is the Bio of the first actor",
                            imgUrl = "http://dotnethow.net/images/actors/actor-3.jpeg"

                        },
                        new Actor()
                        {
                            Name = "Actor 4",
                            Bio = "This is the Bio of the first actor",
                            imgUrl = "http://dotnethow.net/images/actors/actor-4.jpeg"

                        },
                        new Actor()
                        {
                            Name = "Actor 5",
                            Bio = "This is the Bio of the first actor",
                            imgUrl = "http://dotnethow.net/images/actors/actor-5.jpeg"

                        },

                    });
                    context.SaveChanges();
                }
                //Producer
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            Name = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            imgUrl = "http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                         new Producer()
                         {
                             Name = "Producer 2",
                             Bio = "This is the Bio of the first actor",
                             imgUrl = "http://dotnethow.net/images/producers/producer-2.jpeg"
                         },
                          new Producer()
                          {
                              Name = "Producer 3",
                              Bio = "This is the Bio of the first actor",
                              imgUrl = "http://dotnethow.net/images/producers/producer-3.jpeg"
                          },
                           new Producer()
                           {
                               Name = "Producer 4",
                               Bio = "This is the Bio of the first actor",
                               imgUrl = "http://dotnethow.net/images/producers/producer-4.jpeg"
                           },
                            new Producer()
                            {
                                Name = "Producer 5",
                                Bio = "This is the Bio of the first actor",
                                imgUrl = "http://dotnethow.net/images/producers/producer-5.jpeg"
                            },
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.movies.Any())
                {
                    context.movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 93.22,
                            imgUrl = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndtDate = DateTime.Now.AddDays(10),
                            CinemaID = 3,
                            ProducerID =3,
                            movieCategory = MovieCategory.Documentry
                        },
                         new Movie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption movie description",
                            Price = 22.22,
                            imgUrl = "http://dotnethow.net/images/movies/movie-2.jpeg",
                            StartDate = DateTime.Now,
                            EndtDate = DateTime.Now.AddDays(3),
                            CinemaID = 1,
                            ProducerID =1,
                            movieCategory = MovieCategory.Action
                        },
                          new Movie()
                        {
                            Name = "Venom",
                            Description = "This is the Venom movie description",
                            Price = 123.22,
                            imgUrl = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now,
                            EndtDate = DateTime.Now.AddDays(5),
                            CinemaID = 4,
                            ProducerID =4,
                            movieCategory = MovieCategory.Documentry
                        },
                           new Movie()
                        {
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 63.22,
                            imgUrl = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndtDate = DateTime.Now.AddDays(-5),
                            CinemaID = 1,
                            ProducerID =3,
                            movieCategory = MovieCategory.Documentry
                        },
                            new Movie()
                        {
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 93.22,
                            imgUrl = "http://dotnethow.net/images/movies/movie-5.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndtDate = DateTime.Now.AddDays(10),
                            CinemaID = 3,
                            ProducerID =3,
                            movieCategory = MovieCategory.Cartoon
                        },
                             new Movie()
                        {
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 93.22,
                            imgUrl = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(5),
                            EndtDate = DateTime.Now.AddDays(10),
                            CinemaID = 3,
                            ProducerID =5,
                            movieCategory = MovieCategory.Drama
                        },
                    });
                    context.SaveChanges();
                }
                //Actorts & movies
                if (!context.Actor_Movies.Any())
                {
                    context.Actor_Movies.AddRange(new List<Actor_Movie>() 
                    {
                     new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });
                    context.SaveChanges();

                }
            }
        }

        // public static void Seed(this ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Actor>().HasData()
        //}
     }
}
