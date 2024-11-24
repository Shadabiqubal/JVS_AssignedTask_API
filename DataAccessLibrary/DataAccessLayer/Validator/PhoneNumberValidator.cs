using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataAccessLayer.Validator
{
    public class PhoneNumberValidator : ValidationAttribute
    {
        public PhoneNumberValidator() : base("Invalid phone number format.")
        {
            
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null && !string.IsNullOrEmpty(value.ToString()))
            {
                var phoneNumber = value.ToString();
                var phoneRegex = new Regex(@"^\+?[1-9]\d{1,14}$");  

                if (!phoneRegex.IsMatch(phoneNumber))
                {
                    return new ValidationResult("Invalid phone number format.");
                }
            }

            return ValidationResult.Success;
        }
    }
}
