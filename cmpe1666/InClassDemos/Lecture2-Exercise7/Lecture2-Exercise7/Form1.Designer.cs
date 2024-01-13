namespace Lecture2_Exercise7
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.UI_Stop_Btn = new System.Windows.Forms.Button();
            this.UI_DisplayCount_Lbx = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UI_Stop_Btn
            // 
            this.UI_Stop_Btn.Location = new System.Drawing.Point(120, 186);
            this.UI_Stop_Btn.Name = "UI_Stop_Btn";
            this.UI_Stop_Btn.Size = new System.Drawing.Size(122, 48);
            this.UI_Stop_Btn.TabIndex = 0;
            this.UI_Stop_Btn.Text = "Stop The Watch";
            this.UI_Stop_Btn.UseVisualStyleBackColor = true;
            this.UI_Stop_Btn.Click += new System.EventHandler(this.UI_Stop_Btn_Click);
            // 
            // UI_DisplayCount_Lbx
            // 
            this.UI_DisplayCount_Lbx.FormattingEnabled = true;
            this.UI_DisplayCount_Lbx.Location = new System.Drawing.Point(481, 85);
            this.UI_DisplayCount_Lbx.Name = "UI_DisplayCount_Lbx";
            this.UI_DisplayCount_Lbx.Size = new System.Drawing.Size(166, 173);
            this.UI_DisplayCount_Lbx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ticks- Multiples of 20";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 306);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_DisplayCount_Lbx);
            this.Controls.Add(this.UI_Stop_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button UI_Stop_Btn;
        private System.Windows.Forms.ListBox UI_DisplayCount_Lbx;
        private System.Windows.Forms.Label label1;
    }
}

