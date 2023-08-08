using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain.Entities
{
    public class Student
    {

        [Key]
        public int StudentId { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }
        public double Percentage { get; set; }
    }
}
