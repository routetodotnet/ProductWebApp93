using ProductWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;

namespace ProductWebApp.Controllers
{
    public class ProductController : Controller
    {  
        // GET: Product
        //right click on actionmethod name -->add view

        //3 TempData - between controller action methods.
        //4 Session-between controller action methods.
        public ActionResult GetAllProducts()
        {

            var lstProducts=ProductRepository.GetAllProducts();

            //action to View.
            //1 ViewData->key and values are object type.
            ViewData.Add("count", 10);
            //CSHTML view
            // Convert.ToInt32(ViewData["count"]);


            ViewData.Add("countryname", "USA");
            Product product = new Product();
            product.Name = "CCCC";
            product.Description = "viewdataproduct desc";
            product.Id = 1;

            ViewData.Add("product", product);
            //(Product)ViewData["Product"];

            //2 ViewBag-->value is type dynamic , No type conversion.
            ViewBag.count = 100;
            ViewBag.product = product;
            ViewBag.name = "abc viewbag";
            //cshtml 
            //int a=@ViewBag.count;
            //Product p=@ViewBag.product; 

            //3 model -->strongly typed object to view.

            return View();

        }


        public ActionResult GetAllProducts2()
        {

            var lstProducts = ProductRepository.GetAllProducts();


            //3 model -->strongly typed object to view.
            Product product = new Product();
            product.Name = "CCCC";
            product.Description = "model product desc";
            product.Id = 1;

            Product product1 = new Product();
            product1.Name = "aaaaC";
            product1.Description = "Product 1 details.";
            product1.Id =11;

            Product product2 = new Product();
            product2.Name = "cccc";
            product2.Description = "Product 2  details.";
            product2.Id = 222;

            ViewBag.Prod1 = product1;
            ViewBag.Prod2 = product2;

            //return View("ABC");
            //@Model -String

            return View(product);
            //CSHTML
            //@Model Product object
            //@Model.Id
            //@Model.Name

        }
        public ActionResult Create()
        {

            return View();
        }

        //browser-->server
        //https://localhost:44331/Product/CreateSubmit1? id=122&username=abc&Description=test1
        //method: http GET
        //key to method parameter.
        public ActionResult CreateSubmit1(int id,string username,string Description)
        {

            int productid = id;
            string name = username;
            string description = Description;
            return View();
        }


        //browser-->server
        //https://localhost:44331/Product/CreateSubmit2
        //method: http POST
        //request body: key=value..key2=value2
        public ActionResult CreateSubmit2()
        {

            int productid = Convert.ToInt32(Request.Form["id"]);
            string name = Request.Form["username"];
            string description = Request.Form["Description"]; 

            return View();
        }

        //browser-->server
        //https://localhost:44331/Product/CreateSubmit2
        //method: http POST
        //request body: key=value..key2=value2
        //strongly typed object  //modelbinder
        //make sure object properties ==html name attribute.
        public ActionResult CreateSubmit3(Product prodobj )
        {

            int productid = prodobj.Id;
            string name = prodobj.Name;
            string description = prodobj.Description; 

            return View();
        }
        public ActionResult GetProduct(int id)
        {

            return View();
        }

       
    }
}