﻿using Microsoft.EntityFrameworkCore;

namespace RESTApiProject.Model
{
    public class MovieContext : DbContext {

        public MovieContext(DbContextOptions<MovieContext> options):base(options)
        {
           
        }
        public DbSet<Movie> Movies { get; set; } = null!;
    }


    
}
