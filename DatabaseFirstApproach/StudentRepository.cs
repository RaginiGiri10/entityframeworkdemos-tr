using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstApproach
{
    class StudentRepository
    {

        public List<Student> GetAllStudents()
        {
            List<Student> studentList = null;
            using (StudentDBEntities studentDBEntities = new StudentDBEntities())
            {
                studentList = new List<Student>();
                studentList = studentDBEntities.Students.ToList();
            }

            return studentList;
        }

        public void AddStudent(Student student)
        {
            using (StudentDBEntities studentDBEntities = new StudentDBEntities())
            {
                studentDBEntities.Students.Add(student);
                studentDBEntities.SaveChanges();
            }
        }
    }
}
