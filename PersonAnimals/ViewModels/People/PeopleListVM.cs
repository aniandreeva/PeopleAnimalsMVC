using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PersonAnimals.Models;


namespace PersonAnimals.ViewModels.People
{
    public class PeopleListVM
    {
        public List<Models.Person> People { get; set; }
    }
}