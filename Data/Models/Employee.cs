using Data.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Employee: IdentityUser
    {
        // class containing the properties of an employee
        #region Properties
        [Display(Name = "Voornaam")]
        public string FirstName { get; set; }
        [Display(Name = "Achternaam")]
        public string LastName { get; set; }
        [Display(Name = "Telefoonnummer")]
        public string Phone { get; set; }
        [Display(Name = "Type contract")]
        public EmployeeRole Role { get; set; }
        // for each user a list of availabilities is saved
        public ICollection<Availability> Availabilities { get; set; }
        #endregion
    }
}
