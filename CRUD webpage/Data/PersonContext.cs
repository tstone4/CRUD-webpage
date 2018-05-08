using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD_webpage.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_webpage.Data
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person");
        }
    }
}
