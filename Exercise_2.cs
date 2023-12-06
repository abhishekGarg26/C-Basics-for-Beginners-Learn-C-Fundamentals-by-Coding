using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Exercise_2
    {
        public void prgm1()
        {
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                    Console.WriteLine();
                }
            }

        }

        public void prgm2()
        {
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number or write Ok to Exit");
                var num = Console.ReadLine();
                try
                {
                    if (num.ToLower() != "ok")
                    {
                        sum += Convert.ToInt32(num);
                        continue;
                    }
                    throw new Exception();
                }
                catch
                {
                    Console.WriteLine("Sum of previously entered numbers is " + sum);
                    break;
                }
            }
        }

        public int fact(int num)
        {
            if (num == 1) return num;
            return num * fact(num - 1);
        }
        public void prgm3()
        {
            Console.WriteLine("Please Enter a number to find factorial of");
            var num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num+"! = "+fact(num));
        }
         public void prgm4()
        {
            var random = new Random();
            var num = random.Next(1, 10);
            var flag = false;
            //Console.WriteLine(num);
            try
            {
                for (var i = 0; i < 4; i++)
                {
                    Console.WriteLine("Guess a number between 1 to 10");
                    var numToCheck = Convert.ToInt32(Console.ReadLine());
                    if (num == numToCheck)
                    {
                        flag = true;
                        Console.WriteLine("You Won");
                        break;
                    }
                }
            }
            catch {
                Console.WriteLine("Invalid Input");
            }
            if (!flag) Console.WriteLine("You Lost");
        }

        public void prgm5()
        {
            var maxi = -1;
            var str = "";
            try
            {
                Console.WriteLine("Please Enter a series of positive numbers seperated by Commas");
                var series = Console.ReadLine();
                for (var i = 0; i < series.Length; i++)
                {
                    // We also use input.Split(',') method to split the string
                    char ch = series[i];
                    if (ch != ',') str += ch;
                    if (ch != ',' && i != series.Length - 1) continue;
                    var numi = Convert.ToInt32(str);
                    if (numi > maxi) maxi = numi;
                    str = "";
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
            if (maxi != -1) Console.WriteLine("Maximum Number of the series is: " + maxi);

        }
    }
}
