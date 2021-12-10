using System;
using System.Collections.Generic;
using System.Text;

namespace GroupManagment
{
    public class Group
    {
        public static int Number = 100;
        public string Name;
        public Student[] students = { };
        public Group(string name)
        {
            Name = name;
            Number++;
            Console.WriteLine(Name.Substring(0,1) + Number);
        }
        
        public Student GetStudentByNo(int number)
        {
            foreach (Student student in this.students )
            {
                if (student.number == number)
                {
                    return student;
                }
                
            }
            return null;
        }
    }
}
