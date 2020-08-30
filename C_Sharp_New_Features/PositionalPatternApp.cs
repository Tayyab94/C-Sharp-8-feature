using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_New_Features
{
    class PositionalPatternApp
    {
        static void Main(string[] args)
        {


            int val = 12;
            //var result = val switch
            //{
            //    1 => "Case 1",
            //    _ => "Invalid"
            //};


            Points points = new Points(0, 12);

            Console.WriteLine(PositionShap(points));


            Console.ReadKey();

            Console.WriteLine("_________________________");

            Po po = new Po();
            po.X = 23;
            po.Y = 45;

            Console.WriteLine(po.DisplayPosition());

            Console.ReadKey();

            string firstName = "Tayyab";
            string lastName = " hatti";

            Console.WriteLine(GetName(firstName, lastName));


            static string GetName(string fName, string lName) => fName + " " + lName;


            var cities = new string[]
            {
                "ABc",
                "ASda",
                "asdag",
                "asdag"
            };

            //[1..3] (starting index, 2 dots, ending)
            // if you wana to copy complet then 2 dots [..]
            var copyString = cities[0..4];

            foreach (var item in copyString)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            Console.WriteLine("_________________");

            var care = new string[]
            {
                "Car1",
                "Car2",
                "Car3",
                "Car4",
                "Car5",
                "Car6",
                "Car7",
                
            };

            Console.WriteLine($"Las item of arrry {care[care.Length - 1]}");
            Console.WriteLine($"Las item of arrry {care[^(2+1)]}");


            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(5);
            numbers.Add(6);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(numbers[^1]);


            Console.ReadKey();

            string address = "I am from gujranawal\n i live in pakisan";

            string newAddress = @"I am Tayyab
 and i live in gujranal
this is my complete Address";


            Console.WriteLine(address);
            Console.WriteLine(newAddress);
        }

        public static string PositionShap(Points points) =>
            points switch
            {
                (0, 0) => "Its Origin Position",
                var (x, y) when x > 0 && y > 0 => $" Current Possition is {x}, {y}",
                var (x, y) when x == 0 && y > 0 => $" Current Possition is {x}, {y}",
                var (x, y) when x > 0 && y == 0 => $" Current Possition is {x}, {y}",

                _ => "Unknown Positi ons"
            };



    }


    public class Points
    {
        public Points(int x, int y) => (X, Y) = (x, y);

        public int X { get; set; }

        public int Y { get; set; }


        public double Distance => Math.Sqrt(X * X + Y * Y);

        public void Deconstruct(out int x, out int y) => (x, y) = (X, Y);
    }

    public struct Po
    {
        public int X { get; set; }

        public int Y { get; set; }


        public readonly double Distance => Math.Sqrt(X * X + Y * Y);

        public readonly string DisplayPosition() =>
            $"{X},{Y} is the {Distance} from Origion";
    }

}
