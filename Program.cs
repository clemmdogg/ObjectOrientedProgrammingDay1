using ObjectOrientedProgrammingDay1.Exercises.Exercise3.ReferenceTypes;
using ObjectOrientedProgrammingDay1.Exercises.Exercise3.ValueTypes;

namespace ObjectOrientedProgrammingDay1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeText = @"It's important to understand two fundamental points about the type system in .NET It supports
                    the principle of inheritance.Types can derive from other types, called base types.The derived type 
                    inherits (with some restrictions) the methods, properties, and other members of the base type.The base 
                    type can in turn derive from some other type, in which case the derived type inherits the members of 
                    both base types in its inheritance hierarchy.All types, including built-in numeric types such as 
                    System.Int32(C# keyword: int), derive ultimately from a single base type, which is System.Object (C# 
                    keyword: object). This unified type hierarchy is called the Common Type System (CTS). For more 
                    information about inheritance in C#, see Inheritance. Each type in the CTS is defined as either a value 
                    type or a reference type.These types include all custom types in the.NET class library and also your 
                    own user-defined types.Types that you define by using the struct keyword are value types; all the 
                    built-in numeric types are structs.Types that you define by using the class or record keyword are 
                    reference types.Reference types and value types have different compile-time rules, and different 
                    run-time behavior. The following illustration shows the relationship between value types and reference 
                    types in the CTS.";
            string typeWord = "type";
            Exercise1.PrintNumberOfTimes(typeText, typeWord);
            Console.WriteLine($"Simons BMI-tal er {Measurement.BMICalculator(78, 1.80)}");
            Console.ReadKey();
            Person Simon = new Person("Simon", "Heilbuth", 1.80, 78);
            Console.WriteLine($"Navnet er {Simon.FirstName} {Simon.LastName}.");
            Console.WriteLine($"Højden er {Simon.Height}.");
            Console.WriteLine($"Højden er {Simon.Weight}.");
            Console.WriteLine($"BMI er {Simon.BMI}.");
            Console.ReadKey();
        }
    }
}
