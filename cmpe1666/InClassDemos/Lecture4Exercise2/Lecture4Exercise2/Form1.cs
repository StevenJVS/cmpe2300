/*Lecture4- Exercise2
 * 
 * 
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
  
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<int> myList;
        public Form1()
        {
            InitializeComponent();
            myList = new List<int>();
        }


        private int RBinarySearch(List<int> L, int val, int low, int high)
        {

            if (low <= high)
            {
                int mid = (low + high) / 2;//We calculate the middle index

                //We compare our search value with the value at the middle index
                //If the values match, we have found the value at position mid
                // so we return mid as the index
                if (L[mid] == val)
                    return mid;

                //If my search value is < the value at mid
                //I only have to search the lower half of the list
                if (val < L[mid])
                    return RBinarySearch(L, val, low, mid - 1);

                // The  search value is higher than the value at mid
                // so I need to search only the higher half of the list
                return RBinarySearch(L, val, mid + 1, high);

            }
            return -1; //If we reach here, it means high < low. So we haven't found a match
        }

        private void UI_AddToList_Btn_Click(object sender, EventArgs e)
        {
            bool success;
            int x;

            success = int.TryParse(UI_Value_Tbx.Text, out x);
            if (success)
            {
                myList.Add(x);
                UI_UnsortedData_Lbx.Items.Add(x);
                UI_Value_Tbx.Text = null;

            }
        }

        private void UI_SortData_Btn_Click(object sender, EventArgs e)
        {
            myList.Sort();
            foreach(int item in myList)
                UI_SortedData_Lbx.Items.Add(item);
        }

        private void UI_SearchValue_Btn_Click(object sender, EventArgs e)
        {
            bool success;
            int x;

            success = int.TryParse(UI_Value_Tbx.Text, out x);
            if (success)
            {
                int index = RBinarySearch(myList, x, 0, myList.Count - 1);
                if (index < 0)
                    UI_Results_Tbx.Text = $"{x} found at position {index}";
                else
                    UI_Results_Tbx.Text = $"{x} not found";


            }
            else
            {
                MessageBox.Show("Value Textbox does not contain a valid value");
            }
        }
    }
}
