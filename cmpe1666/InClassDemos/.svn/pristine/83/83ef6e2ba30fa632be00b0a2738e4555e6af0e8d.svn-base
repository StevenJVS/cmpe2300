/*CMPE 1666- Intermediate Programming
 * 
 * 
 * 
 * 
 * Lecture10Exercise9
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

namespace Lecture10Exercise9
{
    public partial class Form1 : Form
    {
        private struct Customer
        {
            public int _customerId;
            public double _amountDue;
            public Customer(int Id, double amount)
            {
                _customerId = Id;
                _amountDue = amount;
            }
        }

        LinkedList<Customer> custList = new LinkedList<Customer>();

        public Form1()
        {
            InitializeComponent();
        }

        private void UI_AddToFront_btn_Click(object sender, EventArgs e)
        {
            Customer newCustomer = buildCustomerStruct();
            custList.AddFirst(newCustomer);
            DisplayAllCustomers();

        }
        private void UI_AddToRear_btn_Click(object sender, EventArgs e)
        {
            Customer newCustomer = buildCustomerStruct();
            custList.AddLast(newCustomer);
            DisplayAllCustomers();
        }

        private void UI_DisplaySelectedCust_btn_Click(object sender, EventArgs e)
        {
            DisplaySelectedCustomers();
        }

        private Customer buildCustomerStruct()
        {
            int CustomerId;
            double amount;
            Customer cust;

            int.TryParse(UI_CustID_txtBox.Text, out CustomerId);
            double.TryParse(UI_Amount_txtBox.Text, out amount);
            cust = new Customer(CustomerId, amount);
            UI_CustID_txtBox.Clear();
            UI_Amount_txtBox.Clear();
            return cust;
        }

        private void DisplayAllCustomers()
        {
            UI_AllCust_LB.Items.Clear();

            foreach(Customer cust in custList)
            {
                string str = $"{cust._customerId:D3} : {cust._amountDue:C}\n";
                UI_AllCust_LB.Items.Add(str);
            }
        }

        private void DisplaySelectedCustomers()
        {
           
            UI_SelectedCust_LB.Items.Clear();
            LinkedListNode<Customer> cust = custList.First;

            recurse_AddSelectedCustomers(cust);
            
        }

        

        private void recurse_AddSelectedCustomers(LinkedListNode<Customer> cust)
        {            
            if (cust != null) {
                if (cust.Value._amountDue >= 1000)
                {
                    string str = $"{cust.Value._customerId:D3} : {cust.Value._amountDue:C}\n";
                    UI_SelectedCust_LB.Items.Add(str);
                }
                recurse_AddSelectedCustomers(cust.Next);
                }
        }


    }
}
