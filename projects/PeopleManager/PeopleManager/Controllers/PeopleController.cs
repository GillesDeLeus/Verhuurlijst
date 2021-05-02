using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PeopleManager.Models;

namespace PeopleManager.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            var people = GetPeople();
            return View(people);
        }

        public IList<Person> GetPeople() {
            var gillesPerson = new Person { Id = 1, FirstName = "Gilles", LastName = "De Leus" };
            var maxPerson = new Person { Id = 2, FirstName = "Max", LastName = "De Lucio" };

            var personList = new List<Person> { gillesPerson, maxPerson };

            return personList;
        }
    }
}
