using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HelloWorld
{
    class PathClass
    {
        public void general()
        {
            var path = @"C:\Projects\CSharpFundamentals\HelloWorld\HelloWorld.sln";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);
            // Console.WriteLine(extension);

            Console.WriteLine("Extension: "+Path.GetExtension(path));
            Console.WriteLine("FileName: "+Path.GetFileName(path));
            Console.WriteLine("File Name Without Extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: "+Path.GetDirectoryName(path));
        }
    }
}
