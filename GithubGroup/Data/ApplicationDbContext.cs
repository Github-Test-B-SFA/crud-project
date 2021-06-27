using GithubGroup.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GithubGroup.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Student> students { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);


            //Students
            modelBuilder.Entity<Student>().HasData(new Student { Id = 1, Email = "Saud@gmail.com" });

        }

        }
}
