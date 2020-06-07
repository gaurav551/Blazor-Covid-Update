using System;
using System.Collections.Generic;

namespace BlazorCrud.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
        public string Picture { get; set; }
        public DateTime DateOfBirth { get; set; }
       
    }

}