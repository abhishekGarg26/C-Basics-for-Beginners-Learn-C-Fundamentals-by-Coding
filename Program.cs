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
            cond.general();


            Exercise_1 ex1 = new Exercise_1();
            ex1.prgm4();


            Loops loop = new Loops();
            loop.forLoop();
            loop.forEachLoop();
            loop.whileLoop();


            RandomNums randomNum = new RandomNums();
            randomNum.general();


            Exercise_2 ex2 = new Exercise_2();
            ex2.prgm5();


            ArrayTypes arr = new ArrayTypes();
            arr.general();


            Lists list = new Lists();
            list.general();


            Exercise_3 exr3 = new Exercise_3();
            exr3.prgm5();

            DateNTime dateTime = new DateNTime();
            dateTime.dateTm();
            dateTime.Timespn();

            
        }
    }
}