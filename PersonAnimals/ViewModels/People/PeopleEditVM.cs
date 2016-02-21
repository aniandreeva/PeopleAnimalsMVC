using PersonAnimals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonAnimals.ViewModels.People
{
    public class PeopleEditVM
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Animal> Animals { get; set; }
    }
}