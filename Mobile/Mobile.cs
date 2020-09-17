using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
   abstract class Mobile
    {
        public abstract string Price();
        public abstract string Price(string shop);
        public abstract string OS();
    }
}
