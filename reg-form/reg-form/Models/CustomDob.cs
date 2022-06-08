﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace reg_form.Models
{
    public class CustomDob:ValidationAttribute

    {
        int _minimumAge;
        public CustomDob(int minimumAge)
        {
            _minimumAge = minimumAge;
        }
        public override bool IsValid(object value)
        {
            DateTime date;
            if(DateTime.TryParse(value.ToString(), out date))
                
              {
                return date.AddYears(_minimumAge) < DateTime.Now;

            }
            return false;
        }

    }
}