﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema28_DZ__Работа_с_формулами
{
    public class Contact
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Address}, {PhoneNumber}, {Email}";
        }
    }
}
