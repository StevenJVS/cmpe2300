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

namespace Le3Qu2Solution
{     public delegate void delVoidString(string str);//Creating the delegate type to write in the list boxes
    public partial class Form1 : Form
    {
        delVoidString delWriteToListBox=null;//Creating the delegate object


        /*The struct below is used to pass parameters to the created thread
         * when the thread is created through the ParameterizedThreadStart delegate
         * 
         * 
         */
        struct Data
        {
            public int Min;
            public int Max;
            public int NumValues;

            public Data(int min, int max, int numValues)
            {
                Min = min; 
                Max = max; 
                NumValues = numValues; 
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private List<int> GenerateValues(int minValue, int maxValue, int numValues)
        {
            List<int> list=new List<int>();
            Random rnd=new Random();

             for (int count=0; count<numValues; count++)
            {
                list.Add(rnd.Next(minValue, maxValue));
            }

            return list;
        }

        private void Ui_FixedRange_Btn_Click(object sender, EventArgs e)
        {
            UI_FixedRange_Lbx.Items.Clear();
            Thread T1=new Thread(GenerateFixedRange);
            T1.IsBackground = true;
            T1.Start();

        }


        private void GenerateFixedRange()
        {
            delWriteToListBox = AddToLeftListBox;//Assigning the delegate object to the required method

            List<int> myList = GenerateValues(0, 100, 40);
            foreach(int x in myList)
                Invoke(delWriteToListBox,x.ToString());
        }


        private void AddToLeftListBox(String str)
        {
            UI_FixedRange_Lbx.Items.Add(str);
        }


        /* This event handler will obtain the input values from the text boxes,
         * create the required thread through the ParameterizedThreadStart delegate
         * and runs the thread (through the start method) passing the required values to the new thread through the 
         * created struct
         */
        private void UI_VariableRange_Btn_Click(object sender, EventArgs e)
        {
            int minValue;
            int maxValue;
            int numValues;
            bool success1, success2, success3;

            success1 = int.TryParse(UI_MinValue_Tbx.Text,out minValue);
            success2 = int.TryParse(UI_MaxValue_Tbx.Text,out maxValue);
            success3= int.TryParse(UI_NumValues_Tbx.Text,out numValues);

            UI_VariableRange_Lbx.Items.Clear();
            if (maxValue <= minValue)
            {
                MessageBox.Show("The maximum value has to be greater than the minimum value");
            
            }

            else
            {
                Thread T1=new Thread(new ParameterizedThreadStart(GenerateVariableRange));
                T1.IsBackground = true;
                T1.Start(new Data(minValue,maxValue,numValues)); //Passing parameter for the thread. Note that the three required values
                                                                 // are placed in the struct since we can only pass one parameter to the method run by the thread
                                                                 // The boxing (converting the struct to Object) is implicit
            }


        }

        private void AddToRightListBox(String str)
        {
            UI_VariableRange_Lbx.Items.Add(str);
        }


        public void GenerateVariableRange(object args)
        {
            if (args is Data myData) //Unboxing the obtained object into the struct of required type
            {
                delWriteToListBox = AddToRightListBox;

                List<int> myList = GenerateValues(myData.Min,myData.Max,myData.NumValues);
                foreach(int x in myList)
                {
                    Invoke(delWriteToListBox,x.ToString());
                }

            }

        }
    }
}
