
namespace PracticeExam3Q3
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
            this.components = new System.ComponentModel.Container();
            this.UI_Thread_LB = new System.Windows.Forms.ListBox();
            this.UI_Start_Thread = new System.Windows.Forms.Button();
            this.UI_Thread_Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UI_Thread_LB
            // 
            this.UI_Thread_LB.FormattingEnabled = true;
            this.UI_Thread_LB.Location = new System.Drawing.Point(31, 22);
            this.UI_Thread_LB.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.UI_Thread_LB.Name = "UI_Thread_LB";
            this.UI_Thread_LB.Size = new System.Drawing.Size(345, 264);
            this.UI_Thread_LB.TabIndex = 0;
            // 
            // UI_Start_Thread
            // 
            this.UI_Start_Thread.Location = new System.Drawing.Point(395, 62);
            this.UI_Start_Thread.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.UI_Start_Thread.Name = "UI_Start_Thread";
            this.UI_Start_Thread.Size = new System.Drawing.Size(119, 49);
            this.UI_Start_Thread.TabIndex = 1;
            this.UI_Start_Thread.Text = "Start Thread";
            this.UI_Start_Thread.UseVisualStyleBackColor = true;
            this.UI_Start_Thread.Click += new System.EventHandler(this.UI_Start_Thread_Click);
            // 
            // UI_Thread_Timer
            // 
            this.UI_Thread_Timer.Enabled = true;
            this.UI_Thread_Timer.Tick += new System.EventHandler(this.UI_Thread_Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 305);
            this.Controls.Add(this.UI_Start_Thread);
            this.Controls.Add(this.UI_Thread_LB);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox UI_Thread_LB;
        private System.Windows.Forms.Button UI_Start_Thread;
        private System.Windows.Forms.Timer UI_Thread_Timer;
    }
}

