using System;
using LumiaProject.Models;
using Microsoft.EntityFrameworkCore;

namespace LumiaProject.DAL
{
	public class AppDbContext:DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
        public DbSet<Testimonial> Testimonials { get; set; }

        public DbSet<Position> Positions { get; set; }

    }
}

