namespace lab3
{
    partial class Difficulty
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UI_hard = new System.Windows.Forms.RadioButton();
            this.UI_medium = new System.Windows.Forms.RadioButton();
            this.UI_easy = new System.Windows.Forms.RadioButton();
            this.UI_OK = new System.Windows.Forms.Button();
            this.UI_Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UI_hard);
            this.groupBox1.Controls.Add(this.UI_medium);
            this.groupBox1.Controls.Add(this.UI_easy);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(184, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Difficulty";
            // 
            // UI_hard
            // 
            this.UI_hard.AutoSize = true;
            this.UI_hard.Location = new System.Drawing.Point(14, 111);
            this.UI_hard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_hard.Name = "UI_hard";
            this.UI_hard.Size = new System.Drawing.Size(48, 17);
            this.UI_hard.TabIndex = 2;
            this.UI_hard.TabStop = true;
            this.UI_hard.Text = "Hard";
            this.UI_hard.UseVisualStyleBackColor = true;
            // 
            // UI_medium
            // 
            this.UI_medium.AutoSize = true;
            this.UI_medium.Location = new System.Drawing.Point(14, 73);
            this.UI_medium.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_medium.Name = "UI_medium";
            this.UI_medium.Size = new System.Drawing.Size(62, 17);
            this.UI_medium.TabIndex = 1;
            this.UI_medium.TabStop = true;
            this.UI_medium.Text = "Medium";
            this.UI_medium.UseVisualStyleBackColor = true;
            // 
            // UI_easy
            // 
            this.UI_easy.AutoSize = true;
            this.UI_easy.Location = new System.Drawing.Point(14, 36);
            this.UI_easy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_easy.Name = "UI_easy";
            this.UI_easy.Size = new System.Drawing.Size(48, 17);
            this.UI_easy.TabIndex = 0;
            this.UI_easy.TabStop = true;
            this.UI_easy.Text = "Easy";
            this.UI_easy.UseVisualStyleBackColor = true;
            // 
            // UI_OK
            // 
            this.UI_OK.Location = new System.Drawing.Point(9, 186);
            this.UI_OK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_OK.Name = "UI_OK";
            this.UI_OK.Size = new System.Drawing.Size(56, 19);
            this.UI_OK.TabIndex = 1;
            this.UI_OK.Text = "OK";
            this.UI_OK.UseVisualStyleBackColor = true;
            this.UI_OK.Click += new System.EventHandler(this.UI_OK_Click);
            // 
            // UI_Cancel
            // 
            this.UI_Cancel.Location = new System.Drawing.Point(137, 186);
            this.UI_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_Cancel.Name = "UI_Cancel";
            this.UI_Cancel.Size = new System.Drawing.Size(56, 19);
            this.UI_Cancel.TabIndex = 2;
            this.UI_Cancel.Text = "Cancel";
            this.UI_Cancel.UseVisualStyleBackColor = true;
            this.UI_Cancel.Click += new System.EventHandler(this.UI_Cancel_Click);
            // 
            // Difficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 232);
            this.Controls.Add(this.UI_Cancel);
            this.Controls.Add(this.UI_OK);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Difficulty";
            this.Text = "Difficulty";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton UI_hard;
        private System.Windows.Forms.RadioButton UI_medium;
        private System.Windows.Forms.RadioButton UI_easy;
        private System.Windows.Forms.Button UI_OK;
        private System.Windows.Forms.Button UI_Cancel;
    }
}