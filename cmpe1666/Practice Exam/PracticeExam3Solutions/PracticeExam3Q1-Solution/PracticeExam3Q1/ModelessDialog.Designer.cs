namespace PracticeExam3Q1
{
    partial class ModelessDialog
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
            this.label2 = new System.Windows.Forms.Label();
            this.UI_value1_tbx = new System.Windows.Forms.TextBox();
            this.UI_value2_tbx = new System.Windows.Forms.TextBox();
            this.UI_Addition_Radio = new System.Windows.Forms.RadioButton();
            this.UI_Subtraction_Radio = new System.Windows.Forms.RadioButton();
            this.UI_Multiplication_Radio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "value1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "value2";
            // 
            // UI_value1_tbx
            // 
            this.UI_value1_tbx.Location = new System.Drawing.Point(197, 72);
            this.UI_value1_tbx.Name = "UI_value1_tbx";
            this.UI_value1_tbx.Size = new System.Drawing.Size(303, 20);
            this.UI_value1_tbx.TabIndex = 2;
            this.UI_value1_tbx.TextChanged += new System.EventHandler(this.perFormCalculation);
            // 
            // UI_value2_tbx
            // 
            this.UI_value2_tbx.Location = new System.Drawing.Point(197, 123);
            this.UI_value2_tbx.Name = "UI_value2_tbx";
            this.UI_value2_tbx.Size = new System.Drawing.Size(303, 20);
            this.UI_value2_tbx.TabIndex = 3;
            this.UI_value2_tbx.TextChanged += new System.EventHandler(this.perFormCalculation);
            // 
            // UI_Addition_Radio
            // 
            this.UI_Addition_Radio.AutoSize = true;
            this.UI_Addition_Radio.Checked = true;
            this.UI_Addition_Radio.Location = new System.Drawing.Point(17, 28);
            this.UI_Addition_Radio.Name = "UI_Addition_Radio";
            this.UI_Addition_Radio.Size = new System.Drawing.Size(63, 17);
            this.UI_Addition_Radio.TabIndex = 4;
            this.UI_Addition_Radio.TabStop = true;
            this.UI_Addition_Radio.Text = "Addition";
            this.UI_Addition_Radio.UseVisualStyleBackColor = true;
            this.UI_Addition_Radio.Click += new System.EventHandler(this.perFormCalculation);
            // 
            // UI_Subtraction_Radio
            // 
            this.UI_Subtraction_Radio.AutoSize = true;
            this.UI_Subtraction_Radio.Location = new System.Drawing.Point(17, 62);
            this.UI_Subtraction_Radio.Name = "UI_Subtraction_Radio";
            this.UI_Subtraction_Radio.Size = new System.Drawing.Size(79, 17);
            this.UI_Subtraction_Radio.TabIndex = 5;
            this.UI_Subtraction_Radio.TabStop = true;
            this.UI_Subtraction_Radio.Text = "Subtraction";
            this.UI_Subtraction_Radio.UseVisualStyleBackColor = true;
            this.UI_Subtraction_Radio.Click += new System.EventHandler(this.perFormCalculation);
            // 
            // UI_Multiplication_Radio
            // 
            this.UI_Multiplication_Radio.AutoSize = true;
            this.UI_Multiplication_Radio.Location = new System.Drawing.Point(17, 96);
            this.UI_Multiplication_Radio.Name = "UI_Multiplication_Radio";
            this.UI_Multiplication_Radio.Size = new System.Drawing.Size(86, 17);
            this.UI_Multiplication_Radio.TabIndex = 6;
            this.UI_Multiplication_Radio.TabStop = true;
            this.UI_Multiplication_Radio.Text = "Multiplication";
            this.UI_Multiplication_Radio.UseVisualStyleBackColor = true;
            this.UI_Multiplication_Radio.Click += new System.EventHandler(this.perFormCalculation);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UI_Addition_Radio);
            this.groupBox1.Controls.Add(this.UI_Subtraction_Radio);
            this.groupBox1.Controls.Add(this.UI_Multiplication_Radio);
            this.groupBox1.Location = new System.Drawing.Point(197, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 132);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operation";
            // 
            // ModelessDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UI_value2_tbx);
            this.Controls.Add(this.UI_value1_tbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModelessDialog";
            this.Text = "ModelessDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModelessDialog_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UI_value1_tbx;
        private System.Windows.Forms.TextBox UI_value2_tbx;
        private System.Windows.Forms.RadioButton UI_Addition_Radio;
        private System.Windows.Forms.RadioButton UI_Subtraction_Radio;
        private System.Windows.Forms.RadioButton UI_Multiplication_Radio;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}