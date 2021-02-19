using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Back_Up
{
    class HelperClass
    {
        public void Copying()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Event Started");
            Console.WriteLine("Checking for Enough Space");
            Console.WriteLine("Calculating Estimated Finish Time");
            Thread.Sleep(2000);

        }
    }
}
