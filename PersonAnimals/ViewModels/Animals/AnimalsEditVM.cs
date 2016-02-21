using PersonAnimals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonAnimals.ViewModels.Animals
{
    public class AnimalsEditVM
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public AnimalTypeEnum AnimalType { get; set; }
        public Models.Person Person { get; set; }
    }
}