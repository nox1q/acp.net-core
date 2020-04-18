using web.application.Models.Movies;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web.application.Data
{
        public class MoviesContext : DbContext
        {
            public MoviesContext(DbContextOptions options) : base(options)
            {
            }

            public DbSet<Movie> Movies { get; set; }
        }
}