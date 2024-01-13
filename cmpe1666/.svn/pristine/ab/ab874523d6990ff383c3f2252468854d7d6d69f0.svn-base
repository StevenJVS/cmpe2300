//***********************************************************************************
//Program: Stacky Posts
//Description: adding and removing contents ina stack
//Date: 04/06/23
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
using System.Diagnostics;

namespace ica17
{
    public partial class Form1 : Form
    {
        Stopwatch sw = new Stopwatch();//stop watch
        Stack<Post> pstack = new Stack<Post>();// original stack
        Stack<Post> temp = new Stack<Post>();// temp stack
        int counter = 0;//counter for id

        //struct
        public struct Post
        {
            public int id;//id
            public string post;//post
            public string display;//display
            public Post(int _ID, string _Post)
            {
                id = _ID;
                post = _Post;
                display = $"Id:{id}{post}";//format to display
                
            }

        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sw.Start();//start timer when form loads
        }
        
        private void UI_addpost_Click(object sender, EventArgs e)
        {
            counter++;//increment id
            //new post struct
            Post post = new Post(counter, $" - Message: { UI_input.Text } - Posted at: { sw.ElapsedMilliseconds / 1000} seconds");
            pstack.Push(post);//add to stack
            displayMessage();//display stack
            UI_input.Text = null;//clear display
        }

        private void UI_deletepost_Click(object sender, EventArgs e)
        {
            counter--;//remove last id
            pstack.Pop();//remove top of stack
            displayMessage();//display stack
        }

        private void Ui_deletepostbyId_Click(object sender, EventArgs e)
        {
            //convert text box to int
            string input = UI_deletetxtbx.Text;
            int num;
            int.TryParse(input, out num);
            
            //check find wanted value
            while(pstack.Peek().id != num)
            {
                //remove contents above the wanted value and push to temp stack
                temp.Push(pstack.Pop());
            }
            pstack.Pop();//remove desired id

            //all contents in temp stack back to original stack
            while(temp.Count> 0)
            {
                //clear temp stack
                pstack.Push(temp.Pop());
            }

            UI_deletetxtbx.Text = null;//clear textbox
            displayMessage();//display stack
        }
        //********************************************************************************************
        //Method: displayMessage
        //Purpose: display stack to listbox
        //Returns:
        //*********************************************************************************************
        private void displayMessage()
        {
            UI_listbox.Items.Clear();//clear list box

            //add stack to listbox
            foreach (Post p in pstack)
            {
                UI_listbox.Items.Add(p.display);
            }
        }
    }
}
