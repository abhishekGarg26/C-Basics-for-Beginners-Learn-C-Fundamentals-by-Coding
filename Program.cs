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

            Strings str = new Strings();
            str.general();


            Enums enums = new Enums();
            enums.general();


            ReferenceTypesValueTypes refVal = new ReferenceTypesValueTypes();
            refVal.general();


            var number = 1;
            AgeRecord.Increment(number);
            Console.WriteLine(number);

            var person = new Person() { Age = 20 };
            AgeRecord.MakeOld(person);
            Console.WriteLine(person.Age);


            IfElseSwitch cond = new IfElseSwitch();
            cond.IfElse();
            cond.CondOpr();

            
        }
    }
}