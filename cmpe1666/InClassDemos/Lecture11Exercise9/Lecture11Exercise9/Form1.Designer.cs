namespace Lecture11Exercise9
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
            this.UI_Name_Lbx = new System.Windows.Forms.ListBox();
            this.UI_Name_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Name_Lbl = new System.Windows.Forms.Label();
            this.UI_Save_Btn = new System.Windows.Forms.Button();
            this.UI_AddToListBox_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_Name_Lbx
            // 
            this.UI_Name_Lbx.FormattingEnabled = true;
            this.UI_Name_Lbx.Location = new System.Drawing.Point(12, 12);
            this.UI_Name_Lbx.Name = "UI_Name_Lbx";
            this.UI_Name_Lbx.Size = new System.Drawing.Size(207, 212);
            this.UI_Name_Lbx.TabIndex = 0;
            // 
            // UI_Name_Tbx
            // 
            this.UI_Name_Tbx.Location = new System.Drawing.Point(460, 68);
            this.UI_Name_Tbx.Name = "UI_Name_Tbx";
            this.UI_Name_Tbx.Size = new System.Drawing.Size(219, 20);
            this.UI_Name_Tbx.TabIndex = 1;
            // 
            // UI_Name_Lbl
            // 
            this.UI_Name_Lbl.AutoSize = true;
            this.UI_Name_Lbl.Location = new System.Drawing.Point(406, 71);
            this.UI_Name_Lbl.Name = "UI_Name_Lbl";
            this.UI_Name_Lbl.Size = new System.Drawing.Size(38, 13);
            this.UI_Name_Lbl.TabIndex = 2;
            this.UI_Name_Lbl.Text = "Name:";
            // 
            // UI_Save_Btn
            // 
            this.UI_Save_Btn.Location = new System.Drawing.Point(471, 147);
            this.UI_Save_Btn.Name = "UI_Save_Btn";
            this.UI_Save_Btn.Size = new System.Drawing.Size(199, 36);
            this.UI_Save_Btn.TabIndex = 3;
            this.UI_Save_Btn.Text = "Save";
            this.UI_Save_Btn.UseVisualStyleBackColor = true;
            this.UI_Save_Btn.Click += new System.EventHandler(this.UI_Save_Btn_Click);
            // 
            // UI_AddToListBox_Btn
            // 
            this.UI_AddToListBox_Btn.Location = new System.Drawing.Point(471, 225);
            this.UI_AddToListBox_Btn.Name = "UI_AddToListBox_Btn";
            this.UI_AddToListBox_Btn.Size = new System.Drawing.Size(199, 36);
            this.UI_AddToListBox_Btn.TabIndex = 4;
            this.UI_AddToListBox_Btn.Text = "Add To ListBox";
            this.UI_AddToListBox_Btn.UseVisualStyleBackColor = true;
            this.UI_AddToListBox_Btn.Click += new System.EventHandler(this.UI_AddToListBox_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_AddToListBox_Btn);
            this.Controls.Add(this.UI_Save_Btn);
            this.Controls.Add(this.UI_Name_Lbl);
            this.Controls.Add(this.UI_Name_Tbx);
            this.Controls.Add(this.UI_Name_Lbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UI_Name_Lbx;
        private System.Windows.Forms.TextBox UI_Name_Tbx;
        private System.Windows.Forms.Label UI_Name_Lbl;
        private System.Windows.Forms.Button UI_Save_Btn;
        private System.Windows.Forms.Button UI_AddToListBox_Btn;
    }
}

