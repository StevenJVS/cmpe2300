//***********************************************************************************
//Program: Sorting Methods
//Description: Sorts numbers recusively using different methods
//Date: 02/27/23
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
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ica8
{
    public partial class Form1 : Form
    {
        int min;//min value
        int max;//max value
        int numvalues;//number of wanted values
        int num;//random values
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();//stopwatch
        List<int> myList;//initial list
        List<int> myList2;//list after sort
        Random random = new Random();//random number
        public Form1()
        {
            InitializeComponent();
            myList= new List<int>();//create empty list
            myList2= new List<int>();//create empty copy of list
            sw.Stop();//stop watch when program starts
        }

        private void UI_GenerateValues_Click(object sender, EventArgs e)
        {
            //convert user inputs to ints
            int.TryParse(UI_MaximumValue.Text, out max);
            int.TryParse(UI_MinimumValue.Text, out min);
            int.TryParse(UI_NumberofValues.Text, out numvalues);
            //error messages if requirements are not met
                if (min < 10)
                {
                    MessageBox.Show("Please a minimum value greater than 10", "Error", MessageBoxButtons.OK);
                }
                if (min > max)
                {
                    MessageBox.Show("Minimum value is greater than the maximum value", "Error", MessageBoxButtons.OK);
                }
                if (UI_NumberofValues == null || UI_MinimumValue == null || UI_MaximumValue == null) 
                {
                    MessageBox.Show("Please enter a value in all fields", "Error", MessageBoxButtons.OK);
                }
                if(!int.TryParse(UI_MaximumValue.Text, out max) || !int.TryParse(UI_MinimumValue.Text, out min) || !int.TryParse(UI_NumberofValues.Text, out numvalues))
                {
                    MessageBox.Show("Please enter integer values", "Error", MessageBoxButtons.OK);
                }

                //if user inputs valid values
                if(min >= 10 && min < max && UI_NumberofValues.Text != null)//condition for accepted values
                {
                    //go through wanted list size
                    for (int i = 0; i < numvalues; i++)
                    {
                        num = random.Next(min, max+1);//create new randoms values for each iteration
                        myList.Add(num);//add number to list
                        UI_GeneratedList.Text += $"{num} ";
                    }

                }
        }
        //********************************************************************************************
        //Method: UI_SortValues_Click
        //Purpose: Add string to unsorted and sorted list
        //Returns:
        //*********************************************************************************************
        private void UI_SortValues_Click(object sender, EventArgs e)
        {    
            myList2 = new List<int>(myList);
            if(UI_Bubble.Checked)
            {
                sw.Start();//start stop watch
                bubblesort(myList2);//sort list
                foreach (int num in myList2)//go through each item
                {
                    UI_SortedList.Text += $"{num} ";//dispay sorted list in text box
                }
                sw.Stop();//stop watch
                long ElapsedTime = sw.ElapsedTicks;//store elapsed ticks in variable
                UI_SortingTimeTicks.Text = ElapsedTime.ToString();//display value as a string
            }
            else if(UI_Selection.Checked)
            {
                sw.Start();//start stop watch
                selectionsort(myList2);//sort list
                foreach (int num in myList2)//go through each item
                {
                    UI_SortedList.Text += $"{num} ";//dispay sorted list in text box
                }
                sw.Stop();//stop watch
                long ElapsedTime = sw.ElapsedTicks;//store elapsed ticks in variable
                UI_SortingTimeTicks.Text = ElapsedTime.ToString();//display value as a string
            }
            else if(UI_Insertion.Checked)
            {
                sw.Start();//start stop watch
                insertion(myList2);//sort list
                foreach (int num in myList2)//go through each item
                {
                    UI_SortedList.Text += $"{num} ";//dispay sorted list in text box
                }
                sw.Stop();//stop watch
                long ElapsedTime = sw.ElapsedTicks;//store elapsed ticks in variable
                UI_SortingTimeTicks.Text = ElapsedTime.ToString();//display value as a string
            }
            else if(UI_QuickSort.Checked)
            {
                sw.Start();//start stop watch
                int low = 0;//index of list
                int high = myList.Count - 1;//index of list
                quicksort(myList2,low,high);//sort list
                foreach (int num in myList2)//go through each item
                {
                    UI_SortedList.Text += $"{num} ";//dispay sorted list in text box
                }
                sw.Stop();//stop watch
                long ElapsedTime = sw.ElapsedTicks;//store elapsed ticks in variable
                UI_SortingTimeTicks.Text = ElapsedTime.ToString();//display value as a string
            }
        }
        //********************************************************************************************
        //Method: UI_ClearRaw_Click
        //Purpose: clear unsorted text box
        //Returns:
        //*********************************************************************************************
        private void UI_ClearRaw_Click(object sender, EventArgs e)
        {
            UI_GeneratedList.Text = null;//clear text box
        }
        //********************************************************************************************
        //Method: UI_Redisplay_click
        //Purpose: redisplay unsorted list
        //Returns:
        //*********************************************************************************************
        private void UI_Redisplay_Click(object sender, EventArgs e)
        {
            foreach(int i in myList)//go through each value of the list
            {
                UI_GeneratedList.Text += $"{i} ";//display each value of list
            }
        }
        //********************************************************************************************
        //Method: UI_ClearSorted_Click
        //Purpose: clear sorted text box
        //Returns:
        //*********************************************************************************************
        private void UI_ClearSorted_Click(object sender, EventArgs e)
        {
            sw.Reset();//clear and reset stop watch
            //clear textbox
            UI_SortingTimeTicks.Text = null;
            UI_SortedList.Text = null;
        }
        //********************************************************************************************
        //Method: bubblesort
        //Purpose: sort list
        //Parameters: List<int> mylist
        //Returns:sorted list
        //*********************************************************************************************
        private static void bubblesort(List<int> myList)
        {
            int n = myList.Count;//number of indexes
            //run through the all possible amount of passes depending on the size of the list
            for (int p = 0; p < n - 1; p++)
            {
                
                {
                //go through the whole list and on the next iteration the list size will decrease by n-1
                for (int j = 0; j < (n - (p+1)); j++)
                    //compare current index position value to the next index and if current value it greater then swap
                    if (myList[j] > myList[j + 1])
                    {
                        swap(myList, j, j + 1);//swap values
                    }
                }
            }
        }
        //********************************************************************************************
        //Method: swap
        //Purpose: swap smaller value and the larger value to its wants position
        //Parameters: List<int> mylist, int x(initial index of smaller value), int y(initial index of larger value)
        //Returns:
        //*********************************************************************************************
        private static void swap(List<int> myList, int x, int y)
        {
            int temp = myList[x];//create temp variable to swap
            myList[x] = myList[y];//swap so x will be the larger value
            myList[y] = temp;//temp (smaller value) will be y
        }
        //********************************************************************************************
        //Method: selection sort
        //Purpose: sort list
        //Parameters: List<int> mylist
        //Returns:sorted list
        //*********************************************************************************************
        private static void selectionsort(List<int> myList)
        {
            int maxpos = 0;//variable to store the largest value of list
            int lastposn;//lastposition of list
            int n = myList.Count;//size of list
            //go through all possible amount of passes
            for (int pass = 0; pass < n-1; pass++)
            {
                //last position of list
                lastposn = n - 1 - pass;

                //go through the whole list and the next iteration will decrease the list size by n-pass
                for(int j = 0; j < n-pass; j++)
                {
                    //position j is larger than than postion maxpos
                    if (myList[j] > myList[maxpos])
                    {
                        maxpos = j;//swap the two values
                    }                   
                }
                //swap value of the last postion to the largest number
                swap(myList, maxpos, lastposn);
            }
        }
        //********************************************************************************************
        //Method: insertion
        //Purpose: sort list
        //Parameters: List<int> mylist
        //Returns:sorted list
        //*********************************************************************************************
        private static void insertion(List<int> myList)
        {
            int n = myList.Count;//size of list

            //go through all possible passes in list
            //p = 1 due to the fact that we are storing the second value and comparing it to the first value
            for (int p = 1; p < n; p++)
            {
                int temp = myList[p];//store value 
                int j = p-1;//value to the left of temp

                //if temp is not greater than than the value at j, move temp to the next value to the left
                while((j>=0)&& (myList[j] > temp))
                {
                    myList[j+1] = myList[j];// shift all values before temp one to the right
                    j = j - 1;//move to the next value to compare temp
                }
                //if temp is greater than value insert temp after j
                myList[j+1] = temp;
            }
        }
        //********************************************************************************************
        //Method: quicksort
        //Purpose: sort list
        //Parameters: List<int> mylist
        //Returns:sorted list
        //*********************************************************************************************
        private static void quicksort(List<int> myList, int low, int high)
        {
            int pi;//pivot point

            //check if all index values has been sorted
            if (low < high)
            {
                pi = partition(myList, low, high);//find pivot point
                quicksort(myList, low, pi -1);//arrange lower half of list recursively
                quicksort(myList, pi +1, high);//arrange upperhalf of list recursively
            }
        }
        //********************************************************************************************
        //Method: partition
        //Purpose: find pivot point and sort
        //Parameters: List<int> mylist, int low, int high
        //Returns:partition
        //*********************************************************************************************
        private static int partition(List<int> myList, int low, int high) 
        {
            int pi = myList[high];//last index value will be the pivot point
            //position will be before the list becuase we need to compare j to the value behind it to sort
            int i = low - 1; 
            //go through list
            for (int j = low; j < high; j++)
            {
                //if current index if less than pivot point, swap j and i so all values smaller than the pivot point will be on the left side
                if (myList[j] < pi)
                {
                    i++;//move i to the next index
                    swap(myList, i, j);//swap the j and i
                }
            }
            //when all values that are smaller than the pivot have all been placed to the left side
            //swap the next index value on the right side of the smaller values with the pivot point
            swap(myList, i + 1, high);
            return(i+1);//return pivot point
        }
    }

}
