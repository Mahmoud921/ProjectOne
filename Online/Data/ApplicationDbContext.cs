using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Online.Models;
using System.Collections.Generic;

namespace Online.Data
{
    public class ApplicationDbContext:DbContext

    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categoryes { get; set; }
        public DbSet<CardItem> CardItems { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ):base(options)
        {
            
        }
    }


    
}
