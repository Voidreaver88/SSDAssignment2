using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SSDAssignmentA1.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required, Display(Name = "First Name")]
        public string LastName { get; set; }
        [Display(Name = "Birth Date"), DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

    }
}
