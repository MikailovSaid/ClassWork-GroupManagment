using System;
using System.Collections.Generic;
using System.Text;

namespace GroupManagment
{
    public class Student
    {
        public static int Number = 0;
        public int number;
        public string FullName;

        public Student(string fullName)
        {
            FullName = fullName;
            Number++;
            number = Number;
            Console.WriteLine(Number + " " + FullName);

        }

       
    }
}
