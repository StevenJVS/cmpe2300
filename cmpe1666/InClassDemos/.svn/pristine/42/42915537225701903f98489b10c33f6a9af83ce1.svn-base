/*CMPE 1666- Lecture11-Demo4
 * 
 * Illustrating the use of a Comparison helper method
 * to sort a List of a struct type in a chosen order
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11Demo4
{  
    internal class Program
    {
        private struct Student
        {
            public int studentId;
            public string firstName;
            public string lastName;

            public Student(int Id, string FName, string LName)
            {
                studentId = Id;
                firstName = FName;
                lastName = LName;
            }

            public override string ToString()
            {
                return $"Student Id: {studentId}, Name: {firstName} {lastName}";
            }
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            students.Add(new Student(23, "Jenniffer", "Farmer"));
            students.Add(new Student(32, "Harry", "Garcia"));
            students.Add(new Student(18, "Mary", "Cooper"));
            students.Add(new Student(41,"Fernando","Fisher"));
            students.Add(new Student(43, "Gavin", "Faraday"));
            students.Add(new Student(22, "Ronaldo", "Watt"));

            //Displaying the list before the sorting
            Console.WriteLine("Initial Student List");
            foreach(Student stud in students)   
                Console.WriteLine(stud);

            Console.WriteLine();

            //Perform the sorting in the order determined by SortOnIdDesc
             students.Sort(SortOnIdDesc);

            //Display the Sorted List
            Console.WriteLine("List After Sorting");
            foreach (Student stud in students)
                Console.WriteLine(stud);



        }


        /**
         * SortOnIdDesc() is a helper method to be used as parameter to List.Sort()
         * It will determine the sorting order.
         * In this case, we want descending order of studentId,
         * if S1.studentId > S2.studentId, S1 must come before S2 in the sorting, so it should return -1
         * if if S1.studentId < S2.studentId, S1 must come after S2 in the sorting, so it should return 1
         * if both are equal, it returns 0
         */
      static private int SortOnIdDesc(Student S1, Student S2)
        {
            if (S1.studentId > S2.studentId)
                return -1;
            if (S1.studentId < S2.studentId)
                return 1;
            return 0;            
        }


    }
}
