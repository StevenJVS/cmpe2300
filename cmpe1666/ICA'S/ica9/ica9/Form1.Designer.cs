namespace ica9
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
            this.label2 = new System.Windows.Forms.Label();
            this.UI_unsortedlist = new System.Windows.Forms.ListBox();
            this.UI_sortedlist = new System.Windows.Forms.ListBox();
            this.UI_displayunsort = new System.Windows.Forms.Button();
            this.UI_Clearunsorted = new System.Windows.Forms.Button();
            this.UI_bubblesort = new System.Windows.Forms.Button();
            this.UI_quicksort = new System.Windows.Forms.Button();
            this.UI_Clearsorted = new System.Windows.Forms.Button();
            this.UI_loadfiles = new System.Windows.Forms.Button();
            this.UI_Rprovided = new System.Windows.Forms.RadioButton();
            this.UI_Rfiledata = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.UI_elapsed_lbl = new System.Windows.Forms.TextBox();
            this.UI_openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.UI_openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unsorted Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sorted Data";
            // 
            // UI_unsortedlist
            // 
            this.UI_unsortedlist.FormattingEnabled = true;
            this.UI_unsortedlist.Location = new System.Drawing.Point(9, 54);
            this.UI_unsortedlist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_unsortedlist.Name = "UI_unsortedlist";
            this.UI_unsortedlist.Size = new System.Drawing.Size(223, 303);
            this.UI_unsortedlist.TabIndex = 2;
            // 
            // UI_sortedlist
            // 
            this.UI_sortedlist.FormattingEnabled = true;
            this.UI_sortedlist.Location = new System.Drawing.Point(398, 54);
            this.UI_sortedlist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_sortedlist.Name = "UI_sortedlist";
            this.UI_sortedlist.Size = new System.Drawing.Size(201, 303);
            this.UI_sortedlist.TabIndex = 3;
            // 
            // UI_displayunsort
            // 
            this.UI_displayunsort.Location = new System.Drawing.Point(256, 54);
            this.UI_displayunsort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_displayunsort.Name = "UI_displayunsort";
            this.UI_displayunsort.Size = new System.Drawing.Size(112, 37);
            this.UI_displayunsort.TabIndex = 4;
            this.UI_displayunsort.Text = "Display Unsorted List";
            this.UI_displayunsort.UseVisualStyleBackColor = true;
            this.UI_displayunsort.Click += new System.EventHandler(this.UI_displayunsort_Click);
            // 
            // UI_Clearunsorted
            // 
            this.UI_Clearunsorted.Location = new System.Drawing.Point(256, 96);
            this.UI_Clearunsorted.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_Clearunsorted.Name = "UI_Clearunsorted";
            this.UI_Clearunsorted.Size = new System.Drawing.Size(112, 41);
            this.UI_Clearunsorted.TabIndex = 5;
            this.UI_Clearunsorted.Text = "Clear Unsorted Listbox";
            this.UI_Clearunsorted.UseVisualStyleBackColor = true;
            this.UI_Clearunsorted.Click += new System.EventHandler(this.UI_Clearunsorted_Click);
            // 
            // UI_bubblesort
            // 
            this.UI_bubblesort.Location = new System.Drawing.Point(256, 193);
            this.UI_bubblesort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_bubblesort.Name = "UI_bubblesort";
            this.UI_bubblesort.Size = new System.Drawing.Size(112, 37);
            this.UI_bubblesort.TabIndex = 6;
            this.UI_bubblesort.Text = "Bubble Sort";
            this.UI_bubblesort.UseVisualStyleBackColor = true;
            this.UI_bubblesort.Click += new System.EventHandler(this.UI_bubblesort_Click);
            // 
            // UI_quicksort
            // 
            this.UI_quicksort.Location = new System.Drawing.Point(256, 235);
            this.UI_quicksort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_quicksort.Name = "UI_quicksort";
            this.UI_quicksort.Size = new System.Drawing.Size(112, 37);
            this.UI_quicksort.TabIndex = 7;
            this.UI_quicksort.Text = "Quick Sort";
            this.UI_quicksort.UseVisualStyleBackColor = true;
            this.UI_quicksort.Click += new System.EventHandler(this.UI_quicksort_Click);
            // 
            // UI_Clearsorted
            // 
            this.UI_Clearsorted.Location = new System.Drawing.Point(256, 276);
            this.UI_Clearsorted.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_Clearsorted.Name = "UI_Clearsorted";
            this.UI_Clearsorted.Size = new System.Drawing.Size(112, 37);
            this.UI_Clearsorted.TabIndex = 8;
            this.UI_Clearsorted.Text = "Clear Sorted Listbox";
            this.UI_Clearsorted.UseVisualStyleBackColor = true;
            this.UI_Clearsorted.Click += new System.EventHandler(this.UI_Clearsorted_Click);
            // 
            // UI_loadfiles
            // 
            this.UI_loadfiles.Enabled = false;
            this.UI_loadfiles.Location = new System.Drawing.Point(256, 318);
            this.UI_loadfiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_loadfiles.Name = "UI_loadfiles";
            this.UI_loadfiles.Size = new System.Drawing.Size(112, 37);
            this.UI_loadfiles.TabIndex = 9;
            this.UI_loadfiles.Text = "Load Files";
            this.UI_loadfiles.UseVisualStyleBackColor = true;
            this.UI_loadfiles.Click += new System.EventHandler(this.UI_loadfiles_Click);
            // 
            // UI_Rprovided
            // 
            this.UI_Rprovided.AutoSize = true;
            this.UI_Rprovided.Checked = true;
            this.UI_Rprovided.Location = new System.Drawing.Point(256, 150);
            this.UI_Rprovided.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_Rprovided.Name = "UI_Rprovided";
            this.UI_Rprovided.Size = new System.Drawing.Size(86, 17);
            this.UI_Rprovided.TabIndex = 10;
            this.UI_Rprovided.TabStop = true;
            this.UI_Rprovided.Text = "Provided List";
            this.UI_Rprovided.UseVisualStyleBackColor = true;
            this.UI_Rprovided.CheckedChanged += new System.EventHandler(this.UI_radio);
            this.UI_Rprovided.Click += new System.EventHandler(this.UI_radio);
            // 
            // UI_Rfiledata
            // 
            this.UI_Rfiledata.AutoSize = true;
            this.UI_Rfiledata.Location = new System.Drawing.Point(256, 171);
            this.UI_Rfiledata.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_Rfiledata.Name = "UI_Rfiledata";
            this.UI_Rfiledata.Size = new System.Drawing.Size(67, 17);
            this.UI_Rfiledata.TabIndex = 11;
            this.UI_Rfiledata.Text = "File Data";
            this.UI_Rfiledata.UseVisualStyleBackColor = true;
            this.UI_Rfiledata.CheckedChanged += new System.EventHandler(this.UI_radio);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(334, 366);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Time Taken (Elapsed Ticks):";
            // 
            // UI_elapsed_lbl
            // 
            this.UI_elapsed_lbl.Location = new System.Drawing.Point(503, 364);
            this.UI_elapsed_lbl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_elapsed_lbl.Name = "UI_elapsed_lbl";
            this.UI_elapsed_lbl.ReadOnly = true;
            this.UI_elapsed_lbl.Size = new System.Drawing.Size(96, 20);
            this.UI_elapsed_lbl.TabIndex = 14;
            // 
            // UI_openFileDialog1
            // 
            this.UI_openFileDialog1.FileName = "openFileDialog";
            // 
            // UI_openFileDialog2
            // 
            this.UI_openFileDialog2.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 394);
            this.Controls.Add(this.UI_elapsed_lbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UI_Rfiledata);
            this.Controls.Add(this.UI_Rprovided);
            this.Controls.Add(this.UI_loadfiles);
            this.Controls.Add(this.UI_Clearsorted);
            this.Controls.Add(this.UI_quicksort);
            this.Controls.Add(this.UI_bubblesort);
            this.Controls.Add(this.UI_Clearunsorted);
            this.Controls.Add(this.UI_displayunsort);
            this.Controls.Add(this.UI_sortedlist);
            this.Controls.Add(this.UI_unsortedlist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox UI_unsortedlist;
        private System.Windows.Forms.ListBox UI_sortedlist;
        private System.Windows.Forms.Button UI_displayunsort;
        private System.Windows.Forms.Button UI_Clearunsorted;
        private System.Windows.Forms.Button UI_bubblesort;
        private System.Windows.Forms.Button UI_quicksort;
        private System.Windows.Forms.Button UI_Clearsorted;
        private System.Windows.Forms.Button UI_loadfiles;
        private System.Windows.Forms.RadioButton UI_Rprovided;
        private System.Windows.Forms.RadioButton UI_Rfiledata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UI_elapsed_lbl;
        private System.Windows.Forms.OpenFileDialog UI_openFileDialog1;
        private System.Windows.Forms.OpenFileDialog UI_openFileDialog2;
    }
}

