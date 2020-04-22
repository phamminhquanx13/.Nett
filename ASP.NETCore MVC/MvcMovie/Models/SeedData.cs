using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "q1",
                        ReleaseDate = DateTime.Parse("1997-10-15"),
                        Genre = "X1",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "q2",
                        ReleaseDate = DateTime.Parse("1997-1-15"),
                        Genre = "X2",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "q3",
                        ReleaseDate = DateTime.Parse("1997-10-5"),
                        Genre = "Comedy",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "q4",
                        ReleaseDate = DateTime.Parse("197-1-1"),
                        Genre = "X4",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}