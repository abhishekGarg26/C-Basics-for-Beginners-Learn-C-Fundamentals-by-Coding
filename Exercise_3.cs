using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Exercise_3
    {
        public void prgm1()
        {
            var list = new List<string>();
            while (true)
            {
                Console.WriteLine("Please enter a name or press enter to exit");
                var str = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(str)) break;
                list.Add(str);
            }
            if (list.Count == 0) return;
            else if (list.Count == 1) Console.WriteLine(String.Format("{0} likes your post", list[0]));
            else if (list.Count == 2) Console.WriteLine(String.Format("{0} and {1} like your post", list[0], list[1]));
            else Console.WriteLine(String.Format("{0}, {1} and {2} others like your post", list[0], list[1], list.Count-2));
        
        }

        public void prgm2()
        {
            Console.WriteLine("Please Enter Your Name: ");
            var str = Console.ReadLine();
            var arr = new Char[str.Length];
            for(var i = 0; i < str.Length; i++)
            {
                arr[i] = str[i];
            }
            Array.Reverse(arr);
            var newStr = String.Join("",arr);
            Console.WriteLine(newStr);
            
        }

        public void prgm3()
        {
            var arr = new int[5];
            var count = 0;
            while(true)
            {
                Console.WriteLine("Please Enter a Number: ");
                var num =Convert.ToInt32(Console.ReadLine());
                if (num!=0 && arr.Contains(num) == true)
                {
                    Console.WriteLine("Please Re-Try With Different Number");
                    continue;
                }
                arr[count] = num;
                count++;
                if (count == 5) break;
            }
            Array.Sort(arr);
            Console.WriteLine("Sorted Array is: ");
            foreach (var num in arr) Console.WriteLine(num);
        }

        public void prgm4()
        {
            var list = new List<int>();
            while (true)
            {
                Console.WriteLine("Please Enter a number or type Quit to exit: ");
                var str = Console.ReadLine();
                if (str.ToLower() == "quit") break;
                var num = Convert.ToInt32(str);
                if (list.Contains(num)) continue;
                list.Add(num);
            }
            Console.WriteLine("Unique Numbers in the list are");
            foreach(var num in list) Console.WriteLine(num);
        }

        class Comp : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                if (x == 0 || y == 0)
                {
                    return 0;
                }
                return x.CompareTo(y);
            }
        }
        public void prgm5()
        {
            Comp cmp = new Comp();
            while (true)
            {
                Console.WriteLine("Please supply a list of comma seperated numbers: ");
                var list = new List<int>();
                var str = Console.ReadLine();
                var s = "";
                for (var i = 0; i < str.Length; i++)
                {
                    if (str[i] != ',') s += str[i];
                    if (str[i] != ',' && i != str.Length - 1) continue;
                    var num=Convert.ToInt32(s);
                    list.Add(num);
                    s = "";
                }
                if (list.Count < 5)
                {
                    Console.WriteLine("Invalid List. Please Retry !");
                    continue;
                }
                list.Sort(cmp);

                Console.WriteLine(String.Format("3 Smallest Numbers are : {0}, {1} and {2}",list[0],list[1],list[2]));
                break;
            }
        }

    }
}
