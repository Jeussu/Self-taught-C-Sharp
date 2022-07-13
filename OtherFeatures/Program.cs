using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OtherFeatures
{
    //Demo StringInterporation

    internal class Program
    {
        static void Main(string[] args)
        {
            
            Employee e = new Employee();
            e.Email = "@fjskaj";

            ValidationContext validationContext = new ValidationContext(e, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();

            bool valid = Validator.TryValidateObject(e, validationContext, validationResults, true);
            if (!valid)
            {
                foreach (var vr in validationResults)
                {
                    Console.WriteLine(vr.ErrorMessage);
                }
            }
            Console.ReadKey();
        }
    }
}
