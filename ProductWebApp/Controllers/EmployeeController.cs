using ProductWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductWebApp.Controllers
{
   // [LogFilter]
    public class EmployeeController : Controller
    {
        //[HttpPost]
        //action filter..
        [HttpGet]
      
        // GET: Employee
        public ActionResult GetAllEmployee()
        {

            try
            {
                int i = 0;
                int j = 2;
                int k = j / i;
            }
            
            catch (SqlException ex3)
            {

            }
            catch(DivideByZeroException ex2)
            {

            }
            catch (Exception ex)
            {

               // ex.StackTrace -- code block
               //ex.Message- 
               //logged
               // throw;
                throw new Exception("custom message");//it will reset orginal stack trace..
                //log exception
                //throw custom error.
            }

            return View();
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [Authorize]
        // GET: Employee/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            try
            {
                //custom rules checking.
                //if(employee.Phone.Length<9)
                //{
                //    ModelState.AddModelError("Phone", "which is not 9 digits.");
                //}

                if (ModelState.IsValid)
                {
                    // validate object details on ther server 
                    //run business validation
                    //call repository to create
                    // TODO: Add insert logic here

                    return RedirectToAction("GetAllEmployee");
                }
                else
                {
                    return View(employee);

                    //if any erros you will return with error messsage
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
         [HttpDelete]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
