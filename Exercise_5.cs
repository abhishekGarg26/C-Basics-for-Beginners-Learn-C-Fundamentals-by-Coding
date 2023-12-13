using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HelloWorld
{
    class Exercise_5
    {
        public string[] fileReading(string path)
        {
            if (path == null)
                throw new ArgumentNullException("path", "Path can not be null.");
            if (File.Exists(path))
            {
                var content = File.ReadAllText(path);
                return content.Split(' ');
            }
            else
            {
                Console.WriteLine("File Not Found..");
            } 

            return new string[0];
        }
        public void prgm1()
        {
            var path = @"D:\CSharpFundamentals\Test.txt";
            var srr = fileReading(path);
            Console.WriteLine("Number of words in file are: " + srr.Length);

        }

        public void prgm2()
        { 
             var path = @"D:\CSharpFundamentals\Test.txt";
            
                 var srr = fileReading(path);
                var lastLongest = "";
                foreach(var s in srr)
                {
                    if (s.Length > lastLongest.Length)
                        lastLongest = s;
                }
            Console.WriteLine("Longest word in the file is: " + lastLongest);
            
        }
    }
}
