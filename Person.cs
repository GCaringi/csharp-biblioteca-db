﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca_db
{
    public class Person
    {
        public string Name { get; }
        public string Surname { get; }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

    }
}
