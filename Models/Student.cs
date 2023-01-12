using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Models
{
    public class Student
    {

        public int IdStudent { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string IndexNumber { get; set; }

        public int StudyYear { get; set; }
             
        public int StudyId { get; set; }

        //[ForeignKey("StudyId")]
        public virtual Study Study { get; set; }
    }
}
