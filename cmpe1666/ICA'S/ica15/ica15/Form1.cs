﻿//***********************************************************************************
//Program: Thready Color
//Description: Analyzes images using threads
//Date: 04/02/23
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
using System.Threading;
using System.Xml.Linq;

namespace ica15
{
    //create delegate
    public delegate void delvoid(string str, double r, double g, double b);
    public partial class Form1 : Form
    {
        public delvoid _delvoid = null;//delegate
        List<Thread> threads = new List<Thread>();
        

        public Form1()
        {
            InitializeComponent();
            _delvoid = new delvoid(status);//set delegate
        }

        private void UI_go_Click(object sender, EventArgs e)
        {
            if(UI_openfiledialog.ShowDialog () == DialogResult.OK )
            {
                try
                {
                    //display starting message to list box
                    UI_listbox.Items.Add("Starting...");
                    foreach(string file in UI_openfiledialog.FileNames)
                    {                       
                        Thread image = new Thread(new ParameterizedThreadStart(analyze));//new thread
                        image.IsBackground = true;//background thread
                        image.Start(file);//start thread
                        threads.Add(image);                       
                    }
                    UI_timer.Enabled = true;//start timer
                  
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }
        }
        //********************************************************************************************
        //Method: Analyze
        //Purpose: get total rgb in percentage
        //Returns: 
        //*********************************************************************************************
        private void analyze(object str)
        {

                //start sum to 0 if user selects a picture
                double sumred = 0;
                double sumgreen = 0;
                double sumblue = 0;
                try
                {
                    //create new bit map
                    Bitmap bm = (Bitmap)Bitmap.FromFile((string)str);

                    //go through each pixel
                    for (int x = 0; x < bm.Width; x++)
                    {
                        for (int y = 0; y < bm.Height; y++)
                        {
                            //get color of pixel
                            Color pixel = bm.GetPixel(x, y);

                            //get sum 
                            sumred = sumred + pixel.R;
                            sumgreen = sumgreen + pixel.G;
                            sumblue = sumblue + pixel.B;
                        }
                    }
                    //sum of pixels and total rgb
                    double total = sumred + sumgreen + sumblue;
                    double R = (sumred / total) * 100;
                    double G = (sumgreen / total) * 100;
                    double B = (sumblue / total) * 100;

                    //call method in main
                    Invoke(_delvoid, (string)str, R, G, B );
                }
                catch (Exception ex)
                //error message
                {
                    MessageBox.Show($"{ex.Message}");
                }
            
        }
        //********************************************************************************************
        //Method: status
        //Purpose: display contents to list box
        //Parameters: string file name
        //            double r, g, b
        //Returns: 
        //*********************************************************************************************
        private void status(string str, double r, double g, double b)
        {
            //display rgb and done message
            UI_listbox.Items.Add($"(R:{r:f2}%, G:{g:f2}%, B:{b:f2}%) " + str);
        }
        //timer tick
        private void UI_timer_Tick(object sender, EventArgs e)
        {
            bool run = true;
            foreach(Thread i in threads)
            {
                //check if timer is running
                if (i.ThreadState != ThreadState.Stopped)
                {
                    run= false;                
                    //do nothing
                }
            }

            if (run)
            {
                //display done
                UI_listbox.Items.Add("Done...");
                UI_timer.Stop();//stop timer
            }
        }
    }
}
