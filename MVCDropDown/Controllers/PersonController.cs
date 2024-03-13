using Microsoft.AspNetCore.Mvc;
using MVCDropDown.Models;

namespace MVCDropDown.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Person> persons  = new List<Person>();
            persons.Add(new Person()
            {
                Id = 1,
                Name = "Bekir"
            });
            persons.Add(new Person() {
             Id = 3,
              Name="Hakkı"
            
            });
            persons.Add(new Person()
            {
                Id = 4,
                Name = "Nazmi"

            });
            persons.Add(new Person()
            {
                Id = 5,
                Name = "Rıfat"

            });
            persons.Add(new Person()
            {
                Id = 6,
                Name = "Kamil"

            });
            persons.Add(new Person()
            {
                Id = 7,
                Name = "İsmail"

            });

            return View(persons);
        }
    }
}
