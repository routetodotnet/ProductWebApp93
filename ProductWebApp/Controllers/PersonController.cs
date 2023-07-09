using ProductWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductWebApp.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult GetAllPerson()
        {
            PersonRespository personRespository = new PersonRespository();

          var lstPersons=  personRespository.GetAllPerson();
                
          return View(lstPersons);


        }

// Person/Edit/1
        public ActionResult Edit(int id)
        {
            PersonRespository personRespository = new PersonRespository();
            var findperson = personRespository.Search(id);
            return View(findperson);
        }
        //Person/Create 
        //http Get
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        //action filter
        //person/Create method="Post"
        [HttpPost]
        public ActionResult Create(PersonViewModel pobj)
        {
            PersonRespository personRespository= new PersonRespository();
            bool result= personRespository.Create(pobj);
            if (result)
            { //redirecct to diff action or same view.
                return RedirectToAction("GetAllPerson");

            }
           else
            {
                //if errors in creating in db.. validations..
                return View();
            }
   


        }
        public ActionResult Delete(int id)
        {

            return View();
        }
    }
}