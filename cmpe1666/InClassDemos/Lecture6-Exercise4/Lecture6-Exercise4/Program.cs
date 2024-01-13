using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6_Exercise4
{
    internal class Program
    {  private struct Student
        {
            public int StdId;
            public string firstName;
            public string lastName;

            public Student(int Id, string fName, string lName)
            {
                StdId = Id;
                firstName = fName;
                lastName = lName;
            }
        }
        static void Main(string[] args)
        {  List<Student> students = new List<Student>();
            int stdId;
            string fName;
            string lName;
            Student minIdStd;
            Student maxIdStd;

            //Inputting Information and building the list
            for (int count=0; count <5; count++)
            {
                Console.WriteLine($"Input info for student {count + 1}:");
                Console.Write("Student Id: ");
                int.TryParse(Console.ReadLine(),out stdId);
                Console.Write("First name: ");
                fName= Console.ReadLine();  
                Console.Write("Last Name: ");
                lName= Console.ReadLine();
                students.Add(new Student(stdId, fName, lName)); 
                Console.WriteLine();
            }


            //Displaying the info for all students
            //Note hower that for this exercise, this part was not required
            Console.WriteLine("List of Students is: ");
             foreach(Student student in students)
                display(student);

            Console.WriteLine();
             

            //Finding and displaying the Students with Minimum and Maximum Id values
            minIdStd = MinId(students);
            maxIdStd = MaxId(students);

            Console.Write("Student with Minimum Id: ");
            display(minIdStd);

            Console.Write("Student with Maximum Id: ");
            display(maxIdStd);
        }

        private static void display(Student s1)
        {
            Console.WriteLine($"Id:{s1.StdId}, First Name:{s1.firstName}, Last Name:{s1.lastName}");
        }

        /*MaxId() searches for the student with Maximum Id in a provided list
         * It essentially iterates through the list, performing a linear search
         * Parameter: list - a list of Student struct to serach
         * returns: the Student struct containing the maximum ID among the Id values in the list
         * 
         */
        private static Student MaxId(List<Student> list)
        {  //struct to keep track of the student with maxID
            Student maxIdStudent=list[0];//We initially assume that the
                                         //the first element in the list contains the maximum 
                                         //Id Value
          
            //Then we iterate through the list and each time we find a struct 
            // with a higher ID value, we set our maxStudent to refer (point) to
            //that element of the list

            foreach (Student student in list)
            {
                if (student.StdId > maxIdStudent.StdId)
                    maxIdStudent = student;
            }

            return maxIdStudent;

        }

        /*MinId() searches for the student with Minimum Id in a provided list
         * It essentially iterates through the list, performing a linear search
         * Parameter: list - a list of Student struct to serach
         * returns: the Student struct containing the maximum ID among the Id values in the list
         * 
         */
        private static Student MinId(List<Student> list)
        {  //struct to keep track of the student with minID
            Student minIdStudent = list[0];//We initially assume that the
                                           //the first element in the list contains the minimum
                                           //Id value

            //Then we iterate through the list and each time we find a struct 
            // with a lower ID value, we set our minIdStudent to refer (point) to
            //that element of the list

            foreach (Student student in list)
            {
                if (student.StdId < minIdStudent.StdId)
                    minIdStudent = student;
            }

            return minIdStudent;

        }
    }
}
