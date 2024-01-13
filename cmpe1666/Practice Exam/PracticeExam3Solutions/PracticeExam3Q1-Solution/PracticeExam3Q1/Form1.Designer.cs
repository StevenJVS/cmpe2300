namespace PracticeExam3Q1
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
            this.UI_Result_tbx = new System.Windows.Forms.TextBox();
            this.UI_ShowModeless_CBx = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Result :";
            // 
            // UI_Result_tbx
            // 
            this.UI_Result_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Result_tbx.Location = new System.Drawing.Point(226, 177);
            this.UI_Result_tbx.Margin = new System.Windows.Forms.Padding(5);
            this.UI_Result_tbx.Name = "UI_Result_tbx";
            this.UI_Result_tbx.ReadOnly = true;
            this.UI_Result_tbx.Size = new System.Drawing.Size(392, 31);
            this.UI_Result_tbx.TabIndex = 3;
            // 
            // UI_ShowModeless_CBx
            // 
            this.UI_ShowModeless_CBx.AutoSize = true;
            this.UI_ShowModeless_CBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_ShowModeless_CBx.Location = new System.Drawing.Point(226, 43);
            this.UI_ShowModeless_CBx.Name = "UI_ShowModeless_CBx";
            this.UI_ShowModeless_CBx.Size = new System.Drawing.Size(148, 24);
            this.UI_ShowModeless_CBx.TabIndex = 4;
            this.UI_ShowModeless_CBx.Text = "ShowModeless";
            this.UI_ShowModeless_CBx.UseVisualStyleBackColor = true;
            this.UI_ShowModeless_CBx.CheckedChanged += new System.EventHandler(this.UI_ShowModeless_CBx_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 229);
            this.Controls.Add(this.UI_ShowModeless_CBx);
            this.Controls.Add(this.UI_Result_tbx);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Question 02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UI_Result_tbx;
        private System.Windows.Forms.CheckBox UI_ShowModeless_CBx;
    }
}

