namespace Lecture9_Demo3
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.UI_Count_Btn = new System.Windows.Forms.Button();
            this.UI_Comput_Btn = new System.Windows.Forms.Button();
            this.UI_Count_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(40, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(114, 173);
            this.listBox1.TabIndex = 0;
            // 
            // UI_Count_Btn
            // 
            this.UI_Count_Btn.Location = new System.Drawing.Point(291, 42);
            this.UI_Count_Btn.Name = "UI_Count_Btn";
            this.UI_Count_Btn.Size = new System.Drawing.Size(132, 49);
            this.UI_Count_Btn.TabIndex = 1;
            this.UI_Count_Btn.Text = "Count Clicks";
            this.UI_Count_Btn.UseVisualStyleBackColor = true;
            this.UI_Count_Btn.Click += new System.EventHandler(this.UI_Count_Btn_Click);
            // 
            // UI_Comput_Btn
            // 
            this.UI_Comput_Btn.Location = new System.Drawing.Point(291, 138);
            this.UI_Comput_Btn.Name = "UI_Comput_Btn";
            this.UI_Comput_Btn.Size = new System.Drawing.Size(132, 49);
            this.UI_Comput_Btn.TabIndex = 2;
            this.UI_Comput_Btn.Text = "Perform Computation";
            this.UI_Comput_Btn.UseVisualStyleBackColor = true;
            this.UI_Comput_Btn.Click += new System.EventHandler(this.UI_Comput_Btn_Click);
            // 
            // UI_Count_Lbl
            // 
            this.UI_Count_Lbl.AutoSize = true;
            this.UI_Count_Lbl.Location = new System.Drawing.Point(288, 94);
            this.UI_Count_Lbl.Name = "UI_Count_Lbl";
            this.UI_Count_Lbl.Size = new System.Drawing.Size(179, 13);
            this.UI_Count_Lbl.TabIndex = 3;
            this.UI_Count_Lbl.Text = "The button has been clicked 0 times";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 281);
            this.Controls.Add(this.UI_Count_Lbl);
            this.Controls.Add(this.UI_Comput_Btn);
            this.Controls.Add(this.UI_Count_Btn);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button UI_Count_Btn;
        private System.Windows.Forms.Button UI_Comput_Btn;
        private System.Windows.Forms.Label UI_Count_Lbl;
    }
}

