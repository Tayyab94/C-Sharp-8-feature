#nullable enable warnings

using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;

namespace C_Sharp_New_Features
{
    class Employee
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");


        //    Student student = new Student(1, "Tayyab", 23);

        //    Console.WriteLine(CapatalizedName(student));
        //}
        static void Main1(string[] args)
        {
            //  Console.WriteLine("Hello World!");


            //  Student student = new Student(1,"Tayyab",23);

            //Console.WriteLine(CapatalizedName(student));


            List<int> numbers = new List<int>();

            int? i = null;

            numbers.Add(i ??=34 );
            numbers.Add(i ??= 21);

            Console.WriteLine($"The Value of i = {i}");

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

        }


        static string CapatalizedName(Student model) => model.StudentName?.ToUpper() ?? string.Empty;

        //static string CapatalizedName(student model)
        //{
        //    //if (model.studentName != null)
        //    //    return  model.studentName.ToUpper();
        //    //return "Student Name is Null";

        //    // if you have declare or handle the nullable at the top of the this page then you have to handle the nullable values by addding (?) this question mark
        //    return model.studentName?.ToUpper();
        //}

    }


    public class Student
    {
        public int StuentId { get; set; }

        public string StudentName { get; set; }

        public int RollNo { get; set; }

        public Student(int id,int rolNo)
        {
            this.StuentId = id;
            this.RollNo = rolNo;
            this.StudentName = null;
        }

        public Student(int id,string name, int rolNo)
        {
            this.StuentId = id;
            this.RollNo = rolNo;
            this.StudentName = name;
        }
    }
}
