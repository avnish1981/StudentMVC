﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IdentityOwinWebApp.Demo.Models
{
    public class Login
    {

          //[Display(Name = "Email")]
        public string UserName { get; set; }
        public string  Password { get; set; }
    }
}