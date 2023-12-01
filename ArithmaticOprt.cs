using System;

namespace HelloWorld
{
    public class arithmaticOperators
    {
        public void general()
        {
            var a = 1;
            var b = 2;
            var c = 3;
            Console.WriteLine((float)a / (float)b);
            Console.WriteLine((a+b)*c);
            Console.WriteLine(a>b);
            Console.WriteLine(a==b);
            Console.WriteLine(!(a!=b)); // same as a==b
            Console.WriteLine(!(a!=b)==(a==b));
            Console.WriteLine(!(c>b || c==a));
        }
    }
}
