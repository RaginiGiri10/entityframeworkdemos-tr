using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstApproach
{
    class Program
    {
        static void Main(string[] args)
        {

            StudentRepository studentRepository = new StudentRepository();



            //Console.WriteLine("Get all student records");
            //Console.WriteLine("********************************");

           

            //var students = studentRepository.GetAllStudents();

            //foreach(var student in students)
            //{
            //    Console.WriteLine($"Id -{student.id}, FullName ={student.FirstName},{student.LastName},Age ={student.Age}");
            //}



            // Add Student record

            Student firstStudent = new Student();
            firstStudent.FirstName = "Riyan";
            firstStudent.LastName = "Riyan";
            firstStudent.Age = 22;
            studentRepository.AddStudent(firstStudent);

            Console.ReadLine();
        }
    }
}
