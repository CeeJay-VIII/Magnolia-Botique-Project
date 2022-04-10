using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectVIII.Models.InputValidations
{
    public class IdNumber : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null)
            {
                string id = (string)value;
                if (int.Parse(id.Substring(2, 2)) > 12 || int.Parse(id.Substring(4, 2)) > 31 || id.Length != 13)
                {
                    return new ValidationResult("Enter a valid ID number!");
                }
            }
            return ValidationResult.Success;
        }
    }
}