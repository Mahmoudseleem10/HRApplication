using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace HRApplication.Models
{
    public class Employees
    {
        //name
        [Required(ErrorMessage ="Please Enter Name")]
        [StringLength(20,MinimumLength =6)]
        public string EmployeeName { get; set; }
        //department
        [Required(ErrorMessage = "Please select Department")]
        public string Department { get; set; }
        //is active
        public bool isActive { get; set; }
        //Job title
        [Required(ErrorMessage ="Job Title is Missing")]
        public string JobTitle { get; set; }
        //Data of Birth
        
        public DateTime BirthDate { get; set; }
        //Email
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
    }
}
