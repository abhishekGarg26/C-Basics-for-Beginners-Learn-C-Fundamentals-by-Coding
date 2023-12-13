using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class StringBuilderMethods
    {
        public void general()
        {
            var builder = new StringBuilder("Hello World");
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));
            Console.WriteLine(builder);

            Console.WriteLine("First Char: " + builder[0]);
            builder[0] = 'd';
            Console.WriteLine("First Char: " + builder[0]);
           /* var name = " ";

            var result = String.IsNullOrEmpty(name);
            Console.WriteLine(result);*/
            var name = "Mosh";

            name.ToUpper();

            Console.WriteLine(name);
        }
    }
}
