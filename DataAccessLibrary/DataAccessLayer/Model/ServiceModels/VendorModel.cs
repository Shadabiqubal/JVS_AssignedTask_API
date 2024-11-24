using DataAccessLibrary.DataAccessLayer.Validator;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataAccessLayer.Model.ServiceModels
{
    public class Vendor
    {
        [Key]
        public int VendorId { get; set; }

        public string Code { get; set; } 
        [Required(ErrorMessage = "Status is required.")]
        public bool Status { get; set; }

        [Required(ErrorMessage = "Vendor Type is required.")]
        public int VendorTypeId { get; set; }
        public VendorType? VendorType { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string Name { get; set; }
        [EmailValidator(ErrorMessage = "Invalid email address format.")]
        public string Email { get; set; }
        [PhoneNumberValidator(ErrorMessage = "Invalid phone number format.")]
        [MaxLength(15, ErrorMessage = "Phone number cannot exceed 15 characters.")]
        public string PhoneNumber { get; set; }
        [MaxLength(15, ErrorMessage = "GST number cannot exceed 15 characters.")]
        public string GstNumber { get; set; }
        [MaxLength(200, ErrorMessage = "Address Line 1 cannot exceed 200 characters.")]

        public string AddressLine1 { get; set; }
        [MaxLength(200, ErrorMessage = "Address Line 2 cannot exceed 200 characters.")]
        public string AddressLine2 { get; set; }
        [MaxLength(200, ErrorMessage = "Address Line 3 cannot exceed 200 characters.")]
        public string AddressLine3 { get; set; }

        public int? CountryId { get; set; }
        public Country? Country { get; set; } 

        public int? StateId { get; set; }
        public State? State { get; set; } 

        public int? CityId { get; set; }
        public City? City { get; set; }
        [RegularExpression(@"^\d{5,6}$", ErrorMessage = "Pin Code should be 5-6 digits.")]
        public string PinCode { get; set; }
        [MaxLength(500, ErrorMessage = "Remarks cannot exceed 500 characters.")]
        public string Remarks { get; set; }
    }

}
