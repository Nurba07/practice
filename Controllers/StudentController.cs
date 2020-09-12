using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using Practice1.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practice1.Controllers
{

    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private List<Student> students = new List<Student>() { 
       
            
                new Student() { ID = 1, Name = "Anuar", Birthday = new DateTime(2002,03,05)},
                new Student() { ID = 2, Name = "Azat", Birthday = new DateTime(2003,06,30) },
                new Student() { ID = 3, Name = "Mukha", Birthday = new DateTime(2002,08,25) },
                new Student() { ID = 4, Name = "Sabina", Birthday = new DateTime(2001,12,12)},
                new Student() { ID = 5, Name = "Elina", Birthday = new DateTime(2002,02,27)}
            };

        [HttpGet("all")]

        public List<Student> GetStudents()
        {
            return students;
        }

        [HttpGet("id/{ID}")]

        public List<Student> GetID(int id)
        {
            return students.Where(s => s.ID == id).ToList();
        }


    }

    
}
