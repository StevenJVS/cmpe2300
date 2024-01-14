namespace lab1
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
            this.UI_Load_Btn = new System.Windows.Forms.Button();
            this.UI_Solve_Btn = new System.Windows.Forms.Button();
            this.UI_Display = new System.Windows.Forms.PictureBox();
            this.UI_Message_txtbx = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Display)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_Load_Btn
            // 
            this.UI_Load_Btn.Location = new System.Drawing.Point(12, 380);
            this.UI_Load_Btn.Name = "UI_Load_Btn";
            this.UI_Load_Btn.Size = new System.Drawing.Size(75, 23);
            this.UI_Load_Btn.TabIndex = 0;
            this.UI_Load_Btn.Text = "Load Maze";
            this.UI_Load_Btn.UseVisualStyleBackColor = true;
            this.UI_Load_Btn.Click += new System.EventHandler(this.UI_Load_Btn_Click);
            // 
            // UI_Solve_Btn
            // 
            this.UI_Solve_Btn.Enabled = false;
            this.UI_Solve_Btn.Location = new System.Drawing.Point(406, 380);
            this.UI_Solve_Btn.Name = "UI_Solve_Btn";
            this.UI_Solve_Btn.Size = new System.Drawing.Size(75, 23);
            this.UI_Solve_Btn.TabIndex = 1;
            this.UI_Solve_Btn.Text = "Solve Maze";
            this.UI_Solve_Btn.UseVisualStyleBackColor = true;
            this.UI_Solve_Btn.Click += new System.EventHandler(this.UI_Solve_Btn_Click);
            // 
            // UI_Display
            // 
            this.UI_Display.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UI_Display.Location = new System.Drawing.Point(78, 12);
            this.UI_Display.Name = "UI_Display";
            this.UI_Display.Size = new System.Drawing.Size(348, 271);
            this.UI_Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UI_Display.TabIndex = 2;
            this.UI_Display.TabStop = false;
            // 
            // UI_Message_txtbx
            // 
            this.UI_Message_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UI_Message_txtbx.Location = new System.Drawing.Point(35, 295);
            this.UI_Message_txtbx.Name = "UI_Message_txtbx";
            this.UI_Message_txtbx.Size = new System.Drawing.Size(422, 75);
            this.UI_Message_txtbx.TabIndex = 3;
            this.UI_Message_txtbx.Text = "Please load a maze";
            this.UI_Message_txtbx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 414);
            this.Controls.Add(this.UI_Message_txtbx);
            this.Controls.Add(this.UI_Display);
            this.Controls.Add(this.UI_Solve_Btn);
            this.Controls.Add(this.UI_Load_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UI_Display)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UI_Load_Btn;
        private System.Windows.Forms.Button UI_Solve_Btn;
        private System.Windows.Forms.PictureBox UI_Display;
        private System.Windows.Forms.Label UI_Message_txtbx;
    }
}

