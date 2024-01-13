namespace lab3
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
            this.components = new System.ComponentModel.Container();
            this.UI_Showscore = new System.Windows.Forms.CheckBox();
            this.UI_AnimationSpeed = new System.Windows.Forms.CheckBox();
            this.UI_PlayBtn = new System.Windows.Forms.Button();
            this.UI_timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UI_Showscore
            // 
            this.UI_Showscore.AutoSize = true;
            this.UI_Showscore.Location = new System.Drawing.Point(21, 24);
            this.UI_Showscore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_Showscore.Name = "UI_Showscore";
            this.UI_Showscore.Size = new System.Drawing.Size(84, 17);
            this.UI_Showscore.TabIndex = 0;
            this.UI_Showscore.Text = "Show Score";
            this.UI_Showscore.UseVisualStyleBackColor = true;
            this.UI_Showscore.CheckedChanged += new System.EventHandler(this.UI_Check);
            // 
            // UI_AnimationSpeed
            // 
            this.UI_AnimationSpeed.AutoSize = true;
            this.UI_AnimationSpeed.Location = new System.Drawing.Point(21, 61);
            this.UI_AnimationSpeed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_AnimationSpeed.Name = "UI_AnimationSpeed";
            this.UI_AnimationSpeed.Size = new System.Drawing.Size(134, 17);
            this.UI_AnimationSpeed.TabIndex = 1;
            this.UI_AnimationSpeed.Text = "Show Animation speed";
            this.UI_AnimationSpeed.UseVisualStyleBackColor = true;
            this.UI_AnimationSpeed.CheckedChanged += new System.EventHandler(this.UI_Check);
            // 
            // UI_PlayBtn
            // 
            this.UI_PlayBtn.Location = new System.Drawing.Point(108, 97);
            this.UI_PlayBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_PlayBtn.Name = "UI_PlayBtn";
            this.UI_PlayBtn.Size = new System.Drawing.Size(56, 19);
            this.UI_PlayBtn.TabIndex = 2;
            this.UI_PlayBtn.Text = "Play";
            this.UI_PlayBtn.UseVisualStyleBackColor = true;
            this.UI_PlayBtn.Click += new System.EventHandler(this.UI_PlayBtn_Click);
            // 
            // UI_timer
            // 
            this.UI_timer.Tick += new System.EventHandler(this.UI_timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 132);
            this.Controls.Add(this.UI_PlayBtn);
            this.Controls.Add(this.UI_AnimationSpeed);
            this.Controls.Add(this.UI_Showscore);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox UI_Showscore;
        private System.Windows.Forms.CheckBox UI_AnimationSpeed;
        private System.Windows.Forms.Button UI_PlayBtn;
        private System.Windows.Forms.Timer UI_timer;
    }
}

