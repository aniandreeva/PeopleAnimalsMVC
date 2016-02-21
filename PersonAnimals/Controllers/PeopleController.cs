using PersonAnimals.Models;
using PersonAnimals.Repositories;
using PersonAnimals.ViewModels;
using PersonAnimals.ViewModels.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonAnimals.Controllers
{
    public class PeopleController : Controller
    {
        // GET: Person
        public ActionResult List()
        {
            PeopleListVM model = new PeopleListVM();
            PersonRepository personRep = new PersonRepository();

            model.People = personRep.GetAll();

            return View(model);
        }
        public ActionResult Edit(int? id)
        {
            Person person = new Person();
            PersonRepository personRep = new PersonRepository();

            if (!id.HasValue)
            {
                person = new Person();
            }
            else
            {
                person = personRep.GetByID(id.Value);
                if (person== null)
                {
                    return RedirectToAction("List");
                }
            }
            PeopleEditVM model = new PeopleEditVM();
            model.ID = person.ID;
            model.FirstName = person.FirstName;
            model.LastName = person.LastName;
            model.Age = person.Age;
            model.Animals = person.Animals;

            return View(model);
        }
        [HttpPost]
        public ActionResult Edit()
        {
            PeopleEditVM model = new PeopleEditVM();
            TryUpdateModel(model);

            PersonRepository personRep = new PersonRepository();
            Person person;
            if (model.ID==0)
            {
                person = new Person();
            }
            else
            {
                person = personRep.GetByID(model.ID);
                if (person==null)
                {
                    return RedirectToAction("List");
                }
            }

            person.ID = model.ID;
            person.FirstName = model.FirstName;
            person.LastName = model.LastName;
            person.Age = model.Age;
            person.Animals = model.Animals;

            personRep.Save(person);

            return RedirectToAction("List");
        }

        public ActionResult Delete(int id)
        {
            PersonRepository personRep = new PersonRepository();
            personRep.Delete(id);

            return RedirectToAction("List");
        }
    }
}