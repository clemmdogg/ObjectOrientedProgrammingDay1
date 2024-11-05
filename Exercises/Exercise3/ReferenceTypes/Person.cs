using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingDay1.Exercises.Exercise3.ReferenceTypes
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double BMI { get; set; }
        public Person( string firstName, string lastName, double height, double weight)
        {
            FirstName = firstName;
            LastName = lastName;
            Height = height;
            Weight = weight;
            BMI = weight / (height * height);
        }
    }
}
