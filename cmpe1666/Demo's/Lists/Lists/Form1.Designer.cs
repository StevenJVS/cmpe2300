namespace Lists
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
            this.UI_listbox = new System.Windows.Forms.ListBox();
            this.UI_textbox = new System.Windows.Forms.TextBox();
            this.UI_button1 = new System.Windows.Forms.Button();
            this.UI_button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_listbox
            // 
            this.UI_listbox.FormattingEnabled = true;
            this.UI_listbox.Location = new System.Drawing.Point(78, 79);
            this.UI_listbox.Name = "UI_listbox";
            this.UI_listbox.Size = new System.Drawing.Size(178, 199);
            this.UI_listbox.TabIndex = 0;
            this.UI_listbox.SelectedIndexChanged += new System.EventHandler(this.UI_listbox_SelectedIndexChanged);
            // 
            // UI_textbox
            // 
            this.UI_textbox.Location = new System.Drawing.Point(423, 88);
            this.UI_textbox.Name = "UI_textbox";
            this.UI_textbox.Size = new System.Drawing.Size(287, 20);
            this.UI_textbox.TabIndex = 1;
            // 
            // UI_button1
            // 
            this.UI_button1.Location = new System.Drawing.Point(423, 138);
            this.UI_button1.Name = "UI_button1";
            this.UI_button1.Size = new System.Drawing.Size(287, 60);
            this.UI_button1.TabIndex = 2;
            this.UI_button1.Text = "Add to List";
            this.UI_button1.UseVisualStyleBackColor = true;
            this.UI_button1.Click += new System.EventHandler(this.UI_button1_Click);
            // 
            // UI_button2
            // 
            this.UI_button2.Enabled = false;
            this.UI_button2.Location = new System.Drawing.Point(423, 214);
            this.UI_button2.Name = "UI_button2";
            this.UI_button2.Size = new System.Drawing.Size(287, 64);
            this.UI_button2.TabIndex = 3;
            this.UI_button2.Text = "Add To List Box";
            this.UI_button2.UseVisualStyleBackColor = true;
            this.UI_button2.Click += new System.EventHandler(this.UI_button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "New Value:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_button2);
            this.Controls.Add(this.UI_button1);
            this.Controls.Add(this.UI_textbox);
            this.Controls.Add(this.UI_listbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UI_listbox;
        private System.Windows.Forms.TextBox UI_textbox;
        private System.Windows.Forms.Button UI_button1;
        private System.Windows.Forms.Button UI_button2;
        private System.Windows.Forms.Label label1;
    }
}

