using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace Mobile
{
    class Program
    {
        static void Main(string[] args)
        {

            var iphone9 = new Iphone9();
            Console.WriteLine("Your phone is Iphone9");
            Print(iphone9);
            string iphone_path = "iphone9.txt";
            string Json_iphone_s = JsonSerializer.Serialize(iphone9);
            JsonSerialization(iphone_path, Json_iphone_s);
            var new_iphone9 = new Iphone9();
            string Json_iphon_d = File.ReadAllText(iphone_path);
            new_iphone9 = JsonSerializer.Deserialize<Iphone9>(Json_iphon_d);


            //var nokiaX6 = new NokiaX6();
            //Console.WriteLine("Your phone is NokiaX6");
            //Print(nokiaX6);
            //var redmiNote9S = new RedmiNote9S();
            //Console.WriteLine("Your phone is RedmiNote9S");
            //Print(redmiNote9S);
        }
        static void Print(Mobile mobile)
        {

            {

                Console.WriteLine("Price in ebay {0}", mobile.Price("ebay"));
                Console.WriteLine("Price in AilExpress {0}", mobile.Price("AliExpress"));
                Console.WriteLine("Price in amazon {0}", mobile.Price("amazon"));
                Console.WriteLine("Minimum price is {0}", mobile.Price());
                Console.WriteLine("OS is {0}", mobile.OS());
            }
        }
        static void JsonSerialization(string path, string Jsonstring)
        {

            File.WriteAllText(path, Jsonstring);
            Console.WriteLine("It's serialized in Json format");
        }
    }
}
