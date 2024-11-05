using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingDay1.Exercises.Exercise3.ValueTypes
{
    internal class Measurement
    {
        public static double BMINumber;
        public static double BMICalculator(double weight, double height)
        {
            BMINumber = weight/(height * height);
            return BMINumber;
        }
    }
}
