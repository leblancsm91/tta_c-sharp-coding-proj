﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_Drill1
{
    public class Person
    {
        string FirstName;
        string LastName;

        public void SayName()
        {
            string FullName = FirstName + LastName;
            Console.WriteLine("Name: " + FullName);
            Console.ReadLine();
        }
    }
}
