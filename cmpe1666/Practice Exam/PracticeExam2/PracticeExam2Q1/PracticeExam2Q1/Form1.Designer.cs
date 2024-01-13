
namespace LE3Q2
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
            this.UI_RawData_LB = new System.Windows.Forms.ListBox();
            this.UI_SortedData_LB = new System.Windows.Forms.ListBox();
            this.UI_SelectedData_LB = new System.Windows.Forms.ListBox();
            this.UI_LoadStudents_Btn = new System.Windows.Forms.Button();
            this.UI_Sort_Btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UI_Ranking_Radio = new System.Windows.Forms.RadioButton();
            this.UI_Names_Radio = new System.Windows.Forms.RadioButton();
            this.UI_DisplaySelected_Btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.UI_Fails_radio = new System.Windows.Forms.RadioButton();
            this.UI_Passes_Radio = new System.Windows.Forms.RadioButton();
            this.UI_Agrades_Radio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.UI_Sorted_Lbl = new System.Windows.Forms.Label();
            this.UI_Selected_Lbl = new System.Windows.Forms.Label();
            this.UI_OpenFiles_Dlg = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_RawData_LB
            // 
            this.UI_RawData_LB.FormattingEnabled = true;
            this.UI_RawData_LB.Location = new System.Drawing.Point(21, 31);
            this.UI_RawData_LB.Margin = new System.Windows.Forms.Padding(1);
            this.UI_RawData_LB.Name = "UI_RawData_LB";
            this.UI_RawData_LB.Size = new System.Drawing.Size(250, 303);
            this.UI_RawData_LB.TabIndex = 0;
            // 
            // UI_SortedData_LB
            // 
            this.UI_SortedData_LB.FormattingEnabled = true;
            this.UI_SortedData_LB.Location = new System.Drawing.Point(324, 31);
            this.UI_SortedData_LB.Margin = new System.Windows.Forms.Padding(1);
            this.UI_SortedData_LB.Name = "UI_SortedData_LB";
            this.UI_SortedData_LB.Size = new System.Drawing.Size(271, 303);
            this.UI_SortedData_LB.TabIndex = 1;
            // 
            // UI_SelectedData_LB
            // 
            this.UI_SelectedData_LB.FormattingEnabled = true;
            this.UI_SelectedData_LB.Location = new System.Drawing.Point(648, 31);
            this.UI_SelectedData_LB.Margin = new System.Windows.Forms.Padding(1);
            this.UI_SelectedData_LB.Name = "UI_SelectedData_LB";
            this.UI_SelectedData_LB.Size = new System.Drawing.Size(267, 303);
            this.UI_SelectedData_LB.TabIndex = 2;
            // 
            // UI_LoadStudents_Btn
            // 
            this.UI_LoadStudents_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_LoadStudents_Btn.Location = new System.Drawing.Point(44, 463);
            this.UI_LoadStudents_Btn.Margin = new System.Windows.Forms.Padding(1);
            this.UI_LoadStudents_Btn.Name = "UI_LoadStudents_Btn";
            this.UI_LoadStudents_Btn.Size = new System.Drawing.Size(204, 49);
            this.UI_LoadStudents_Btn.TabIndex = 3;
            this.UI_LoadStudents_Btn.Text = "Load Students";
            this.UI_LoadStudents_Btn.UseVisualStyleBackColor = true;
            this.UI_LoadStudents_Btn.Click += new System.EventHandler(this.UI_LoadStudents_Btn_Click);
            // 
            // UI_Sort_Btn
            // 
            this.UI_Sort_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Sort_Btn.Location = new System.Drawing.Point(356, 463);
            this.UI_Sort_Btn.Margin = new System.Windows.Forms.Padding(1);
            this.UI_Sort_Btn.Name = "UI_Sort_Btn";
            this.UI_Sort_Btn.Size = new System.Drawing.Size(207, 57);
            this.UI_Sort_Btn.TabIndex = 6;
            this.UI_Sort_Btn.Text = "Display Sorted";
            this.UI_Sort_Btn.UseVisualStyleBackColor = true;
            this.UI_Sort_Btn.Click += new System.EventHandler(this.UI_Sort_Btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UI_Ranking_Radio);
            this.groupBox1.Controls.Add(this.UI_Names_Radio);
            this.groupBox1.Location = new System.Drawing.Point(342, 348);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(237, 62);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort Criteria";
            // 
            // UI_Ranking_Radio
            // 
            this.UI_Ranking_Radio.AutoSize = true;
            this.UI_Ranking_Radio.Location = new System.Drawing.Point(138, 26);
            this.UI_Ranking_Radio.Margin = new System.Windows.Forms.Padding(1);
            this.UI_Ranking_Radio.Name = "UI_Ranking_Radio";
            this.UI_Ranking_Radio.Size = new System.Drawing.Size(65, 17);
            this.UI_Ranking_Radio.TabIndex = 1;
            this.UI_Ranking_Radio.TabStop = true;
            this.UI_Ranking_Radio.Text = "Ranking";
            this.UI_Ranking_Radio.UseVisualStyleBackColor = true;
            // 
            // UI_Names_Radio
            // 
            this.UI_Names_Radio.AutoSize = true;
            this.UI_Names_Radio.Checked = true;
            this.UI_Names_Radio.Location = new System.Drawing.Point(12, 26);
            this.UI_Names_Radio.Margin = new System.Windows.Forms.Padding(1);
            this.UI_Names_Radio.Name = "UI_Names_Radio";
            this.UI_Names_Radio.Size = new System.Drawing.Size(58, 17);
            this.UI_Names_Radio.TabIndex = 0;
            this.UI_Names_Radio.TabStop = true;
            this.UI_Names_Radio.Text = "Names";
            this.UI_Names_Radio.UseVisualStyleBackColor = true;
            // 
            // UI_DisplaySelected_Btn
            // 
            this.UI_DisplaySelected_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_DisplaySelected_Btn.Location = new System.Drawing.Point(678, 463);
            this.UI_DisplaySelected_Btn.Margin = new System.Windows.Forms.Padding(1);
            this.UI_DisplaySelected_Btn.Name = "UI_DisplaySelected_Btn";
            this.UI_DisplaySelected_Btn.Size = new System.Drawing.Size(207, 57);
            this.UI_DisplaySelected_Btn.TabIndex = 9;
            this.UI_DisplaySelected_Btn.Text = "Display Selected";
            this.UI_DisplaySelected_Btn.UseVisualStyleBackColor = true;
            this.UI_DisplaySelected_Btn.Click += new System.EventHandler(this.UI_DisplaySelected_Btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.UI_Fails_radio);
            this.groupBox3.Controls.Add(this.UI_Passes_Radio);
            this.groupBox3.Controls.Add(this.UI_Agrades_Radio);
            this.groupBox3.Location = new System.Drawing.Point(652, 348);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox3.Size = new System.Drawing.Size(259, 106);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selection Criteria";
            // 
            // UI_Fails_radio
            // 
            this.UI_Fails_radio.AutoSize = true;
            this.UI_Fails_radio.Location = new System.Drawing.Point(9, 89);
            this.UI_Fails_radio.Margin = new System.Windows.Forms.Padding(1);
            this.UI_Fails_radio.Name = "UI_Fails_radio";
            this.UI_Fails_radio.Size = new System.Drawing.Size(87, 17);
            this.UI_Fails_radio.TabIndex = 2;
            this.UI_Fails_radio.Text = "All Fails (<50)";
            this.UI_Fails_radio.UseVisualStyleBackColor = true;
            // 
            // UI_Passes_Radio
            // 
            this.UI_Passes_Radio.AutoSize = true;
            this.UI_Passes_Radio.Checked = true;
            this.UI_Passes_Radio.Location = new System.Drawing.Point(9, 57);
            this.UI_Passes_Radio.Margin = new System.Windows.Forms.Padding(1);
            this.UI_Passes_Radio.Name = "UI_Passes_Radio";
            this.UI_Passes_Radio.Size = new System.Drawing.Size(101, 17);
            this.UI_Passes_Radio.TabIndex = 1;
            this.UI_Passes_Radio.TabStop = true;
            this.UI_Passes_Radio.Text = "All Pases (>=50)";
            this.UI_Passes_Radio.UseVisualStyleBackColor = true;
            // 
            // UI_Agrades_Radio
            // 
            this.UI_Agrades_Radio.AutoSize = true;
            this.UI_Agrades_Radio.Location = new System.Drawing.Point(9, 25);
            this.UI_Agrades_Radio.Margin = new System.Windows.Forms.Padding(1);
            this.UI_Agrades_Radio.Name = "UI_Agrades_Radio";
            this.UI_Agrades_Radio.Size = new System.Drawing.Size(120, 17);
            this.UI_Agrades_Radio.TabIndex = 0;
            this.UI_Agrades_Radio.Text = "A and Above (>=90)";
            this.UI_Agrades_Radio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Raw Data List ";
            // 
            // UI_Sorted_Lbl
            // 
            this.UI_Sorted_Lbl.AutoSize = true;
            this.UI_Sorted_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Sorted_Lbl.Location = new System.Drawing.Point(339, 9);
            this.UI_Sorted_Lbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.UI_Sorted_Lbl.Name = "UI_Sorted_Lbl";
            this.UI_Sorted_Lbl.Size = new System.Drawing.Size(121, 17);
            this.UI_Sorted_Lbl.TabIndex = 14;
            this.UI_Sorted_Lbl.Text = "Data Sorted On";
            // 
            // UI_Selected_Lbl
            // 
            this.UI_Selected_Lbl.AutoSize = true;
            this.UI_Selected_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Selected_Lbl.Location = new System.Drawing.Point(653, 8);
            this.UI_Selected_Lbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.UI_Selected_Lbl.Name = "UI_Selected_Lbl";
            this.UI_Selected_Lbl.Size = new System.Drawing.Size(140, 17);
            this.UI_Selected_Lbl.TabIndex = 15;
            this.UI_Selected_Lbl.Text = "Selected Students";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 568);
            this.Controls.Add(this.UI_Selected_Lbl);
            this.Controls.Add(this.UI_Sorted_Lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.UI_DisplaySelected_Btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UI_Sort_Btn);
            this.Controls.Add(this.UI_LoadStudents_Btn);
            this.Controls.Add(this.UI_SelectedData_LB);
            this.Controls.Add(this.UI_SortedData_LB);
            this.Controls.Add(this.UI_RawData_LB);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(831, 487);
            this.Name = "Form1";
            this.Text = "Lab Exam 3- Q2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UI_RawData_LB;
        private System.Windows.Forms.ListBox UI_SortedData_LB;
        private System.Windows.Forms.ListBox UI_SelectedData_LB;
        private System.Windows.Forms.Button UI_LoadStudents_Btn;
        private System.Windows.Forms.Button UI_Sort_Btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton UI_Ranking_Radio;
        private System.Windows.Forms.RadioButton UI_Names_Radio;
        private System.Windows.Forms.Button UI_DisplaySelected_Btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton UI_Passes_Radio;
        private System.Windows.Forms.RadioButton UI_Agrades_Radio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label UI_Sorted_Lbl;
        private System.Windows.Forms.Label UI_Selected_Lbl;
        private System.Windows.Forms.OpenFileDialog UI_OpenFiles_Dlg;
        private System.Windows.Forms.RadioButton UI_Fails_radio;
    }
}

