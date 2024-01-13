//***********************************************************************************
//Program: Binary Search
//Description: Indiates whisch strings are palindromes
//Date: 02/13/23
//Author: Steven Santiago
//Course: CMPE1666
//Class: CNTA02
//***********************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ica7
{
    public partial class Form1 : Form
    {

            List<string> myList;//create list
            public Form1()
            {
                InitializeComponent();
                myList = new List<string>();//creat new object
            }

                //********************************************************************************************
                //Method: RBinary Search
                //Purpose: Find string in sorted list
                //Returns: index value if string is found
                //*********************************************************************************************
            private int RBinarySearch(List<string> L, string val, int low, int high)
            {

                if (low <= high)//compare index
                {
                    int mid = (low + high) / 2;//find middle 

                    //if the value matches the middle we have found the middle value
                    //return
                    if (L[mid] == val)
                        return mid;

                    //If my search value is less than the value at mid
                    //return and seach the bottom half
                    if (val.CompareTo(L[mid]) < 0)
                        return RBinarySearch(L, val, low, mid - 1);

                    // The  search value is greater than the value at mid
                    //return and search upper half
                    return RBinarySearch(L, val, mid + 1, high);

                }
                return -1; //return if string is not found
            }

        //********************************************************************************************
        //Method: UI_Value_Click
        //Purpose: Add string to unsorted and sorted list
        //Returns:
        //*********************************************************************************************

        private void UI_AddToList_Btn_Click_1(object sender, EventArgs e)
        {
            if (UI_Value.Text != null)//check if text box is empty
            {
                myList.Add(UI_Value.Text);//add string to list
                UI_UnsortedData_Lbx.Items.Add(UI_Value.Text);//add unsorted value to list box
                myList.Sort();//sort list
                UI_SortedData_Lbx.Items.Clear();//clear unsorted items
                foreach (string item in myList)//add items back sorted
                    UI_SortedData_Lbx.Items.Add(item);
                UI_Value.Text = null;//clear text box

            }
        }
        //********************************************************************************************
        //Method: UI_SearchValue_Btn_Click
        //Purpose: display message if string is found or not
        //Returns:
        //*********************************************************************************************
        private void UI_SearchValue_Btn_Click(object sender, EventArgs e)
        {
            if (UI_Value.Text != null)//check if text box is empty
            {
                int index = RBinarySearch(myList, UI_Value.Text, 0, myList.Count - 1);//return index 

                if (index >= 0)//if index greater than 0, string was found
                    MessageBox.Show(UI_Value.Text + $" found at position {index}", "Found", MessageBoxButtons.OK);
                //if returns negative, string was not found
                else
                    MessageBox.Show(UI_Value.Text + " not found", "Not Found", MessageBoxButtons.OK);
            }
            //clear text box
            UI_Value.Text = null;
        }
    }
    

}

