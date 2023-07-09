using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductWebApp.Models
{
    public class PersonRespository
    {

        public List<PersonViewModel> GetAllPerson()
        {
            ///db logic to get..

            return new List<PersonViewModel>()
            {


                new PersonViewModel() { Id=1, Name ="abc", Address="USA"},
                new PersonViewModel() { Id=2,Name="BBB",Address="IND"},
                new PersonViewModel() { Id=3,Name ="CCC", Address="UK"}
            };

        }

        public PersonViewModel Search(int personid)
        {
            //dblogic 

            return new PersonViewModel() { Id = personid, Name = "test1", Address = "USA" };


            

        }

        public bool Update(int personid,string newname)
        {
            //dblogic 

            return true;


        }

        public bool Delete(int personid)
        {
            //dblogic 
            //delete logic 
            return true;


        }

        public bool Create(PersonViewModel prodobj)
        {
            //dblogic 
            //create prodobj...

            return false;


        }
    }
}