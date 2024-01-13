namespace Lexture7_Exercise1
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
            this.UI_ObtainValues_Btn = new System.Windows.Forms.Button();
            this.UI_FirstValue_Tbx = new System.Windows.Forms.TextBox();
            this.UI_SecondValue_Tbx = new System.Windows.Forms.TextBox();
            this.Ui_Sum_Tbx = new System.Windows.Forms.TextBox();
            this.UI_FirstValue_Lbl = new System.Windows.Forms.Label();
            this.UI_SecondValue_Lbl = new System.Windows.Forms.Label();
            this.UI_Sum_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_ObtainValues_Btn
            // 
            this.UI_ObtainValues_Btn.Location = new System.Drawing.Point(157, 72);
            this.UI_ObtainValues_Btn.Name = "UI_ObtainValues_Btn";
            this.UI_ObtainValues_Btn.Size = new System.Drawing.Size(192, 68);
            this.UI_ObtainValues_Btn.TabIndex = 0;
            this.UI_ObtainValues_Btn.Text = "Obtain Values and Calculate";
            this.UI_ObtainValues_Btn.UseVisualStyleBackColor = true;
            this.UI_ObtainValues_Btn.Click += new System.EventHandler(this.UI_ObtainValues_Btn_Click);
            // 
            // UI_FirstValue_Tbx
            // 
            this.UI_FirstValue_Tbx.Location = new System.Drawing.Point(191, 185);
            this.UI_FirstValue_Tbx.Name = "UI_FirstValue_Tbx";
            this.UI_FirstValue_Tbx.Size = new System.Drawing.Size(169, 20);
            this.UI_FirstValue_Tbx.TabIndex = 1;
            // 
            // UI_SecondValue_Tbx
            // 
            this.UI_SecondValue_Tbx.Location = new System.Drawing.Point(191, 241);
            this.UI_SecondValue_Tbx.Name = "UI_SecondValue_Tbx";
            this.UI_SecondValue_Tbx.Size = new System.Drawing.Size(169, 20);
            this.UI_SecondValue_Tbx.TabIndex = 2;
            // 
            // Ui_Sum_Tbx
            // 
            this.Ui_Sum_Tbx.Location = new System.Drawing.Point(191, 302);
            this.Ui_Sum_Tbx.Name = "Ui_Sum_Tbx";
            this.Ui_Sum_Tbx.ReadOnly = true;
            this.Ui_Sum_Tbx.Size = new System.Drawing.Size(169, 20);
            this.Ui_Sum_Tbx.TabIndex = 3;
            // 
            // UI_FirstValue_Lbl
            // 
            this.UI_FirstValue_Lbl.AutoSize = true;
            this.UI_FirstValue_Lbl.Location = new System.Drawing.Point(124, 188);
            this.UI_FirstValue_Lbl.Name = "UI_FirstValue_Lbl";
            this.UI_FirstValue_Lbl.Size = new System.Drawing.Size(56, 13);
            this.UI_FirstValue_Lbl.TabIndex = 4;
            this.UI_FirstValue_Lbl.Text = "First Value";
            // 
            // UI_SecondValue_Lbl
            // 
            this.UI_SecondValue_Lbl.AutoSize = true;
            this.UI_SecondValue_Lbl.Location = new System.Drawing.Point(106, 248);
            this.UI_SecondValue_Lbl.Name = "UI_SecondValue_Lbl";
            this.UI_SecondValue_Lbl.Size = new System.Drawing.Size(74, 13);
            this.UI_SecondValue_Lbl.TabIndex = 5;
            this.UI_SecondValue_Lbl.Text = "Second Value";
            // 
            // UI_Sum_Lbl
            // 
            this.UI_Sum_Lbl.AutoSize = true;
            this.UI_Sum_Lbl.Location = new System.Drawing.Point(142, 309);
            this.UI_Sum_Lbl.Name = "UI_Sum_Lbl";
            this.UI_Sum_Lbl.Size = new System.Drawing.Size(28, 13);
            this.UI_Sum_Lbl.TabIndex = 6;
            this.UI_Sum_Lbl.Text = "Sum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_Sum_Lbl);
            this.Controls.Add(this.UI_SecondValue_Lbl);
            this.Controls.Add(this.UI_FirstValue_Lbl);
            this.Controls.Add(this.Ui_Sum_Tbx);
            this.Controls.Add(this.UI_SecondValue_Tbx);
            this.Controls.Add(this.UI_FirstValue_Tbx);
            this.Controls.Add(this.UI_ObtainValues_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_ObtainValues_Btn;
        private System.Windows.Forms.TextBox UI_FirstValue_Tbx;
        private System.Windows.Forms.TextBox UI_SecondValue_Tbx;
        private System.Windows.Forms.TextBox Ui_Sum_Tbx;
        private System.Windows.Forms.Label UI_FirstValue_Lbl;
        private System.Windows.Forms.Label UI_SecondValue_Lbl;
        private System.Windows.Forms.Label UI_Sum_Lbl;
    }
}

