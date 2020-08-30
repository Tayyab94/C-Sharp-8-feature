using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Linq;

namespace C_Sharp_New_Features
{

  public enum Month
    {
        Jan=1,
        Feb,Mar,Apri,May,
    }
    class SwCondition
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");

        //    Student1 student = new Student1("Ali", Month.Mar);
        //    Student1 student1 = new Student1("Ali", Month.Mar);
        //    Student1 student2 = new Student1("Ali", Month.Mar);

        //    CheckPrices(student);
        //}

        //public static string CheckPrices(Student1 student)
        //{
        //    return Student switch
        //    {
        //        { }
        //    }
        //}


        public static string checkMonth(Month moths) =>
            moths switch
            {
                Month.Jan => "Sardiyan",
                Month.Feb => "Winder",
                Month.Apri => "Sb kuch",
                Month.Mar => "Chuti",
                Month.May => "Chalo",
                _ => "Invalid"
            };

        //public static string checkMonth(Moths moths)
        //{
        //    switch (moths)
        //    {
        //        case Moths.Jan:
        //            break;
        //        case Moths.Feb:
        //            break;
        //        case Moths.Mar:
        //            break;
        //        case Moths.Apri:
        //            break;
        //        case Moths.May:
        //            break;
        //        default:
        //            break;
        //    }
        //}

    }

    public class Student1
    {

        public Student1(string name, Month moths)
        {
            this.Month = moths;
            this.Name = name;
        }
        public Month Month { get; set; }

        public string Name { get; set; }
    }

}
