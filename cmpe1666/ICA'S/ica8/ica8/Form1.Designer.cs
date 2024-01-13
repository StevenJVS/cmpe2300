﻿namespace ica8
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UI_NumberofValues = new System.Windows.Forms.TextBox();
            this.UI_MinimumValue = new System.Windows.Forms.TextBox();
            this.UI_MaximumValue = new System.Windows.Forms.TextBox();
            this.UI_SortingTimeTicks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UI_ClearRaw = new System.Windows.Forms.Button();
            this.UI_Redisplay = new System.Windows.Forms.Button();
            this.UI_GenerateValues = new System.Windows.Forms.Button();
            this.UI_SortValues = new System.Windows.Forms.Button();
            this.UI_ClearSorted = new System.Windows.Forms.Button();
            this.UI_Bubble = new System.Windows.Forms.RadioButton();
            this.UI_Selection = new System.Windows.Forms.RadioButton();
            this.UI_Insertion = new System.Windows.Forms.RadioButton();
            this.UI_QuickSort = new System.Windows.Forms.RadioButton();
            this.UI_SortingValues = new System.Windows.Forms.GroupBox();
            this.UI_GeneratedList = new System.Windows.Forms.TextBox();
            this.UI_SortedList = new System.Windows.Forms.TextBox();
            this.UI_SortingValues.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_NumberofValues
            // 
            this.UI_NumberofValues.Location = new System.Drawing.Point(387, 37);
            this.UI_NumberofValues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_NumberofValues.Name = "UI_NumberofValues";
            this.UI_NumberofValues.Size = new System.Drawing.Size(100, 22);
            this.UI_NumberofValues.TabIndex = 0;
            // 
            // UI_MinimumValue
            // 
            this.UI_MinimumValue.Location = new System.Drawing.Point(387, 81);
            this.UI_MinimumValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_MinimumValue.Name = "UI_MinimumValue";
            this.UI_MinimumValue.Size = new System.Drawing.Size(100, 22);
            this.UI_MinimumValue.TabIndex = 1;
            // 
            // UI_MaximumValue
            // 
            this.UI_MaximumValue.Location = new System.Drawing.Point(387, 121);
            this.UI_MaximumValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_MaximumValue.Name = "UI_MaximumValue";
            this.UI_MaximumValue.Size = new System.Drawing.Size(100, 22);
            this.UI_MaximumValue.TabIndex = 2;
            // 
            // UI_SortingTimeTicks
            // 
            this.UI_SortingTimeTicks.Location = new System.Drawing.Point(387, 400);
            this.UI_SortingTimeTicks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_SortingTimeTicks.Name = "UI_SortingTimeTicks";
            this.UI_SortingTimeTicks.ReadOnly = true;
            this.UI_SortingTimeTicks.Size = new System.Drawing.Size(100, 22);
            this.UI_SortingTimeTicks.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of Values:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Minimum Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Maximum Value:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sorting Time (ticks):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Generated Values";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(603, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sorted Values";
            // 
            // UI_ClearRaw
            // 
            this.UI_ClearRaw.Location = new System.Drawing.Point(40, 441);
            this.UI_ClearRaw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_ClearRaw.Name = "UI_ClearRaw";
            this.UI_ClearRaw.Size = new System.Drawing.Size(93, 23);
            this.UI_ClearRaw.TabIndex = 12;
            this.UI_ClearRaw.Text = "Clear Raw";
            this.UI_ClearRaw.UseVisualStyleBackColor = true;
            this.UI_ClearRaw.Click += new System.EventHandler(this.UI_ClearRaw_Click);
            // 
            // UI_Redisplay
            // 
            this.UI_Redisplay.Location = new System.Drawing.Point(139, 441);
            this.UI_Redisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_Redisplay.Name = "UI_Redisplay";
            this.UI_Redisplay.Size = new System.Drawing.Size(77, 23);
            this.UI_Redisplay.TabIndex = 13;
            this.UI_Redisplay.Text = "Redisplay";
            this.UI_Redisplay.UseVisualStyleBackColor = true;
            this.UI_Redisplay.Click += new System.EventHandler(this.UI_Redisplay_Click);
            // 
            // UI_GenerateValues
            // 
            this.UI_GenerateValues.Location = new System.Drawing.Point(312, 162);
            this.UI_GenerateValues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_GenerateValues.Name = "UI_GenerateValues";
            this.UI_GenerateValues.Size = new System.Drawing.Size(123, 34);
            this.UI_GenerateValues.TabIndex = 14;
            this.UI_GenerateValues.Text = "Generate Values";
            this.UI_GenerateValues.UseVisualStyleBackColor = true;
            this.UI_GenerateValues.Click += new System.EventHandler(this.UI_GenerateValues_Click);
            // 
            // UI_SortValues
            // 
            this.UI_SortValues.Location = new System.Drawing.Point(323, 348);
            this.UI_SortValues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_SortValues.Name = "UI_SortValues";
            this.UI_SortValues.Size = new System.Drawing.Size(100, 30);
            this.UI_SortValues.TabIndex = 15;
            this.UI_SortValues.Text = "Sort Values";
            this.UI_SortValues.UseVisualStyleBackColor = true;
            this.UI_SortValues.Click += new System.EventHandler(this.UI_SortValues_Click);
            // 
            // UI_ClearSorted
            // 
            this.UI_ClearSorted.Location = new System.Drawing.Point(605, 441);
            this.UI_ClearSorted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_ClearSorted.Name = "UI_ClearSorted";
            this.UI_ClearSorted.Size = new System.Drawing.Size(93, 23);
            this.UI_ClearSorted.TabIndex = 16;
            this.UI_ClearSorted.Text = "Clear Sorted";
            this.UI_ClearSorted.UseVisualStyleBackColor = true;
            this.UI_ClearSorted.Click += new System.EventHandler(this.UI_ClearSorted_Click);
            // 
            // UI_Bubble
            // 
            this.UI_Bubble.AutoSize = true;
            this.UI_Bubble.Checked = true;
            this.UI_Bubble.Location = new System.Drawing.Point(25, 21);
            this.UI_Bubble.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_Bubble.Name = "UI_Bubble";
            this.UI_Bubble.Size = new System.Drawing.Size(98, 20);
            this.UI_Bubble.TabIndex = 17;
            this.UI_Bubble.TabStop = true;
            this.UI_Bubble.Text = "Bubble Sort";
            this.UI_Bubble.UseVisualStyleBackColor = true;
            // 
            // UI_Selection
            // 
            this.UI_Selection.AutoSize = true;
            this.UI_Selection.Location = new System.Drawing.Point(25, 47);
            this.UI_Selection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_Selection.Name = "UI_Selection";
            this.UI_Selection.Size = new System.Drawing.Size(111, 20);
            this.UI_Selection.TabIndex = 18;
            this.UI_Selection.TabStop = true;
            this.UI_Selection.Text = "Selection Sort";
            this.UI_Selection.UseVisualStyleBackColor = true;
            // 
            // UI_Insertion
            // 
            this.UI_Insertion.AutoSize = true;
            this.UI_Insertion.Location = new System.Drawing.Point(25, 73);
            this.UI_Insertion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_Insertion.Name = "UI_Insertion";
            this.UI_Insertion.Size = new System.Drawing.Size(78, 20);
            this.UI_Insertion.TabIndex = 19;
            this.UI_Insertion.Text = "Insertion";
            this.UI_Insertion.UseVisualStyleBackColor = true;
            // 
            // UI_QuickSort
            // 
            this.UI_QuickSort.AutoSize = true;
            this.UI_QuickSort.Location = new System.Drawing.Point(25, 98);
            this.UI_QuickSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_QuickSort.Name = "UI_QuickSort";
            this.UI_QuickSort.Size = new System.Drawing.Size(89, 20);
            this.UI_QuickSort.TabIndex = 20;
            this.UI_QuickSort.TabStop = true;
            this.UI_QuickSort.Text = "Quick Sort";
            this.UI_QuickSort.UseVisualStyleBackColor = true;
            // 
            // UI_SortingValues
            // 
            this.UI_SortingValues.Controls.Add(this.UI_Bubble);
            this.UI_SortingValues.Controls.Add(this.UI_QuickSort);
            this.UI_SortingValues.Controls.Add(this.UI_Selection);
            this.UI_SortingValues.Controls.Add(this.UI_Insertion);
            this.UI_SortingValues.Location = new System.Drawing.Point(287, 214);
            this.UI_SortingValues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_SortingValues.Name = "UI_SortingValues";
            this.UI_SortingValues.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_SortingValues.Size = new System.Drawing.Size(175, 128);
            this.UI_SortingValues.TabIndex = 21;
            this.UI_SortingValues.TabStop = false;
            this.UI_SortingValues.Text = "Sorting Values";
            // 
            // UI_GeneratedList
            // 
            this.UI_GeneratedList.Location = new System.Drawing.Point(40, 113);
            this.UI_GeneratedList.Margin = new System.Windows.Forms.Padding(4);
            this.UI_GeneratedList.Multiline = true;
            this.UI_GeneratedList.Name = "UI_GeneratedList";
            this.UI_GeneratedList.ReadOnly = true;
            this.UI_GeneratedList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UI_GeneratedList.Size = new System.Drawing.Size(159, 302);
            this.UI_GeneratedList.TabIndex = 22;
            // 
            // UI_SortedList
            // 
            this.UI_SortedList.Location = new System.Drawing.Point(569, 113);
            this.UI_SortedList.Margin = new System.Windows.Forms.Padding(4);
            this.UI_SortedList.Multiline = true;
            this.UI_SortedList.Name = "UI_SortedList";
            this.UI_SortedList.ReadOnly = true;
            this.UI_SortedList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UI_SortedList.Size = new System.Drawing.Size(159, 302);
            this.UI_SortedList.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.UI_SortedList);
            this.Controls.Add(this.UI_GeneratedList);
            this.Controls.Add(this.UI_SortingValues);
            this.Controls.Add(this.UI_ClearSorted);
            this.Controls.Add(this.UI_SortValues);
            this.Controls.Add(this.UI_GenerateValues);
            this.Controls.Add(this.UI_Redisplay);
            this.Controls.Add(this.UI_ClearRaw);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_SortingTimeTicks);
            this.Controls.Add(this.UI_MaximumValue);
            this.Controls.Add(this.UI_MinimumValue);
            this.Controls.Add(this.UI_NumberofValues);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.UI_SortingValues.ResumeLayout(false);
            this.UI_SortingValues.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_NumberofValues;
        private System.Windows.Forms.TextBox UI_MinimumValue;
        private System.Windows.Forms.TextBox UI_MaximumValue;
        private System.Windows.Forms.TextBox UI_SortingTimeTicks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button UI_ClearRaw;
        private System.Windows.Forms.Button UI_Redisplay;
        private System.Windows.Forms.Button UI_GenerateValues;
        private System.Windows.Forms.Button UI_SortValues;
        private System.Windows.Forms.Button UI_ClearSorted;
        private System.Windows.Forms.RadioButton UI_Bubble;
        private System.Windows.Forms.RadioButton UI_Selection;
        private System.Windows.Forms.RadioButton UI_Insertion;
        private System.Windows.Forms.RadioButton UI_QuickSort;
        private System.Windows.Forms.GroupBox UI_SortingValues;
        private System.Windows.Forms.TextBox UI_GeneratedList;
        private System.Windows.Forms.TextBox UI_SortedList;
    }
}

