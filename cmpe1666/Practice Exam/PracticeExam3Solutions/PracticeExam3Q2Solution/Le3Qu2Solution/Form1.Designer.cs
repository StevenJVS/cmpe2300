namespace Le3Qu2Solution
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
            this.UI_FixedRange_Lbx = new System.Windows.Forms.ListBox();
            this.UI_VariableRange_Lbx = new System.Windows.Forms.ListBox();
            this.Ui_FixedRange_Btn = new System.Windows.Forms.Button();
            this.Ui_MinValue_Lbl = new System.Windows.Forms.Label();
            this.UI_MaxValue_Lbl = new System.Windows.Forms.Label();
            this.UI_NumValues_lbl = new System.Windows.Forms.Label();
            this.UI_VariableRange_Btn = new System.Windows.Forms.Button();
            this.UI_MinValue_Tbx = new System.Windows.Forms.TextBox();
            this.UI_MaxValue_Tbx = new System.Windows.Forms.TextBox();
            this.UI_NumValues_Tbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_FixedRange_Lbx
            // 
            this.UI_FixedRange_Lbx.FormattingEnabled = true;
            this.UI_FixedRange_Lbx.ItemHeight = 20;
            this.UI_FixedRange_Lbx.Location = new System.Drawing.Point(12, 36);
            this.UI_FixedRange_Lbx.Name = "UI_FixedRange_Lbx";
            this.UI_FixedRange_Lbx.Size = new System.Drawing.Size(246, 284);
            this.UI_FixedRange_Lbx.TabIndex = 0;
            // 
            // UI_VariableRange_Lbx
            // 
            this.UI_VariableRange_Lbx.FormattingEnabled = true;
            this.UI_VariableRange_Lbx.ItemHeight = 20;
            this.UI_VariableRange_Lbx.Location = new System.Drawing.Point(586, 36);
            this.UI_VariableRange_Lbx.Name = "UI_VariableRange_Lbx";
            this.UI_VariableRange_Lbx.Size = new System.Drawing.Size(303, 264);
            this.UI_VariableRange_Lbx.TabIndex = 1;
            // 
            // Ui_FixedRange_Btn
            // 
            this.Ui_FixedRange_Btn.Location = new System.Drawing.Point(12, 346);
            this.Ui_FixedRange_Btn.Name = "Ui_FixedRange_Btn";
            this.Ui_FixedRange_Btn.Size = new System.Drawing.Size(246, 67);
            this.Ui_FixedRange_Btn.TabIndex = 2;
            this.Ui_FixedRange_Btn.Text = "Generate Fixed Range";
            this.Ui_FixedRange_Btn.UseVisualStyleBackColor = true;
            this.Ui_FixedRange_Btn.Click += new System.EventHandler(this.Ui_FixedRange_Btn_Click);
            // 
            // Ui_MinValue_Lbl
            // 
            this.Ui_MinValue_Lbl.AutoSize = true;
            this.Ui_MinValue_Lbl.Location = new System.Drawing.Point(582, 342);
            this.Ui_MinValue_Lbl.Name = "Ui_MinValue_Lbl";
            this.Ui_MinValue_Lbl.Size = new System.Drawing.Size(173, 20);
            this.Ui_MinValue_Lbl.TabIndex = 3;
            this.Ui_MinValue_Lbl.Text = "Minimum Range Value:";
            // 
            // UI_MaxValue_Lbl
            // 
            this.UI_MaxValue_Lbl.AutoSize = true;
            this.UI_MaxValue_Lbl.Location = new System.Drawing.Point(582, 390);
            this.UI_MaxValue_Lbl.Name = "UI_MaxValue_Lbl";
            this.UI_MaxValue_Lbl.Size = new System.Drawing.Size(177, 20);
            this.UI_MaxValue_Lbl.TabIndex = 4;
            this.UI_MaxValue_Lbl.Text = "Maximum Range Value:";
            // 
            // UI_NumValues_lbl
            // 
            this.UI_NumValues_lbl.AutoSize = true;
            this.UI_NumValues_lbl.Location = new System.Drawing.Point(582, 436);
            this.UI_NumValues_lbl.Name = "UI_NumValues_lbl";
            this.UI_NumValues_lbl.Size = new System.Drawing.Size(140, 20);
            this.UI_NumValues_lbl.TabIndex = 5;
            this.UI_NumValues_lbl.Text = "Number of Values:";
            // 
            // UI_VariableRange_Btn
            // 
            this.UI_VariableRange_Btn.Location = new System.Drawing.Point(614, 503);
            this.UI_VariableRange_Btn.Name = "UI_VariableRange_Btn";
            this.UI_VariableRange_Btn.Size = new System.Drawing.Size(246, 61);
            this.UI_VariableRange_Btn.TabIndex = 6;
            this.UI_VariableRange_Btn.Text = "Generate Variable  Range";
            this.UI_VariableRange_Btn.UseVisualStyleBackColor = true;
            this.UI_VariableRange_Btn.Click += new System.EventHandler(this.UI_VariableRange_Btn_Click);
            // 
            // UI_MinValue_Tbx
            // 
            this.UI_MinValue_Tbx.Location = new System.Drawing.Point(785, 336);
            this.UI_MinValue_Tbx.Name = "UI_MinValue_Tbx";
            this.UI_MinValue_Tbx.Size = new System.Drawing.Size(104, 26);
            this.UI_MinValue_Tbx.TabIndex = 7;
            // 
            // UI_MaxValue_Tbx
            // 
            this.UI_MaxValue_Tbx.Location = new System.Drawing.Point(785, 387);
            this.UI_MaxValue_Tbx.Name = "UI_MaxValue_Tbx";
            this.UI_MaxValue_Tbx.Size = new System.Drawing.Size(104, 26);
            this.UI_MaxValue_Tbx.TabIndex = 8;
            // 
            // UI_NumValues_Tbx
            // 
            this.UI_NumValues_Tbx.Location = new System.Drawing.Point(785, 436);
            this.UI_NumValues_Tbx.Name = "UI_NumValues_Tbx";
            this.UI_NumValues_Tbx.Size = new System.Drawing.Size(104, 26);
            this.UI_NumValues_Tbx.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fixed Range Values";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(645, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Variable Range Values";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 612);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UI_NumValues_Tbx);
            this.Controls.Add(this.UI_MaxValue_Tbx);
            this.Controls.Add(this.UI_MinValue_Tbx);
            this.Controls.Add(this.UI_VariableRange_Btn);
            this.Controls.Add(this.UI_NumValues_lbl);
            this.Controls.Add(this.UI_MaxValue_Lbl);
            this.Controls.Add(this.Ui_MinValue_Lbl);
            this.Controls.Add(this.Ui_FixedRange_Btn);
            this.Controls.Add(this.UI_VariableRange_Lbx);
            this.Controls.Add(this.UI_FixedRange_Lbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UI_FixedRange_Lbx;
        private System.Windows.Forms.ListBox UI_VariableRange_Lbx;
        private System.Windows.Forms.Button Ui_FixedRange_Btn;
        private System.Windows.Forms.Label Ui_MinValue_Lbl;
        private System.Windows.Forms.Label UI_MaxValue_Lbl;
        private System.Windows.Forms.Label UI_NumValues_lbl;
        private System.Windows.Forms.Button UI_VariableRange_Btn;
        private System.Windows.Forms.TextBox UI_MinValue_Tbx;
        private System.Windows.Forms.TextBox UI_MaxValue_Tbx;
        private System.Windows.Forms.TextBox UI_NumValues_Tbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

