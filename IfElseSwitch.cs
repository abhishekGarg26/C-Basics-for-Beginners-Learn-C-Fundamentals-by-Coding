using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public partial class IfElseSwitch
    {
        public void IfElse()
        {
            int hour = 10;

            if(hour>0 && hour < 12)
            {
                Console.WriteLine("Its morning");
            }
            else if(hour>=12 && hour < 18)
            {
                Console.WriteLine("Its afternoon");
            }
            else
            {
                Console.WriteLine("Its evening");
            }

        }

        public void CondOpr()
        {
            bool isGoldCustomer = true;
            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);
        }

        public void general()
        {
            var season = Season.Autumn;
            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We've got promotion");
                    break;
                default:
                    Console.WriteLine("I don't understand that season!");
                    break;
            }
        }

    }
}
