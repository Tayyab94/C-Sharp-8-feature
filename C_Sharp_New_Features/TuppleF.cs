using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_New_Features
{
    class TuppleF
    {
        static void Main1(string[] args)
        {
            Console.WriteLine(checkCountrybyCity("Pakistan", "Multan"));

            Console.WriteLine(checkCountrybyCity("Pakistan",""));

            Console.ReadKey();
        
        }


        public static string checkCountrybyCity(string country, string city) =>
            (country, city) switch
            {
                ("Pakistan", "Lahore") => string.Format("Acha Country {0}",country),
                ("Pakistan","Islamabad")=>$"Best Calmn country {country}",
                ("Pakistan","Multan")=>$"Hot City {city} of this Country {country}",
                ("Pakistan",_)=>"Only Pakistan",
                (_, _) => $"Invalid {country} & {city}"
            };
    }
}
