﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class DateNTime
    {
        public void dateTm()
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine(today);

            Console.WriteLine("Hour: "+now.Hour);
            Console.WriteLine("Minute: "+now.Minute);

            var tomrrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

        }

        public void Timespn()
        {

            //Creating
            var timeSpan = new TimeSpan(1, 2, 3);
            Console.WriteLine(timeSpan);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);
            Console.WriteLine(timeSpan1);
            Console.WriteLine(timeSpan2);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Durarion: "+duration);

            //Properties
            Console.WriteLine("Minutes: "+timeSpan.Minutes);
            Console.WriteLine("Total Minutes: "+timeSpan.TotalMinutes);

            //Add
            Console.WriteLine("Add Example: "+ timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example: "+timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //ToString
            Console.WriteLine("ToString: "+timeSpan.ToString());

            //Parse
            Console.WriteLine("Parse: "+TimeSpan.Parse("01:02:03"));

        }
    }
}
