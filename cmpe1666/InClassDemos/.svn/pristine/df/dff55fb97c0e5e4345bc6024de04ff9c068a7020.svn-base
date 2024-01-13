using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6Exercise2
{
    internal class Program
    {
        public struct Student
        {
            public string _firstName;
            public string _lastName;
            public double _assignmentMarks;
            public double _examMarks;
            public double _overallMarks;
        }
        static void Main(string[] args)
        {
            Student[] stdArray = new Student[5];


            for (int count=0; count<stdArray.Length; count++)
            {
                Console.WriteLine($"Input Info for student {count + 1}: ");
                stdArray[count] = inputStudent();
                calculateOverallMarks(ref stdArray[count]);
            }

            displayAll(stdArray);

        }

        private static Student inputStudent()
        {
            Student student;

            Console.Write("First Name: ");
            student._firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            student._lastName = Console.ReadLine();
            Console.Write("Exam Marks: ");
            double.TryParse(Console.ReadLine(), out student._examMarks);
            Console.Write("Assignment marks:");
            double.TryParse(Console.ReadLine(), out student._assignmentMarks);
            student._overallMarks = 0;

            return student;
        }

        private static void displayStudent(Student s1)
        {
            Console.Write($"Name: {s1._firstName} {s1._lastName}; Marks: Assignment- {s1._assignmentMarks},");
            Console.WriteLine($"Exams - {s1._examMarks}, Overall- {s1._overallMarks} ");
        }

        private static void calculateOverallMarks(ref Student s1)
        {
            s1._overallMarks = 0.3 * s1._assignmentMarks + 0.7 * s1._examMarks;
        }

        private static void displayAll(Student[] students)
        {
            foreach(Student S in students)
            {
                displayStudent(S);
            }
        }
    }
}
