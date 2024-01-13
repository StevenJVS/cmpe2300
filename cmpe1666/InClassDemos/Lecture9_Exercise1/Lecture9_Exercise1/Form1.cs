﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Lecture9_Exercise1
{  public delegate void delVoidString(string str);
    public partial class Form1 : Form
    {
        public int count = 0;
        public Form1()
        {
            InitializeComponent();
        }


        public void FindSine()
        {
            delVoidString delWriteSine = AddToListBox;

            for (double x = 0; x < 90; x = x + 0.1)
            {
                double rad = Math.PI * x / 180;
                double sineValue = Math.Sin(rad);
                try
                {
                    Invoke(delWriteSine, $"{x:F2} degrees = {rad:F4} radians. Sine={sineValue:F4}");
                }
                catch(Exception ex){
                    MessageBox.Show($"Invoke caused an exception- The Reason is : {ex.Message}");
                    System.Windows.Forms.Application.Exit();
                };
                Thread.Sleep(50);
            }
        }

        private void UI_Count_Btn_Click(object sender, EventArgs e)
        {
            UI_Count_Lbl.Text = $"The button has been clicked {++count} times";
        }

        private void UI_Comput_Btn_Click(object sender, EventArgs e)
        {
            Thread Thread1 = new Thread(FindSine);
            Thread1.Start();
        }

        private void AddToListBox(string s1)
        {
            listBox1.Items.Add(s1); 
        }
    }
}
