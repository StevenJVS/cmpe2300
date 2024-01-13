namespace Lab3
{
    partial class HighScore
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
            this.UI_PlayerName_lbl = new System.Windows.Forms.Label();
            this.UI_ok_btn = new System.Windows.Forms.Button();
            this.UI_cancel_btn = new System.Windows.Forms.Button();
            this.UI_playerName_txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UI_PlayerName_lbl
            // 
            this.UI_PlayerName_lbl.AutoSize = true;
            this.UI_PlayerName_lbl.Location = new System.Drawing.Point(12, 30);
            this.UI_PlayerName_lbl.Name = "UI_PlayerName_lbl";
            this.UI_PlayerName_lbl.Size = new System.Drawing.Size(70, 13);
            this.UI_PlayerName_lbl.TabIndex = 0;
            this.UI_PlayerName_lbl.Text = "Player Name:";
            // 
            // UI_ok_btn
            // 
            this.UI_ok_btn.Location = new System.Drawing.Point(15, 65);
            this.UI_ok_btn.Name = "UI_ok_btn";
            this.UI_ok_btn.Size = new System.Drawing.Size(75, 23);
            this.UI_ok_btn.TabIndex = 1;
            this.UI_ok_btn.Text = "OK";
            this.UI_ok_btn.UseVisualStyleBackColor = true;
            this.UI_ok_btn.Click += new System.EventHandler(this.UI_ok_btn_Click);
            // 
            // UI_cancel_btn
            // 
            this.UI_cancel_btn.Location = new System.Drawing.Point(141, 65);
            this.UI_cancel_btn.Name = "UI_cancel_btn";
            this.UI_cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.UI_cancel_btn.TabIndex = 2;
            this.UI_cancel_btn.Text = "Cancel";
            this.UI_cancel_btn.UseVisualStyleBackColor = true;
            this.UI_cancel_btn.Click += new System.EventHandler(this.UI_cancel_btn_Click);
            // 
            // UI_playerName_txtbox
            // 
            this.UI_playerName_txtbox.Location = new System.Drawing.Point(88, 27);
            this.UI_playerName_txtbox.Name = "UI_playerName_txtbox";
            this.UI_playerName_txtbox.Size = new System.Drawing.Size(128, 20);
            this.UI_playerName_txtbox.TabIndex = 3;
            // 
            // HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 101);
            this.Controls.Add(this.UI_playerName_txtbox);
            this.Controls.Add(this.UI_cancel_btn);
            this.Controls.Add(this.UI_ok_btn);
            this.Controls.Add(this.UI_PlayerName_lbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HighScore";
            this.Text = "HighScore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_PlayerName_lbl;
        private System.Windows.Forms.Button UI_ok_btn;
        private System.Windows.Forms.Button UI_cancel_btn;
        private System.Windows.Forms.TextBox UI_playerName_txtbox;
    }
}