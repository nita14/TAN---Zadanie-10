using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Models
{
    public class Study
    {

        public int IdStudy { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
