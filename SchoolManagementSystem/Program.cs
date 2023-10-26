using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolLibrary;

namespace SchoolManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Student> students = new List<Student>();
            List<Teacher> teachers = new List<Teacher>();
            List<Subject> subjects = new List<Subject>();
           
            SchoolSystem.FillStudentList(students);
            SchoolSystem.FillTeacherList(teachers);
            SchoolSystem.FillSubjectList(subjects);

            SchoolSystem.DisplayStudentList(students);
            SchoolSystem.DisplayTeacherList(teachers);
            SchoolSystem.DisplaySubjectList(subjects);

            Console.ReadLine();
        }
    }
}
