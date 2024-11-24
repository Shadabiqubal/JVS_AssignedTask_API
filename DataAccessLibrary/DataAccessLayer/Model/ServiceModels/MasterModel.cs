using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataAccessLayer.Model.ServiceModels
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class State
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }

    public class City
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
    }

    public class VendorType
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
    }


}
