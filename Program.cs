using HelloWorld.Math;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            dataTypesVariables dtV = new dataTypesVariables();
            dtV.general();

            typeConversion tc = new typeConversion();
            tc.general();

            arithmaticOperators aO = new arithmaticOperators();
            aO.general();


            ClassesDemo cd = new ClassesDemo();
            cd.FirstName = "John";
            cd.LastName = "Smith";
            cd.Introduce();

            Calculator calculator = new Calculator();
            var results = calculator.Add(1, 2);
            Console.WriteLine(results);


            Arrays arrays = new Arrays();
            arrays.general();

            
        }
    }
}