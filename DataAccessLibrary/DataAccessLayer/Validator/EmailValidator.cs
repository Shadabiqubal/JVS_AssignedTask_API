using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataAccessLayer.Validator
{
    public class EmailValidator : ValidationAttribute
    {
        public EmailValidator() : base("Invalid email address format.")
        {
            
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null && !string.IsNullOrEmpty(value.ToString()))
            {
                var email = value.ToString();
                if (!new EmailAddressAttribute().IsValid(email))
                {
                    return new ValidationResult("Invalid email address format.");
                }
            }
            return ValidationResult.Success;
        }
    }
}
