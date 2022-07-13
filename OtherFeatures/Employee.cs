using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherFeatures
{
    public class Employee
    {
        [Required]
        public string Name { get; set; }
        [Range(18, 60, ErrorMessage = "Age must be in 18 and 60")]
        public int Age { get; set; }
        [EmailAddress]
        public string Email { get; set; }


    }
}
