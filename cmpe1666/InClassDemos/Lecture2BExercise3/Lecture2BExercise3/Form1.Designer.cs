namespace Lecture2BExercise3
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
            this.UI_Name_Lbl = new System.Windows.Forms.Label();
            this.UI_Name_Tbx = new System.Windows.Forms.TextBox();
            this.UI_ClickMe_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_Name_Lbl
            // 
            this.UI_Name_Lbl.AutoSize = true;
            this.UI_Name_Lbl.Location = new System.Drawing.Point(191, 121);
            this.UI_Name_Lbl.Name = "UI_Name_Lbl";
            this.UI_Name_Lbl.Size = new System.Drawing.Size(38, 13);
            this.UI_Name_Lbl.TabIndex = 0;
            this.UI_Name_Lbl.Text = "Name:";
            // 
            // UI_Name_Tbx
            // 
            this.UI_Name_Tbx.Location = new System.Drawing.Point(235, 121);
            this.UI_Name_Tbx.Name = "UI_Name_Tbx";
            this.UI_Name_Tbx.Size = new System.Drawing.Size(182, 20);
            this.UI_Name_Tbx.TabIndex = 1;
            // 
            // UI_ClickMe_Btn
            // 
            this.UI_ClickMe_Btn.Location = new System.Drawing.Point(245, 203);
            this.UI_ClickMe_Btn.Name = "UI_ClickMe_Btn";
            this.UI_ClickMe_Btn.Size = new System.Drawing.Size(172, 28);
            this.UI_ClickMe_Btn.TabIndex = 2;
            this.UI_ClickMe_Btn.Text = "Click Me";
            this.UI_ClickMe_Btn.UseVisualStyleBackColor = true;
            this.UI_ClickMe_Btn.Click += new System.EventHandler(this.UI_ClickMe_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_ClickMe_Btn);
            this.Controls.Add(this.UI_Name_Tbx);
            this.Controls.Add(this.UI_Name_Lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_Name_Lbl;
        private System.Windows.Forms.TextBox UI_Name_Tbx;
        private System.Windows.Forms.Button UI_ClickMe_Btn;
    }
}

