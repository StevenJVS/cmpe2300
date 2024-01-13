namespace Lecture10_Exercise1
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
            this.label1 = new System.Windows.Forms.Label();
            this.UI_addnametoq = new System.Windows.Forms.Button();
            this.UI_removenamefromq = new System.Windows.Forms.Button();
            this.UI_display = new System.Windows.Forms.Button();
            this.UI_textbox = new System.Windows.Forms.TextBox();
            this.UI_listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // UI_addnametoq
            // 
            this.UI_addnametoq.Location = new System.Drawing.Point(521, 132);
            this.UI_addnametoq.Name = "UI_addnametoq";
            this.UI_addnametoq.Size = new System.Drawing.Size(214, 23);
            this.UI_addnametoq.TabIndex = 1;
            this.UI_addnametoq.Text = "Add Name to Queue";
            this.UI_addnametoq.UseVisualStyleBackColor = true;
            this.UI_addnametoq.Click += new System.EventHandler(this.UI_addnametoq_Click);
            // 
            // UI_removenamefromq
            // 
            this.UI_removenamefromq.Location = new System.Drawing.Point(521, 171);
            this.UI_removenamefromq.Name = "UI_removenamefromq";
            this.UI_removenamefromq.Size = new System.Drawing.Size(214, 23);
            this.UI_removenamefromq.TabIndex = 2;
            this.UI_removenamefromq.Text = "Remove Name From Queue";
            this.UI_removenamefromq.UseVisualStyleBackColor = true;
            this.UI_removenamefromq.Click += new System.EventHandler(this.UI_removenamefromq_Click);
            // 
            // UI_display
            // 
            this.UI_display.Location = new System.Drawing.Point(521, 211);
            this.UI_display.Name = "UI_display";
            this.UI_display.Size = new System.Drawing.Size(214, 23);
            this.UI_display.TabIndex = 3;
            this.UI_display.Text = "Display Queue in List Box";
            this.UI_display.UseVisualStyleBackColor = true;
            this.UI_display.Click += new System.EventHandler(this.UI_display_Click);
            // 
            // UI_textbox
            // 
            this.UI_textbox.Location = new System.Drawing.Point(521, 84);
            this.UI_textbox.Name = "UI_textbox";
            this.UI_textbox.Size = new System.Drawing.Size(255, 20);
            this.UI_textbox.TabIndex = 4;
            // 
            // UI_listbox
            // 
            this.UI_listbox.FormattingEnabled = true;
            this.UI_listbox.Location = new System.Drawing.Point(67, 75);
            this.UI_listbox.Name = "UI_listbox";
            this.UI_listbox.Size = new System.Drawing.Size(310, 329);
            this.UI_listbox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_listbox);
            this.Controls.Add(this.UI_textbox);
            this.Controls.Add(this.UI_display);
            this.Controls.Add(this.UI_removenamefromq);
            this.Controls.Add(this.UI_addnametoq);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UI_addnametoq;
        private System.Windows.Forms.Button UI_removenamefromq;
        private System.Windows.Forms.Button UI_display;
        private System.Windows.Forms.TextBox UI_textbox;
        private System.Windows.Forms.ListBox UI_listbox;
    }
}

