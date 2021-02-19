using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Back_Up
{
    class Program
    {
        static void Main(string[] args)
        {
            SSD ssd = new SSD
            {
                Media = "Fast and Furious 3 Tokyo Drift",
                SizeOfMedia = 2,
                Model = "A400",
                CapacityOfDevice = 120000,
                Interface = "SATA",
                Vendor = "Kingston"
            };
            DVD dvd = new DVD
            {
                Media = "American HipHop 90's Mixed",
                Model = "C450",
                SizeOfMedia = 3,
                CapacityOfDevice = 4750,
                Interface = "SATA",
                Vendor = "Samsung"
            };
            HDD hdd = new HDD
            {
                Media = "Rent a Car Project",
                Model = "WIDE BLUE",
                SizeOfMedia = 2,
                CapacityOfDevice = 1000000,
                Interface = "SATA",
                Vendor = "BARRACUDA"
            };
            Flash flash = new Flash
            {
                Media = "Grand Theft Auto Vice City",
                Model = "Cruzer Edge",
                SizeOfMedia = 1,
                CapacityOfDevice = 32000,
                Interface = "USB",
                Vendor = "San Disk"
            };
            Console.WriteLine("SSD:1");
            Console.WriteLine("HDD:2");
            Console.WriteLine("DVD:3");
            Console.WriteLine("Flash:4");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                ssd.PrintDeviceInfo();
                ssd.Copy();
                Console.WriteLine(ssd.FreeMemory());
            }
            if (choice == "2")
            {
                hdd.PrintDeviceInfo();
                hdd.Copy();
                Console.WriteLine(hdd.FreeMemory());
            }
            if (choice == "3")
            {
                dvd.PrintDeviceInfo();
                dvd.Copy();
                Console.WriteLine(dvd.FreeMemory());
            }
            if (choice == "4")
            {
                flash.PrintDeviceInfo();
                flash.Copy();
                Console.WriteLine(flash.FreeMemory());
            }
        }
    }
}
