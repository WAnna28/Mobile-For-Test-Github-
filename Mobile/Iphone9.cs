using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    class Iphone9:Appleiphone
    {
        public override string Price()
        {
            return "381$";
        }
        public override string Price(string shop)
        {
            switch (shop)
            {
                case "ebay": return "389$";
                case "AliExpress": return "493$";
                case "amazon": return "381$";
            }
            return "Error";
        }

    }
}
