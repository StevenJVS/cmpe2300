namespace Lab3
{
    partial class Select_Diffculty
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
            this.UI_diffculty_groupBox = new System.Windows.Forms.GroupBox();
            this.UI_hard_radioBtn = new System.Windows.Forms.RadioButton();
            this.UI_medium_radioBtn = new System.Windows.Forms.RadioButton();
            this.UI_easy_radiobtn = new System.Windows.Forms.RadioButton();
            this.UI_ok_btn = new System.Windows.Forms.Button();
            this.UI_Cancel_btn = new System.Windows.Forms.Button();
            this.UI_diffculty_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_diffculty_groupBox
            // 
            this.UI_diffculty_groupBox.Controls.Add(this.UI_hard_radioBtn);
            this.UI_diffculty_groupBox.Controls.Add(this.UI_medium_radioBtn);
            this.UI_diffculty_groupBox.Controls.Add(this.UI_easy_radiobtn);
            this.UI_diffculty_groupBox.Location = new System.Drawing.Point(12, 12);
            this.UI_diffculty_groupBox.Name = "UI_diffculty_groupBox";
            this.UI_diffculty_groupBox.Size = new System.Drawing.Size(172, 101);
            this.UI_diffculty_groupBox.TabIndex = 0;
            this.UI_diffculty_groupBox.TabStop = false;
            this.UI_diffculty_groupBox.Text = "Difficulty";
            // 
            // UI_hard_radioBtn
            // 
            this.UI_hard_radioBtn.AutoSize = true;
            this.UI_hard_radioBtn.Location = new System.Drawing.Point(7, 65);
            this.UI_hard_radioBtn.Name = "UI_hard_radioBtn";
            this.UI_hard_radioBtn.Size = new System.Drawing.Size(48, 17);
            this.UI_hard_radioBtn.TabIndex = 2;
            this.UI_hard_radioBtn.TabStop = true;
            this.UI_hard_radioBtn.Text = "Hard";
            this.UI_hard_radioBtn.UseVisualStyleBackColor = true;
            // 
            // UI_medium_radioBtn
            // 
            this.UI_medium_radioBtn.AutoSize = true;
            this.UI_medium_radioBtn.Location = new System.Drawing.Point(7, 43);
            this.UI_medium_radioBtn.Name = "UI_medium_radioBtn";
            this.UI_medium_radioBtn.Size = new System.Drawing.Size(62, 17);
            this.UI_medium_radioBtn.TabIndex = 1;
            this.UI_medium_radioBtn.TabStop = true;
            this.UI_medium_radioBtn.Text = "Medium";
            this.UI_medium_radioBtn.UseVisualStyleBackColor = true;
            // 
            // UI_easy_radiobtn
            // 
            this.UI_easy_radiobtn.AutoSize = true;
            this.UI_easy_radiobtn.Location = new System.Drawing.Point(7, 20);
            this.UI_easy_radiobtn.Name = "UI_easy_radiobtn";
            this.UI_easy_radiobtn.Size = new System.Drawing.Size(48, 17);
            this.UI_easy_radiobtn.TabIndex = 0;
            this.UI_easy_radiobtn.TabStop = true;
            this.UI_easy_radiobtn.Text = "Easy";
            this.UI_easy_radiobtn.UseVisualStyleBackColor = true;
            // 
            // UI_ok_btn
            // 
            this.UI_ok_btn.Location = new System.Drawing.Point(19, 119);
            this.UI_ok_btn.Name = "UI_ok_btn";
            this.UI_ok_btn.Size = new System.Drawing.Size(75, 23);
            this.UI_ok_btn.TabIndex = 1;
            this.UI_ok_btn.Text = "OK";
            this.UI_ok_btn.UseMnemonic = false;
            this.UI_ok_btn.UseVisualStyleBackColor = true;
            this.UI_ok_btn.Click += new System.EventHandler(this.UI_ok_btn_Click);
            // 
            // UI_Cancel_btn
            // 
            this.UI_Cancel_btn.Location = new System.Drawing.Point(109, 119);
            this.UI_Cancel_btn.Name = "UI_Cancel_btn";
            this.UI_Cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.UI_Cancel_btn.TabIndex = 2;
            this.UI_Cancel_btn.Text = "Cancel";
            this.UI_Cancel_btn.UseVisualStyleBackColor = true;
            this.UI_Cancel_btn.Click += new System.EventHandler(this.UI_Cancel_btn_Click);
            // 
            // Select_Diffculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 154);
            this.Controls.Add(this.UI_Cancel_btn);
            this.Controls.Add(this.UI_ok_btn);
            this.Controls.Add(this.UI_diffculty_groupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Select_Diffculty";
            this.Text = "Select_Diffculty";
            this.UI_diffculty_groupBox.ResumeLayout(false);
            this.UI_diffculty_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UI_diffculty_groupBox;
        private System.Windows.Forms.RadioButton UI_hard_radioBtn;
        private System.Windows.Forms.RadioButton UI_medium_radioBtn;
        private System.Windows.Forms.RadioButton UI_easy_radiobtn;
        private System.Windows.Forms.Button UI_ok_btn;
        private System.Windows.Forms.Button UI_Cancel_btn;
    }
}