//***********************************************************************************
//Program: LinkedList
//Description: Manipulating linkedlists
//Date: 04/16/23
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ica18
{
    public partial class Form1 : Form
    {
        //customer struct
        public struct CustomerAmount
        {
            public int CustomerId;//customer id
            public decimal AmountDue;//customer amount

            public CustomerAmount(int _id, decimal due)
            {
                CustomerId = _id;
                AmountDue = due;
            }
            public override string ToString()
            {
                //format to display in list box
                return $"{CustomerId:d3}:   {AmountDue:c}";
            }

        }
        //lists
        LinkedList<CustomerAmount> customerlist = new LinkedList<CustomerAmount>();
        LinkedList<CustomerAmount> templist = new LinkedList<CustomerAmount>();
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_addcustomerbtn_Click(object sender, EventArgs e)
        {
            //add user input to linked list
            customerlist.AddFirst(new CustomerAmount((int)UI_customerid.Value, (decimal)random.NextDouble()*10000));

            Ui_list1.Items.Clear();//claer list to ensure no duplicates

            //display all contents of linked list
            foreach(CustomerAmount item in customerlist)
            {
                Ui_list1.Items.Add(item.ToString());
            }
        }

        private void Ui_displaysum_Click(object sender, EventArgs e)
        {
            UI_list2.Items.Clear();//clear listbox 2
            templist.Clear();//clear templist
            double total = 0;//total amount due for customer
            LinkedListNode<CustomerAmount> node = customerlist.First;//node list

            //go through all nodes
            while (node != null)
            {
                //select wanted customer
                if (UI_customerid.Value == node.Value.CustomerId)
                {
                    CustomerAmount val = node.Value;//get value of curent node
                    AddToListSorted(templist, val);//add to sorted list
                    total += (double)val.AmountDue;//add total
                }
                node = node.Next;//go to next node
            }

            UI_showtotal.Text = $"{total:c}";//display total
            total = 0;//reset total

            UI_list2.Items.Clear();//clear listbox 2

            //display sorted list in listbox 2
            foreach(CustomerAmount val in templist)
            {
                UI_list2.Items.Add(val.ToString());
            }
        }
        //********************************************************************************************
        //Method: AddToListSorted
        //Purpose: add to sorted list
        //Parameters: List<CustomerAmount> mylist, CustomerAmount value)
        //Returns:
        //*********************************************************************************************
        static private void AddToListSorted(LinkedList<CustomerAmount> myList, CustomerAmount value)
        {
            //current node
            LinkedListNode<CustomerAmount> current;
            current = myList.First;

            //check if current node is bigger than the value node
            while ((current != null) && (current.Value.AmountDue > value.AmountDue))
                current = current.Next;//move to next node

            if (current == null)
            {
                //add last if all values are larger than value
                myList.AddLast(value);
            }
            else
            {
                //if index is not null and value node before current node
                //meaning it is larger
                myList.AddBefore(current, value);
            }
        }

        private void UI_displayall_Click(object sender, EventArgs e)
        {
            UI_list2.Items.Clear();//clear listbox2
            foreach(CustomerAmount c in customerlist)
            {
                //check amount due is greater than wanted value
                if(c.AmountDue > Ui_minamount.Value)
                {
                    UI_list2.Items.Add(c.ToString());//add to listbox
                }
            }

            double total = 0;//initial total
            LinkedListNode<CustomerAmount> node = customerlist.First;//start on first node

            //go through all nodes
            while (node != null)
            {
                CustomerAmount val = node.Value;//get current node value

                //add to total if number is above wanted value
                if (val.AmountDue > Ui_minamount.Value)
                {
                    total += (double)val.AmountDue;//add total
                }
                node = node.Next;//next node
            }

            UI_mintotal.Text = $"{total:c}";//display total
        }
        private void UI_clearbtn_Click(object sender, EventArgs e)
        {
            //clear contents
            Ui_list1.Items.Clear();
            UI_list2.Items.Clear();
            UI_showtotal.Text = "$0.00";
            UI_mintotal.Text = "$0.00";
            customerlist.Clear();
            templist.Clear();
        }
    }
}
