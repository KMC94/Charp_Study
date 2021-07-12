using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Name = "김민철",
                Birthday = new DateTime(1994, 6, 11),
                Grade = 6,
                ClassNumber = 8,
            };

            Console.WriteLine($" 이름 : {student.Name} \n 생일 : {student.Birthday} \n 학년 : {student.Grade} \n 반 : {student.ClassNumber} \n");

            Person person = new Student();
            if (person is Student)
                Console.WriteLine("person is Student");

            object studentObj = new object();
            if (studentObj is Object)
                Console.WriteLine("obj is Student");
        }
    }
}
