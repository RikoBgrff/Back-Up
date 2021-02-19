using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_Up
{
    class NotEnoughSpaceException:ApplicationException
    {
        public NotEnoughSpaceException(string message) : base(message) { }
    }
}
