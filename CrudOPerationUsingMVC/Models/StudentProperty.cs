﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudOPerationUsingMVC.Models
{
    public class StudentProperty
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
    }
}