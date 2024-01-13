namespace Question1_solution
{
    partial class UI_LE3Q1_Form
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
            this.UI_QLabel = new System.Windows.Forms.Label();
            this.UI_StackLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_QLabel
            // 
            this.UI_QLabel.AutoSize = true;
            this.UI_QLabel.Location = new System.Drawing.Point(36, 129);
            this.UI_QLabel.Name = "UI_QLabel";
            this.UI_QLabel.Size = new System.Drawing.Size(179, 32);
            this.UI_QLabel.TabIndex = 0;
            this.UI_QLabel.Text = "Queue Label";
            // 
            // UI_StackLabel
            // 
            this.UI_StackLabel.AutoSize = true;
            this.UI_StackLabel.Location = new System.Drawing.Point(36, 213);
            this.UI_StackLabel.Name = "UI_StackLabel";
            this.UI_StackLabel.Size = new System.Drawing.Size(157, 32);
            this.UI_StackLabel.TabIndex = 1;
            this.UI_StackLabel.Text = "StackLabel";
            // 
            // UI_LE3Q1_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_StackLabel);
            this.Controls.Add(this.UI_QLabel);
            this.Name = "UI_LE3Q1_Form";
            this.Text = "LabExam 3- Question1";
            this.Load += new System.EventHandler(this.UI_LE3Q1_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_QLabel;
        private System.Windows.Forms.Label UI_StackLabel;
    }
}

