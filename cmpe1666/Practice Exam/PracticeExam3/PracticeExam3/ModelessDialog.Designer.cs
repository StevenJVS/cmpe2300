namespace PracticeExam3
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
            this.Ui_input1 = new System.Windows.Forms.TextBox();
            this.UI_input2 = new System.Windows.Forms.TextBox();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.Ui_addition = new System.Windows.Forms.RadioButton();
            this.Ui_subtraction = new System.Windows.Forms.RadioButton();
            this.Ui_multiplication = new System.Windows.Forms.RadioButton();
            this.groupbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "value1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "value2";
            // 
            // Ui_input1
            // 
            this.Ui_input1.Location = new System.Drawing.Point(263, 78);
            this.Ui_input1.Name = "Ui_input1";
            this.Ui_input1.Size = new System.Drawing.Size(100, 22);
            this.Ui_input1.TabIndex = 2;
            this.Ui_input1.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // UI_input2
            // 
            this.UI_input2.Location = new System.Drawing.Point(263, 123);
            this.UI_input2.Name = "UI_input2";
            this.UI_input2.Size = new System.Drawing.Size(100, 22);
            this.UI_input2.TabIndex = 3;
            this.UI_input2.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.Ui_multiplication);
            this.groupbox1.Controls.Add(this.Ui_subtraction);
            this.groupbox1.Controls.Add(this.Ui_addition);
            this.groupbox1.Location = new System.Drawing.Point(199, 210);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(219, 189);
            this.groupbox1.TabIndex = 4;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Operation";
            // 
            // Ui_addition
            // 
            this.Ui_addition.AutoSize = true;
            this.Ui_addition.Checked = true;
            this.Ui_addition.Location = new System.Drawing.Point(32, 48);
            this.Ui_addition.Name = "Ui_addition";
            this.Ui_addition.Size = new System.Drawing.Size(76, 20);
            this.Ui_addition.TabIndex = 0;
            this.Ui_addition.TabStop = true;
            this.Ui_addition.Text = "addition";
            this.Ui_addition.UseVisualStyleBackColor = true;
            this.Ui_addition.CheckedChanged += new System.EventHandler(this.UI_checked);
            // 
            // Ui_subtraction
            // 
            this.Ui_subtraction.AutoSize = true;
            this.Ui_subtraction.Location = new System.Drawing.Point(32, 87);
            this.Ui_subtraction.Name = "Ui_subtraction";
            this.Ui_subtraction.Size = new System.Drawing.Size(93, 20);
            this.Ui_subtraction.TabIndex = 1;
            this.Ui_subtraction.Text = "subtraction";
            this.Ui_subtraction.UseVisualStyleBackColor = true;
            this.Ui_subtraction.CheckedChanged += new System.EventHandler(this.UI_checked);
            // 
            // Ui_multiplication
            // 
            this.Ui_multiplication.AutoSize = true;
            this.Ui_multiplication.Location = new System.Drawing.Point(32, 131);
            this.Ui_multiplication.Name = "Ui_multiplication";
            this.Ui_multiplication.Size = new System.Drawing.Size(105, 20);
            this.Ui_multiplication.TabIndex = 2;
            this.Ui_multiplication.Text = "Multiplication";
            this.Ui_multiplication.UseVisualStyleBackColor = true;
            this.Ui_multiplication.CheckedChanged += new System.EventHandler(this.UI_checked);
            // 
            // ModelessDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupbox1);
            this.Controls.Add(this.UI_input2);
            this.Controls.Add(this.Ui_input1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModelessDialog";
            this.Text = "ModelessDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModelessDialog_FormClosing);
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Ui_input1;
        private System.Windows.Forms.TextBox UI_input2;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.RadioButton Ui_multiplication;
        private System.Windows.Forms.RadioButton Ui_subtraction;
        private System.Windows.Forms.RadioButton Ui_addition;
    }
}