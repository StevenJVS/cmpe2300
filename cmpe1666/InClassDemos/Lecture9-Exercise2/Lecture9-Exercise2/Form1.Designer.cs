namespace Lecture9_Exercise2
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
            this.UI_Sine_LB = new System.Windows.Forms.ListBox();
            this.UI_Cos_LB = new System.Windows.Forms.ListBox();
            this.UI_StartSine_Btn = new System.Windows.Forms.Button();
            this.UI_StopSine_btn = new System.Windows.Forms.Button();
            this.UI_StartCos_Btn = new System.Windows.Forms.Button();
            this.UI_StopCos_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_Sine_LB
            // 
            this.UI_Sine_LB.FormattingEnabled = true;
            this.UI_Sine_LB.ItemHeight = 20;
            this.UI_Sine_LB.Location = new System.Drawing.Point(95, 32);
            this.UI_Sine_LB.Name = "UI_Sine_LB";
            this.UI_Sine_LB.Size = new System.Drawing.Size(285, 284);
            this.UI_Sine_LB.TabIndex = 0;
            // 
            // UI_Cos_LB
            // 
            this.UI_Cos_LB.FormattingEnabled = true;
            this.UI_Cos_LB.ItemHeight = 20;
            this.UI_Cos_LB.Location = new System.Drawing.Point(485, 32);
            this.UI_Cos_LB.Name = "UI_Cos_LB";
            this.UI_Cos_LB.Size = new System.Drawing.Size(285, 284);
            this.UI_Cos_LB.TabIndex = 1;
            // 
            // UI_StartSine_Btn
            // 
            this.UI_StartSine_Btn.Location = new System.Drawing.Point(117, 331);
            this.UI_StartSine_Btn.Name = "UI_StartSine_Btn";
            this.UI_StartSine_Btn.Size = new System.Drawing.Size(231, 37);
            this.UI_StartSine_Btn.TabIndex = 2;
            this.UI_StartSine_Btn.Text = "Start Sine Calculation";
            this.UI_StartSine_Btn.UseVisualStyleBackColor = true;
            this.UI_StartSine_Btn.Click += new System.EventHandler(this.UI_StartSine_Btn_Click);
            // 
            // UI_StopSine_btn
            // 
            this.UI_StopSine_btn.Location = new System.Drawing.Point(117, 386);
            this.UI_StopSine_btn.Name = "UI_StopSine_btn";
            this.UI_StopSine_btn.Size = new System.Drawing.Size(231, 37);
            this.UI_StopSine_btn.TabIndex = 3;
            this.UI_StopSine_btn.Text = "Stop Sine Calculation";
            this.UI_StopSine_btn.UseVisualStyleBackColor = true;
            this.UI_StopSine_btn.Click += new System.EventHandler(this.UI_StopSine_btn_Click);
            // 
            // UI_StartCos_Btn
            // 
            this.UI_StartCos_Btn.Location = new System.Drawing.Point(519, 331);
            this.UI_StartCos_Btn.Name = "UI_StartCos_Btn";
            this.UI_StartCos_Btn.Size = new System.Drawing.Size(231, 37);
            this.UI_StartCos_Btn.TabIndex = 4;
            this.UI_StartCos_Btn.Text = "Start Cos Calculation";
            this.UI_StartCos_Btn.UseVisualStyleBackColor = true;
            this.UI_StartCos_Btn.Click += new System.EventHandler(this.UI_StartCos_Btn_Click);
            // 
            // UI_StopCos_btn
            // 
            this.UI_StopCos_btn.Location = new System.Drawing.Point(519, 386);
            this.UI_StopCos_btn.Name = "UI_StopCos_btn";
            this.UI_StopCos_btn.Size = new System.Drawing.Size(231, 37);
            this.UI_StopCos_btn.TabIndex = 5;
            this.UI_StopCos_btn.Text = "Stop Cos Calculation";
            this.UI_StopCos_btn.UseVisualStyleBackColor = true;
            this.UI_StopCos_btn.Click += new System.EventHandler(this.UI_StopCos_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_StopCos_btn);
            this.Controls.Add(this.UI_StartCos_Btn);
            this.Controls.Add(this.UI_StopSine_btn);
            this.Controls.Add(this.UI_StartSine_Btn);
            this.Controls.Add(this.UI_Cos_LB);
            this.Controls.Add(this.UI_Sine_LB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox UI_Sine_LB;
        private System.Windows.Forms.ListBox UI_Cos_LB;
        private System.Windows.Forms.Button UI_StartSine_Btn;
        private System.Windows.Forms.Button UI_StopSine_btn;
        private System.Windows.Forms.Button UI_StartCos_Btn;
        private System.Windows.Forms.Button UI_StopCos_btn;
    }
}

