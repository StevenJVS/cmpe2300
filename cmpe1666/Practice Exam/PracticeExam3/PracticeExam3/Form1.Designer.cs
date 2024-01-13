namespace PracticeExam3
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
            this.Ui_checkbox = new System.Windows.Forms.CheckBox();
            this.UI_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ui_checkbox
            // 
            this.Ui_checkbox.AutoSize = true;
            this.Ui_checkbox.Location = new System.Drawing.Point(229, 122);
            this.Ui_checkbox.Name = "Ui_checkbox";
            this.Ui_checkbox.Size = new System.Drawing.Size(122, 20);
            this.Ui_checkbox.TabIndex = 0;
            this.Ui_checkbox.Text = "ShowModeless";
            this.Ui_checkbox.UseVisualStyleBackColor = true;
            this.Ui_checkbox.CheckedChanged += new System.EventHandler(this.Ui_checkbox_CheckedChanged);
            // 
            // UI_textbox
            // 
            this.UI_textbox.Location = new System.Drawing.Point(262, 250);
            this.UI_textbox.Name = "UI_textbox";
            this.UI_textbox.ReadOnly = true;
            this.UI_textbox.Size = new System.Drawing.Size(100, 22);
            this.UI_textbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_textbox);
            this.Controls.Add(this.Ui_checkbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Ui_checkbox;
        private System.Windows.Forms.TextBox UI_textbox;
        private System.Windows.Forms.Label label1;
    }
}

