using Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Employee
    {
        // class containing the properties of an employee
        #region Properties
        [Key]
        public int Id { get; set; }
        [Display(Name = "Voornaam")]
        public string FirstName { get; set; }
        [Display(Name = "Achternaam")]
        public string LastName { get; set; }
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Display(Name = "Telefoonnummer")]
        public string Phone { get; set; }
        [Display(Name = "Type contract")]
        public EmployeeRole Role { get; set; }
        #endregion
    }
}
