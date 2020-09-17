using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    class NokiaX6:Nokia
    {
        public override string Price()
        {
            return "140$";
        }
        public override string Price(string shop)
        {   switch (shop)
            {
                case "ebay": return "164$";
                case "AliExpress": return "140$";
                case "amazon": return "169$";
            }
            return "Error";
        }
    }
}
