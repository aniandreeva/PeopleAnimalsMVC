using PersonAnimals.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PersonAnimals
{
    public class AppContext:DbContext
    {
        public AppContext() : base("personAnimalsDB") { }
        public DbSet<Person> People { get; set; }
        public DbSet<Animal> Animals { get; set; }
    }
}