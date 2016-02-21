using PersonAnimals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonAnimals.Repositories
{
    public class PersonRepository: BaseRepository<Person>
    {
        public PersonRepository():base (){ }
        public PersonRepository(AppContext context): base(context) { }

    }
}