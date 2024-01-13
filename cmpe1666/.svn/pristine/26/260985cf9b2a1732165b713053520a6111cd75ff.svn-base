/**CMPE 1666 - Intermediate Programming  *********
 * 
 * 
 * Lab Exam 3- Winter 2022- Question 2***************
 * 
 * Name:
 * 
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Xml.Linq;

namespace LE3Q2
{
    public partial class Form1 : Form
    {  
        //Define the Student struct here. 
        private struct Student
        {
            public string _fname;
            public string _lname;
            public double _marks;
            
            public Student(string fname, string lname, double marks)
            {
                _fname = fname;
                _lname = lname;
                _marks = marks;
            }
            public override string ToString()
            {
                return $"Name:\t{_fname}. {_lname} - marks:{_marks}";
            }
        }

        //Declare your List of Students here
        List<Student> students;
        List<Student> copy;
        List<string> fnames;
        List<string> lnames;
        Random rand = new Random();

        StreamReader sr;

        public Form1()
        {
            InitializeComponent();
            //Create your empty list of Student structs here
            students= new List<Student>();
            fnames= new List<string>();
            lnames= new List<string>();
        }

        private void UI_LoadStudents_Btn_Click(object sender, EventArgs e)
        {
            //Write your code for the "Load Students" button handler here
            string sInput;
             UI_OpenFiles_Dlg = new OpenFileDialog();
            if(UI_OpenFiles_Dlg.ShowDialog()== DialogResult.OK)
            {
                sr = new StreamReader(UI_OpenFiles_Dlg.FileName);
                while((sInput = sr.ReadLine()) != null)
                {
                    fnames.Add(sInput);
                }
            }
            UI_OpenFiles_Dlg = new OpenFileDialog();
            if (UI_OpenFiles_Dlg.ShowDialog() == DialogResult.OK)
            {
                sr = new StreamReader(UI_OpenFiles_Dlg.FileName);
                while ((sInput = sr.ReadLine()) != null)
                {
                    lnames.Add(sInput);
                }
            }
            for(int i=0; i<fnames.Count;i++)
            {
                students.Add(new Student(fnames[i], lnames[i], rand.Next(0,101)));
                DisplayInListBox(students, UI_RawData_LB);
            }
        }

        //Include your helper methods for Sorting here

        private void UI_Sort_Btn_Click(object sender, EventArgs e)
        {
            UI_SortedData_LB.Items.Clear();
            copy = new List<Student>(students);
            //Write your code for the "Display Sorted" button handler here
            if (UI_Names_Radio.Checked)
            {
                bubblesortalphabetical(copy);
                for(int i = 0; i < copy.Count; i++)
                {
                    DisplayInListBox(students, UI_SortedData_LB);
                }
            }
            else if (UI_Ranking_Radio.Checked)
            {
                bubblesortranking(copy);
                for (int i = 0; i < copy.Count; i++)
                {
                    DisplayInListBox(students, UI_SortedData_LB);
                }
            }
        }

        private void UI_DisplaySelected_Btn_Click(object sender, EventArgs e)
        {
            UI_SelectedData_LB.Items.Clear();
            if(UI_Agrades_Radio.Checked)
            {
                foreach(Student student in students)
                {
                    if(student._marks >= 90)
                    {
                        DisplayInListBox(students, UI_SelectedData_LB);
                    }
                }
            }
            else if (UI_Passes_Radio.Checked)
            {
                foreach (Student student in students)
                {
                    if (student._marks >= 50)
                    {
                        DisplayInListBox(students, UI_SelectedData_LB);
                    }
                }
            }
            else if (UI_Fails_radio.Checked)
            {
                foreach (Student student in students)
                {
                    if (student._marks < 50)
                    {
                        DisplayInListBox(students,UI_SelectedData_LB);
                    }
                }
            }
        }

        private void DisplayInListBox(List<Student> Std_List,ListBox LB)
        {
            //Write your code for the DisplayInListBox() method here
            foreach(Student student in Std_List)
            {
                LB.Items.Add(student.ToString());
            }

        }
        private void bubblesortranking(List <Student> students)
        {
            int n = students.Count;
            for (int p = 0; p < n -1; p++)
            {
                for(int j = 0; j < (n-(p+1)); j++)
                {
                    if (students[j]._marks > students[j+1]._marks)
                    {
                        swap(students, j, j+1);
                    }
                }
            }
        }
        private void bubblesortalphabetical(List<Student> students)
        {
            int n = students.Count;
            for (int p = 0; p < n - 1; p++)
            {
                for (int j = 0; j < (n - (p + 1)); j++)
                {
                    if ((students[j]._lname.CompareTo(students[j+1]._lname) > 0))
                    {
                        swap(students, j, j + 1);
                    }
                }
            }
        }
        private void swap(List<Student> student, int x, int y)
        {
            Student temp = student[x];
            student[x] = student[y];
            student[y] = temp;
        }
    }
}
