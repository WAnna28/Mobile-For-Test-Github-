using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    class RedmiNote9S:Xiaomi
    {
        public override string Price()
        {
            return "195$";
        }
        public override string Price(string shop)
        {
            switch (shop)
            {
                case "ebay": return "243$";
                case "amazon": return "234$";
                case "AliExpress": return "195$";
            }
            return "Error";
        }
    }
}
