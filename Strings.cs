using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Strings
    {
        public void general()
        {
            var firstName = "Mosh";
            String lastName = "Hamendani";
            string myName="Moshi";

            var fullName = firstName + " " + lastName;
            var myFullNmae = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(myFullNmae);


            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);


            var text = @"Hi John\nLook into the following paths 
                        c:\folder1\folder2
                        c:\folder3\folder4";
            Console.WriteLine(text);

            Int32 i;
            int j;


        }
    }
}
