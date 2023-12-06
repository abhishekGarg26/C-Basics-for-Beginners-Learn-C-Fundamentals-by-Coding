using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Exercise_1
    {
        public void prgm1()
        {
            Console.WriteLine("Please Enter a Number between "+1 +" to "+ 10);
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((num>=1 && num<10) ? "Valid" : "Invalid");
        }

        public void prgm2()
        {
            Console.WriteLine("Enter two numbers for comparison seperated in two lines");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The greater of two numbers is "+ (num1>num2 ? num1 : num2));
        }

        public void prgm3()
        {
            Console.WriteLine("Enter the height of the Image");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the width of the Image");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The image is in " + (height > width ? ImageOrientation.Potrait : ImageOrientation.Landescape));
        }
        public  enum ImageOrientation
        {
            Landescape,
            Potrait
        }

        public void prgm4()
        {
            Console.WriteLine("Please enter the speed limit");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the speed of the car");
            int carSpeed = Convert.ToInt32(Console.ReadLine());

            int perKmDemeritPts = 5;
            if (carSpeed >= speedLimit)
            {
                int dempts = (carSpeed-speedLimit) / perKmDemeritPts;
                Console.WriteLine((dempts<=12) ? dempts + " Demerit Points Earned." : "License Suspended");
            }
            else
            {
                Console.WriteLine("Ok");
            }

        }
    }
}
