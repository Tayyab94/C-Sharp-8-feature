using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.WindowsRuntime;

namespace C_Sharp_New_Features
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //}
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello World!");

            ICar car = new Car();
            car.Run();
           Console.WriteLine($"New Car sped is {car.Run(12)}");

            Car d = new Car();

            d.Run(23);
            Console.WriteLine($"New Car sped is {((ICar)d).Run(23)}");


            Console.ReadKey();

        }
    }


    public class Car : ICar
    {
        public void Run()
        {
            Console.WriteLine("Car is Running in Car Class");
        }

        public string Run(int sp)
        {
            return $"new Car speed {sp}";
        }
    }

    public interface ICar
    {
        public void Start() => Console.WriteLine("Car is Going to Start");
        public void Run();


        public int Run(int sped)
        {
            return sped;
        }
    }
}
