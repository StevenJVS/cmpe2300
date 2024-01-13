namespace lab3
{
    partial class HighScoredialog
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
            this.UI_textbox = new System.Windows.Forms.TextBox();
            this.UI_Ok = new System.Windows.Forms.Button();
            this.UI_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Name:";
            // 
            // UI_textbox
            // 
            this.UI_textbox.Location = new System.Drawing.Point(87, 53);
            this.UI_textbox.Name = "UI_textbox";
            this.UI_textbox.Size = new System.Drawing.Size(269, 22);
            this.UI_textbox.TabIndex = 1;
            // 
            // UI_Ok
            // 
            this.UI_Ok.Location = new System.Drawing.Point(87, 109);
            this.UI_Ok.Name = "UI_Ok";
            this.UI_Ok.Size = new System.Drawing.Size(75, 23);
            this.UI_Ok.TabIndex = 2;
            this.UI_Ok.Text = "OK";
            this.UI_Ok.UseVisualStyleBackColor = true;
            this.UI_Ok.Click += new System.EventHandler(this.UI_Ok_Click);
            // 
            // UI_cancel
            // 
            this.UI_cancel.Location = new System.Drawing.Point(281, 109);
            this.UI_cancel.Name = "UI_cancel";
            this.UI_cancel.Size = new System.Drawing.Size(75, 23);
            this.UI_cancel.TabIndex = 3;
            this.UI_cancel.Text = "Cancel";
            this.UI_cancel.UseVisualStyleBackColor = true;
            this.UI_cancel.Click += new System.EventHandler(this.UI_cancel_Click);
            // 
            // HighScoredialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 169);
            this.Controls.Add(this.UI_cancel);
            this.Controls.Add(this.UI_Ok);
            this.Controls.Add(this.UI_textbox);
            this.Controls.Add(this.label1);
            this.Name = "HighScoredialog";
            this.Text = "HighScoredialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UI_textbox;
        private System.Windows.Forms.Button UI_Ok;
        private System.Windows.Forms.Button UI_cancel;
    }
}