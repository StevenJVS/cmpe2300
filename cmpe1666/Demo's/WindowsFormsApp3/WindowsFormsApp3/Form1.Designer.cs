namespace WindowsFormsApp3
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
            this.UI_button = new System.Windows.Forms.Button();
            this.UI_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UI_button
            // 
            this.UI_button.Location = new System.Drawing.Point(249, 164);
            this.UI_button.Name = "UI_button";
            this.UI_button.Size = new System.Drawing.Size(123, 79);
            this.UI_button.TabIndex = 1;
            this.UI_button.Text = "button1";
            this.UI_button.UseVisualStyleBackColor = true;
            this.UI_button.Click += new System.EventHandler(this.UI_button_Click);
            // 
            // UI_textbox
            // 
            this.UI_textbox.Location = new System.Drawing.Point(249, 72);
            this.UI_textbox.Name = "UI_textbox";
            this.UI_textbox.Size = new System.Drawing.Size(100, 20);
            this.UI_textbox.TabIndex = 0;
            this.UI_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_button);
            this.Controls.Add(this.UI_textbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_button;
        private System.Windows.Forms.TextBox UI_textbox;
    }
}

