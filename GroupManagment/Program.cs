using System;

namespace GroupManagment
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("Mikailov Said");
            Student st2 = new Student("Amrahov Bextiyar");
            Student st3 = new Student("Niftelizade Hezret");

            Group programming = new Group("Programming");
            Group design = new Group("Design");
            programming.students = new Student[] { st };
            design.students = new Student[] { st2, st3 };
            //foreach (Student student in programming.students )
            //{
            //    Console.WriteLine(student.FullName);
            //}
            Console.WriteLine(design.GetStudentByNo(3).FullName);  
        }
    }
}
