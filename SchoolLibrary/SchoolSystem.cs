using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class SchoolSystem
    {
        public static void FillStudentList(List<Student> students)
        {
            students.Add(new Student { Name = "John Doe", ClassAndSection = "10A" });
            students.Add(new Student { Name = "Jane Doe", ClassAndSection = "10B" });
        }

        public static void FillTeacherList(List<Teacher> teachers)
        {
            teachers.Add(new Teacher { Name = "Mr. Smith", ClassAndSection = "10A" });
            teachers.Add(new Teacher { Name = "Ms. Jones", ClassAndSection = "10B" });
        }

        public static void FillSubjectList(List<Subject> subjects, List<Teacher> teachers)
        {
            subjects.Add(new Subject { Name = "Math", SubjectCode = "MATH101", Teacher = teachers.First()});
            subjects.Add(new Subject { Name = "Science", SubjectCode = "SCI101", Teacher = teachers.Last()});
        }

        public static void DisplayStudentList(List<Student> students)
        {
            Console.WriteLine("Student List:");
            foreach (Student student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Class and Section: {student.ClassAndSection}");
            }
        }

        public static void DisplayTeacherList(List<Teacher> teachers)
        {
            Console.WriteLine();
            Console.WriteLine("Teacher List:");
            foreach (Teacher teacher in teachers)
            {
                Console.WriteLine($"Name: {teacher.Name}, Class and Section: {teacher.ClassAndSection}");
            }
        }

        public static void DisplaySubjectList(List<Subject> subjects)
        {
            Console.WriteLine();
            Console.WriteLine("Subject List:");
            foreach (Subject subject in subjects)
            {
                Console.WriteLine($"Name: {subject.Name}, Subject Code: {subject.SubjectCode}, Teacher: {subject.Teacher.Name}");
            }
        }
    }
}
