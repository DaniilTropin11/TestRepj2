﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyBaseConsole.DataModel
{
  
    
    public class Student
    {
        public int StudentId { get; set; }
        
        public string Name { get; set; }
        
        public string Surname { get; set; }
       
    }

}
