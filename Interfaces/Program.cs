﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        int FirstName { get; set; } 
        int LastName { get; set; }      

    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set;}
        public string Adress {  get; set; } 
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public string Departmant { get; set; }
    }
}
