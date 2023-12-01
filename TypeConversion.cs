using System;

namespace HelloWorld
{
	public class typeConversion
	{
		public void general()
        {
            byte k = 1;
            int i = k;
            Console.WriteLine(i);

            int t = 1000;
            byte b = (byte)t;
            Console.WriteLine(b);

            string s = "255";
            byte h = byte.Parse(s);
            Console.WriteLine(h);

            try
            {
                var number = "1234";
                byte u = Convert.ToByte(number);
                Console.WriteLine(u);

                string str = "true";
                bool p = Convert.ToBoolean(str);
                Console.WriteLine(p);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }
        }
	}
}