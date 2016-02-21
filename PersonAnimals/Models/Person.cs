using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonAnimals.Models
{
    public class Person:BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual List<Animal> Animals { get; set; }
    }
}