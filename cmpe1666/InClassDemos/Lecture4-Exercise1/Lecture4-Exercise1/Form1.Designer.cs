namespace Lecture4_Exercise1
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
            this.UI_Names_Lbx = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UI_Name_Tbx = new System.Windows.Forms.TextBox();
            this.UI_AddToList_Btn = new System.Windows.Forms.Button();
            this.UI_AddToListBox_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_Names_Lbx
            // 
            this.UI_Names_Lbx.FormattingEnabled = true;
            this.UI_Names_Lbx.Location = new System.Drawing.Point(75, 85);
            this.UI_Names_Lbx.Name = "UI_Names_Lbx";
            this.UI_Names_Lbx.Size = new System.Drawing.Size(187, 238);
            this.UI_Names_Lbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Value: ";
            // 
            // UI_Name_Tbx
            // 
            this.UI_Name_Tbx.Location = new System.Drawing.Point(409, 85);
            this.UI_Name_Tbx.Name = "UI_Name_Tbx";
            this.UI_Name_Tbx.Size = new System.Drawing.Size(182, 20);
            this.UI_Name_Tbx.TabIndex = 2;
            // 
            // UI_AddToList_Btn
            // 
            this.UI_AddToList_Btn.Location = new System.Drawing.Point(408, 138);
            this.UI_AddToList_Btn.Name = "UI_AddToList_Btn";
            this.UI_AddToList_Btn.Size = new System.Drawing.Size(182, 35);
            this.UI_AddToList_Btn.TabIndex = 3;
            this.UI_AddToList_Btn.Text = "Add To List";
            this.UI_AddToList_Btn.UseVisualStyleBackColor = true;
            this.UI_AddToList_Btn.Click += new System.EventHandler(this.UI_AddToList_Btn_Click);
            // 
            // UI_AddToListBox_Btn
            // 
            this.UI_AddToListBox_Btn.Enabled = false;
            this.UI_AddToListBox_Btn.Location = new System.Drawing.Point(409, 211);
            this.UI_AddToListBox_Btn.Name = "UI_AddToListBox_Btn";
            this.UI_AddToListBox_Btn.Size = new System.Drawing.Size(182, 35);
            this.UI_AddToListBox_Btn.TabIndex = 4;
            this.UI_AddToListBox_Btn.Text = "Add To Listbox";
            this.UI_AddToListBox_Btn.UseVisualStyleBackColor = true;
            this.UI_AddToListBox_Btn.Click += new System.EventHandler(this.UI_AddToListBox_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_AddToListBox_Btn);
            this.Controls.Add(this.UI_AddToList_Btn);
            this.Controls.Add(this.UI_Name_Tbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_Names_Lbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UI_Names_Lbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UI_Name_Tbx;
        private System.Windows.Forms.Button UI_AddToList_Btn;
        private System.Windows.Forms.Button UI_AddToListBox_Btn;
    }
}

