using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_Up
{
    class HDD : Storage
    {
        HelperClass helper = new HelperClass();
        public override void Copy()
        {

            int time = 0;
            int mb = SizeOfMedia * 1000;
            if (mb > CapacityOfDevice)
            {
                throw new NotEnoughSpaceException("File is too large");
            }
            else
            {
                helper.Copying();
                time = mb / 150;
                Console.WriteLine($"Remaining Time:{time} seconds");
            }
        }

    }
}
