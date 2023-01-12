using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        private MainDBContext _context;

        public StudentsController(MainDBContext context) {

            _context = context;
        
        }

        [HttpGet]
        public IEnumerable<Student> Students()
        {
            var context = new MainDBContext();
            var res = (from Student in context.Students
                           where 1 == 1
                           select Student).ToList();

            return res;

        }


        [HttpGet]
        [Route("{IdStudent}")]
        public Student Student(int IdStudent)
        {


            var context = new MainDBContext();
            var res = (from Student in context.Students
                      where Student.IdStudent == IdStudent
                      select Student).ToList().ElementAt(0);
  
            return res;

        }


    }
}
