namespace Lecture6_Exercise5
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
            this.UI_UnSorted_Lbx = new System.Windows.Forms.ListBox();
            this.UI_Sorted_Lbx = new System.Windows.Forms.ListBox();
            this.UI_StdId_Tbx = new System.Windows.Forms.TextBox();
            this.UI_FirstName_Tbx = new System.Windows.Forms.TextBox();
            this.UI_LastName_Tbx = new System.Windows.Forms.TextBox();
            this.UI_AddToList_Btn = new System.Windows.Forms.Button();
            this.UI_Sort_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_UnSorted_Lbx
            // 
            this.UI_UnSorted_Lbx.FormattingEnabled = true;
            this.UI_UnSorted_Lbx.Location = new System.Drawing.Point(23, 33);
            this.UI_UnSorted_Lbx.Name = "UI_UnSorted_Lbx";
            this.UI_UnSorted_Lbx.Size = new System.Drawing.Size(206, 238);
            this.UI_UnSorted_Lbx.TabIndex = 0;
            // 
            // UI_Sorted_Lbx
            // 
            this.UI_Sorted_Lbx.FormattingEnabled = true;
            this.UI_Sorted_Lbx.Location = new System.Drawing.Point(562, 33);
            this.UI_Sorted_Lbx.Name = "UI_Sorted_Lbx";
            this.UI_Sorted_Lbx.Size = new System.Drawing.Size(206, 225);
            this.UI_Sorted_Lbx.TabIndex = 1;
            // 
            // UI_StdId_Tbx
            // 
            this.UI_StdId_Tbx.Location = new System.Drawing.Point(364, 68);
            this.UI_StdId_Tbx.Name = "UI_StdId_Tbx";
            this.UI_StdId_Tbx.Size = new System.Drawing.Size(155, 20);
            this.UI_StdId_Tbx.TabIndex = 2;
            // 
            // UI_FirstName_Tbx
            // 
            this.UI_FirstName_Tbx.Location = new System.Drawing.Point(364, 118);
            this.UI_FirstName_Tbx.Name = "UI_FirstName_Tbx";
            this.UI_FirstName_Tbx.Size = new System.Drawing.Size(155, 20);
            this.UI_FirstName_Tbx.TabIndex = 3;
            // 
            // UI_LastName_Tbx
            // 
            this.UI_LastName_Tbx.Location = new System.Drawing.Point(364, 173);
            this.UI_LastName_Tbx.Name = "UI_LastName_Tbx";
            this.UI_LastName_Tbx.Size = new System.Drawing.Size(155, 20);
            this.UI_LastName_Tbx.TabIndex = 4;
            // 
            // UI_AddToList_Btn
            // 
            this.UI_AddToList_Btn.Location = new System.Drawing.Point(331, 256);
            this.UI_AddToList_Btn.Name = "UI_AddToList_Btn";
            this.UI_AddToList_Btn.Size = new System.Drawing.Size(162, 48);
            this.UI_AddToList_Btn.TabIndex = 5;
            this.UI_AddToList_Btn.Text = "Add To List";
            this.UI_AddToList_Btn.UseVisualStyleBackColor = true;
            this.UI_AddToList_Btn.Click += new System.EventHandler(this.UI_AddToList_Btn_Click);
            // 
            // UI_Sort_Btn
            // 
            this.UI_Sort_Btn.Location = new System.Drawing.Point(331, 321);
            this.UI_Sort_Btn.Name = "UI_Sort_Btn";
            this.UI_Sort_Btn.Size = new System.Drawing.Size(162, 48);
            this.UI_Sort_Btn.TabIndex = 6;
            this.UI_Sort_Btn.Text = "Sort List";
            this.UI_Sort_Btn.UseVisualStyleBackColor = true;
            this.UI_Sort_Btn.Click += new System.EventHandler(this.UI_Sort_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Unsorted List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sorted List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Student Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "First Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Last Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_Sort_Btn);
            this.Controls.Add(this.UI_AddToList_Btn);
            this.Controls.Add(this.UI_LastName_Tbx);
            this.Controls.Add(this.UI_FirstName_Tbx);
            this.Controls.Add(this.UI_StdId_Tbx);
            this.Controls.Add(this.UI_Sorted_Lbx);
            this.Controls.Add(this.UI_UnSorted_Lbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UI_UnSorted_Lbx;
        private System.Windows.Forms.ListBox UI_Sorted_Lbx;
        private System.Windows.Forms.TextBox UI_StdId_Tbx;
        private System.Windows.Forms.TextBox UI_FirstName_Tbx;
        private System.Windows.Forms.TextBox UI_LastName_Tbx;
        private System.Windows.Forms.Button UI_AddToList_Btn;
        private System.Windows.Forms.Button UI_Sort_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

