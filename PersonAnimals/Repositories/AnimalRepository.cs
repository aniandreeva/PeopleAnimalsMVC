using PersonAnimals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonAnimals.Repositories
{
    public class AnimalRepository: BaseRepository<Animal>
    {
        public AnimalRepository():base (){ }
        public AnimalRepository(AppContext context): base(context) { }
    }
}