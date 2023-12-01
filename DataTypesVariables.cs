
using System;

namespace HelloWorld
{
    public class dataTypesVariables
    {
        public void general()
        {
            Console.WriteLine("Hello World");

            //DataTypes & Variables

            byte number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'A';
            var firstName = "Mosh";
            var isWorking = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            const float Pi = 3.14f;

            Console.WriteLine(character);
            Console.WriteLine(Pi);
        }

    }
}