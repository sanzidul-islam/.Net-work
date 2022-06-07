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
        public string Name { set; get; }
        [Required]
        [Range(0,50)]
        public string Id { set; get; }
        [Required]
        public string Dob { set; get; }

    }
}