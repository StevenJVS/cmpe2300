using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture6_Exercise5
{
    public partial class Form1 : Form
    {  //Defining Struct Student
        public struct Student
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

        List<Student> students; 
        public Form1()
        {
            InitializeComponent();
            students = new List<Student>();
        }

        private void UI_AddToList_Btn_Click(object sender, EventArgs e)
        {
            int stdId;

            int.TryParse(UI_StdId_Tbx.Text, out stdId);
            string firstName = UI_FirstName_Tbx.Text;
            string lastName=UI_LastName_Tbx.Text;   
            Student student = new Student(stdId, firstName, lastName);
            students.Add(student);

            UI_StdId_Tbx.Clear();
            UI_FirstName_Tbx.Clear();
            UI_LastName_Tbx.Clear();

            UI_UnSorted_Lbx.Items.Add($"{student.StdId}: {student.lastName}, {student.firstName}");

                           
                
       }

        private void BubbleSort(List<Student> myList)
        {
            for (int i=0; i<(myList.Count-1); i++){
                for (int j = 0; j < (myList.Count-i-1); j++)
                {
                    if (myList[j].StdId > myList[j + 1].StdId)
                        swap(myList, j, j + 1);
                }
            }
        }

        private void swap(List<Student> list, int X, int Y)
        {
            Student temp = list[X];
            list[X] = list[Y];
            list[Y] = temp;

        }

        private void UI_Sort_Btn_Click(object sender, EventArgs e)
        {
            BubbleSort(students);

            foreach(Student student in students)
                UI_Sorted_Lbx.Items.Add($"{student.StdId}: {student.lastName}, {student.firstName}");
        }
    }
}
