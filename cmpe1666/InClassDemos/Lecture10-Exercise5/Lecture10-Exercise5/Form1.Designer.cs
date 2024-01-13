namespace Lecture10_Exercise5
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
            this.UI_Name_LB = new System.Windows.Forms.ListBox();
            this.UI_AddToFront_btn = new System.Windows.Forms.Button();
            this.UI_AddToRear_btn = new System.Windows.Forms.Button();
            this.UI_DisplayFirst_btn = new System.Windows.Forms.Button();
            this.UI_DisplayLast_btn = new System.Windows.Forms.Button();
            this.UI_RemoveName_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UI_Name_tbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UI_First_tbx = new System.Windows.Forms.TextBox();
            this.UI_Rear_tbx = new System.Windows.Forms.TextBox();
            this.UI_DisplayWholeList_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_Name_LB
            // 
            this.UI_Name_LB.FormattingEnabled = true;
            this.UI_Name_LB.ItemHeight = 31;
            this.UI_Name_LB.Location = new System.Drawing.Point(62, 39);
            this.UI_Name_LB.Name = "UI_Name_LB";
            this.UI_Name_LB.Size = new System.Drawing.Size(597, 841);
            this.UI_Name_LB.TabIndex = 0;
            // 
            // UI_AddToFront_btn
            // 
            this.UI_AddToFront_btn.Location = new System.Drawing.Point(739, 49);
            this.UI_AddToFront_btn.Name = "UI_AddToFront_btn";
            this.UI_AddToFront_btn.Size = new System.Drawing.Size(428, 120);
            this.UI_AddToFront_btn.TabIndex = 1;
            this.UI_AddToFront_btn.Text = "Add Name To Front";
            this.UI_AddToFront_btn.UseVisualStyleBackColor = true;
            this.UI_AddToFront_btn.Click += new System.EventHandler(this.UI_AddToFront_btn_Click);
            // 
            // UI_AddToRear_btn
            // 
            this.UI_AddToRear_btn.Location = new System.Drawing.Point(739, 196);
            this.UI_AddToRear_btn.Name = "UI_AddToRear_btn";
            this.UI_AddToRear_btn.Size = new System.Drawing.Size(428, 120);
            this.UI_AddToRear_btn.TabIndex = 2;
            this.UI_AddToRear_btn.Text = "Add Name To Back";
            this.UI_AddToRear_btn.UseVisualStyleBackColor = true;
            this.UI_AddToRear_btn.Click += new System.EventHandler(this.UI_AddToRear_btn_Click);
            // 
            // UI_DisplayFirst_btn
            // 
            this.UI_DisplayFirst_btn.Location = new System.Drawing.Point(739, 343);
            this.UI_DisplayFirst_btn.Name = "UI_DisplayFirst_btn";
            this.UI_DisplayFirst_btn.Size = new System.Drawing.Size(428, 120);
            this.UI_DisplayFirst_btn.TabIndex = 3;
            this.UI_DisplayFirst_btn.Text = "Display First";
            this.UI_DisplayFirst_btn.UseVisualStyleBackColor = true;
            this.UI_DisplayFirst_btn.Click += new System.EventHandler(this.UI_DisplayFirst_btn_Click);
            // 
            // UI_DisplayLast_btn
            // 
            this.UI_DisplayLast_btn.Location = new System.Drawing.Point(739, 493);
            this.UI_DisplayLast_btn.Name = "UI_DisplayLast_btn";
            this.UI_DisplayLast_btn.Size = new System.Drawing.Size(428, 120);
            this.UI_DisplayLast_btn.TabIndex = 4;
            this.UI_DisplayLast_btn.Text = "Display Last";
            this.UI_DisplayLast_btn.UseVisualStyleBackColor = true;
            this.UI_DisplayLast_btn.Click += new System.EventHandler(this.UI_DisplayLast_btn_Click);
            // 
            // UI_RemoveName_btn
            // 
            this.UI_RemoveName_btn.Location = new System.Drawing.Point(739, 776);
            this.UI_RemoveName_btn.Name = "UI_RemoveName_btn";
            this.UI_RemoveName_btn.Size = new System.Drawing.Size(428, 120);
            this.UI_RemoveName_btn.TabIndex = 5;
            this.UI_RemoveName_btn.Text = "Remove Name";
            this.UI_RemoveName_btn.UseVisualStyleBackColor = true;
            this.UI_RemoveName_btn.Click += new System.EventHandler(this.UI_RemoveName_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1437, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name: ";
            // 
            // UI_Name_tbx
            // 
            this.UI_Name_tbx.Location = new System.Drawing.Point(1548, 79);
            this.UI_Name_tbx.Name = "UI_Name_tbx";
            this.UI_Name_tbx.Size = new System.Drawing.Size(504, 38);
            this.UI_Name_tbx.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1437, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "First:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1437, 553);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last:";
            // 
            // UI_First_tbx
            // 
            this.UI_First_tbx.Location = new System.Drawing.Point(1548, 409);
            this.UI_First_tbx.Name = "UI_First_tbx";
            this.UI_First_tbx.ReadOnly = true;
            this.UI_First_tbx.Size = new System.Drawing.Size(504, 38);
            this.UI_First_tbx.TabIndex = 10;
            // 
            // UI_Rear_tbx
            // 
            this.UI_Rear_tbx.Location = new System.Drawing.Point(1548, 550);
            this.UI_Rear_tbx.Name = "UI_Rear_tbx";
            this.UI_Rear_tbx.ReadOnly = true;
            this.UI_Rear_tbx.Size = new System.Drawing.Size(504, 38);
            this.UI_Rear_tbx.TabIndex = 11;
            // 
            // UI_DisplayWholeList_btn
            // 
            this.UI_DisplayWholeList_btn.Location = new System.Drawing.Point(739, 637);
            this.UI_DisplayWholeList_btn.Name = "UI_DisplayWholeList_btn";
            this.UI_DisplayWholeList_btn.Size = new System.Drawing.Size(428, 120);
            this.UI_DisplayWholeList_btn.TabIndex = 12;
            this.UI_DisplayWholeList_btn.Text = "Display Whole List";
            this.UI_DisplayWholeList_btn.UseVisualStyleBackColor = true;
            this.UI_DisplayWholeList_btn.Click += new System.EventHandler(this.UI_DisplayWholeList_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2479, 1190);
            this.Controls.Add(this.UI_DisplayWholeList_btn);
            this.Controls.Add(this.UI_Rear_tbx);
            this.Controls.Add(this.UI_First_tbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UI_Name_tbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_RemoveName_btn);
            this.Controls.Add(this.UI_DisplayLast_btn);
            this.Controls.Add(this.UI_DisplayFirst_btn);
            this.Controls.Add(this.UI_AddToRear_btn);
            this.Controls.Add(this.UI_AddToFront_btn);
            this.Controls.Add(this.UI_Name_LB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UI_Name_LB;
        private System.Windows.Forms.Button UI_AddToFront_btn;
        private System.Windows.Forms.Button UI_AddToRear_btn;
        private System.Windows.Forms.Button UI_DisplayFirst_btn;
        private System.Windows.Forms.Button UI_DisplayLast_btn;
        private System.Windows.Forms.Button UI_RemoveName_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UI_Name_tbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UI_First_tbx;
        private System.Windows.Forms.TextBox UI_Rear_tbx;
        private System.Windows.Forms.Button UI_DisplayWholeList_btn;
    }
}

