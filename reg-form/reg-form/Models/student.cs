using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace reg_form.Models
{
    public class student
    {
        [Required]
        [StringLength(40)]
        [RegularExpression("^[a-zA-Z]*$")]
        public string Name { set; get; }
        [Required]
        [Range(0,50)]
        
        public string Id { set; get; }
        [Required]
        [CustomDob(18)]
        [DataType(DataType.Date),DisplayFormat]
        public string Dob { set; get; }
        [Required]
        [MinLength(9,ErrorMessage ="Minium 8 character is required")]
        public string password { set; get; }
        [Required]
        [Compare("password", ErrorMessage ="password does not match,try again !!")]
        public string confirmpassword { set; get; }
        [Required]
        [EmailAddress]
        public string email { set; get; }


    }
}