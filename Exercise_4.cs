using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Exercise_4
    {
        public void prgm1()
        {
            Console.WriteLine("Please Enter a few numbers seperated by hyphen");
            var str = Console.ReadLine();
            var srr = str.Split("-");
            var last = -1;
            bool ascending = false;
            bool descending = false;
            foreach(var s in srr)
            {
                if (last == -1)
                {
                    last = Convert.ToInt32(s);
                    var num = Convert.ToInt32(srr[1]);
                    if (last + 1 == num) ascending = true;
                    else if (last - 1 == num) descending = true;
                    continue;
                }
                var cur = Convert.ToInt32(s);
                if ((!ascending && !descending) || 
                    (ascending && last+1 != cur) || (descending && last-1!=cur))
                {
                    Console.WriteLine("Not Consecutive");
                    last = -1;
                    break;
                }
                last = cur;

            }
            if (last != -1) Console.WriteLine("Consecutive");

        }

        public void prgm2()
        {
            Console.WriteLine("Please Enter a few numbers seperated by hyphen");
            var str = Console.ReadLine();
            if (String.IsNullOrEmpty(str)) return;
            var srr = str.Split("-");
            var list = new List<int>();
            foreach(var s in srr)
            {
                var num = Convert.ToInt32(s);
                if (list.Contains(num))
                {
                    Console.WriteLine("Duplicate");
                    break;
                }
                list.Add(num);
            }

        }

        public void prgm3()
        {
            Console.WriteLine("Please Enter a time value in 24-hour format (e.g. 19:00)");
            var str = Console.ReadLine();
            try
            {
                var time = DateTime.Parse(str);
                Console.WriteLine("Ok");
            }
            catch
            {
                Console.WriteLine("Invalid Time");
            }
        }

        public void prgm4()
        {
            Console.WriteLine("Enter a few words seperated by space : ");
            var str = Console.ReadLine();
            var newStr = new StringBuilder();
            bool flag = true;
            for(var i=0;i<str.Length;i++)
            {
                if(str[i]==' ' && flag==false && i!=0)
                {
                    flag = true;
                }
                else if (flag == true)
                {
                    newStr.Append(str[i].ToString().ToUpper());
                    flag = false;
                }
                else
                {
                    newStr.Append(str[i].ToString().ToLower());
                }
                // char.ToUpper(word[0]) + word.ToLower().Substring(1);
            }
            Console.WriteLine("Formatted String to a variable name using PascalCase is: "+newStr);
        }

        public void prgm5()
        {
            Console.WriteLine("Please Enter a English word:");
            var str = Console.ReadLine().ToLower();
            var cnt = 0;
            var vowels = new List<char>(new char[] { 'a', 'e', 'i', 'o', 'u' });
            foreach(var s in str)
            {
                if(vowels.Contains(s))
                {
                    cnt++;
                }
            }
            Console.WriteLine("Count of vowels is: "+cnt);
        }
    }
}
