using PersonAnimals.ViewModels.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonAnimals.Repositories;
using PersonAnimals.Models;

namespace PersonAnimals.Controllers
{
    public class AnimalsController : Controller
    {
        // GET: Animals
        public ActionResult List()
        {
            AnimalsListVM model = new AnimalsListVM();
            AnimalRepository animalRep = new AnimalRepository();

            model.Animals = animalRep.GetAll();

            return View(model);
        }
        public ActionResult Edit(int? id)
        {
            Animal animal = new Animal();
            AnimalRepository animalRep = new AnimalRepository();

            if (!id.HasValue)
            {
                animal = new Animal();
            }
            else
            {
                animal = animalRep.GetByID(id.Value);
                if (animal == null)
                {
                    return RedirectToAction("List");
                }
            }
            AnimalsEditVM model = new AnimalsEditVM();
            model.ID = animal.ID;
            //model.Person.ID = animal.PersonID;
            model.Name = animal.Name;
            model.Age = animal.Age;
            model.AnimalType = animal.AnimalType;

            return View(model);
        }
        [HttpPost]
        public ActionResult Edit()
        {
            AnimalsEditVM model = new AnimalsEditVM();
            TryUpdateModel(model);

            AnimalRepository animalRep = new AnimalRepository();
            Animal animal;
            if (model.ID == 0)
            {
                animal = new Animal();
            }
            else
            {
                animal = animalRep.GetByID(model.ID);
                if (animal == null)
                {
                    return RedirectToAction("List");
                }
            }

            animal.ID = model.ID;
            animal.PersonID = model.Person.ID;
            animal.Name = model.Name;
            animal.Age = model.Age;
            animal.AnimalType = model.AnimalType;

            animalRep.Save(animal);

            return RedirectToAction("List");
        }

        public ActionResult Delete(int id)
        {
            AnimalRepository animalRep = new AnimalRepository();
            animalRep.Delete(id);

            return RedirectToAction("List");
        }
    }
}