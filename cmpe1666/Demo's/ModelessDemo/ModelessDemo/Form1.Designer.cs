namespace ModelessDemo
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
            this.UI_ShowDialog_Chx = new System.Windows.Forms.CheckBox();
            this.UI_DialogText_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_ShowDialog_Chx
            // 
            this.UI_ShowDialog_Chx.AutoSize = true;
            this.UI_ShowDialog_Chx.Location = new System.Drawing.Point(106, 75);
            this.UI_ShowDialog_Chx.Name = "UI_ShowDialog_Chx";
            this.UI_ShowDialog_Chx.Size = new System.Drawing.Size(86, 17);
            this.UI_ShowDialog_Chx.TabIndex = 0;
            this.UI_ShowDialog_Chx.Text = "Show Dialog";
            this.UI_ShowDialog_Chx.UseVisualStyleBackColor = true;
            this.UI_ShowDialog_Chx.CheckedChanged += new System.EventHandler(this.UI_ShowDialog_Chx_CheckedChanged);
            // 
            // UI_DialogText_Lbl
            // 
            this.UI_DialogText_Lbl.AutoSize = true;
            this.UI_DialogText_Lbl.Location = new System.Drawing.Point(103, 118);
            this.UI_DialogText_Lbl.Name = "UI_DialogText_Lbl";
            this.UI_DialogText_Lbl.Size = new System.Drawing.Size(35, 13);
            this.UI_DialogText_Lbl.TabIndex = 1;
            this.UI_DialogText_Lbl.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 162);
            this.Controls.Add(this.UI_DialogText_Lbl);
            this.Controls.Add(this.UI_ShowDialog_Chx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox UI_ShowDialog_Chx;
        private System.Windows.Forms.Label UI_DialogText_Lbl;
    }
}

