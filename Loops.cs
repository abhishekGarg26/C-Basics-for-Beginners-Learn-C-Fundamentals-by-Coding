﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Loops
    {
        public void forLoop()
        {
            // for loop
            for(var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for(var i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void forEachLoop()
        {
            var name = "John Smith";
            for(var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            foreach(var character in name)
            {
                Console.WriteLine(character);
            }

            var numbers = new int[] { 1, 2, 3, 4 };
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void whileLoop()
        {
            while (true)
            {
                Console.Write("Type your name:");
                var input = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                break;
            }
        }
    }
}
