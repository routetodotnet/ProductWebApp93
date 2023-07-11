using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductWebApp.Models
{

    //DTO/ domain object//Entity
    public class Employee
    {
        //data-val-required =true data-val-message= name is required.
        [Required(ErrorMessage ="name is requried")]
        public string Name { get; set; }

        [Required(ErrorMessage="id cannot be blank")]
        public int EmployeeId { get; set; }

        [Required]
        [MaxLength(5,ErrorMessage ="max length is 5 char")]
        public string FirstName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [PhoneValidation(ErrorMessage ="phone number should be 9 digits..")]
        public string Phone { get; set; }
    
    }

  //creating custom validator
    public class PhoneValidation:ValidationAttribute
    {

        public override bool IsValid(object value)
        {
            //custom logic
            if (value.ToString().Length<9)
                return false;

            return base.IsValid(value);
        }

    }

    //custom action filter
    public class LogFilter:ActionFilterAttribute
    {


        //
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if(filterContext.HttpContext.Request.QueryString["id"]=="abc")
            {

            }
            else
            {
                throw new Exception("not a valid request");
            }


            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Exception ex = filterContext.HttpContext.Server.GetLastError();

          if(ex != null)
            {
                throw new Exception("some error occured..");
               
            }
            base.OnActionExecuted(filterContext);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
        }
    }

}