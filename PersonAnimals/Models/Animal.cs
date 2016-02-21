using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonAnimals.Models
{
    public class Animal:BaseModel
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public AnimalTypeEnum AnimalType { get; set; }

        public virtual Person Person { get; set; }

    }
    public enum AnimalTypeEnum
    {
        Cat, Dog, Bunny, GuineaPig
    }

}