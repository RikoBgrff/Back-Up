using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_Up
{
   abstract class Storage
    {

        public string Media { get; set; }
        public int SizeOfMedia { get; set; }
        public int CapacityOfDevice { get; set; }
        public string Model { get; set; }
        public string Interface { get; set; }
        public string Vendor { get; set; }
        public double ReturnMediaSize()
        {
            return SizeOfMedia;
        }
        public virtual void Copy()
        {
           
            Console.WriteLine("Copied");
        }
        public double FreeMemory()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\nFree Space (as GB):");
            return (CapacityOfDevice - (SizeOfMedia * 1000))/1000;
        }
        public void PrintDeviceInfo()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Device Info:");
            Console.WriteLine($"Model:{Model}");
            Console.WriteLine($"Vendor:{Vendor}");
            Console.WriteLine($"Capacity:{CapacityOfDevice/1000}gb\n");
            Console.ResetColor();
        }
    }
}
