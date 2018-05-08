using CRUD_webpage.Data;
using CRUD_webpage.Models;
using System;
using System.Linq;

namespace CRUD_webpage.Data
{
    public static class DbInitializer
    {
        public static void Initialize(PersonContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Persons.Any())
            {
                return;   // DB has been seeded
            }

            var persons = new Person[]
            {
                new Person{Name="Ryan Mcnichol", Job="Professional Lint Licker", Location="Michigan"},
                new Person{Name="Thomas Stone", Job="None", Location="Michigan"},
                new Person{Name="Jacob Smith", Job="Bread taste tester", Location="Hawaii"},
                new Person{Name="Chris Pratt", Job="Actor", Location="California"}
            };

            foreach (Person s in persons)
            {
                context.Persons.Add(s);
            }

            context.SaveChanges();

        }
    }
}