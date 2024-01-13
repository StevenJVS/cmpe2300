namespace ica6
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
            this.UI_trackbar = new System.Windows.Forms.TrackBar();
            this.UI_generatebutton = new System.Windows.Forms.Button();
            this.UI_fill_color = new System.Windows.Forms.Button();
            this.UI_fillcolor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UI_colordialog = new System.Windows.Forms.ColorDialog();
            this.UI_picturebox = new System.Windows.Forms.PictureBox();
            this.UI_100 = new System.Windows.Forms.Label();
            this.UI_3000 = new System.Windows.Forms.Label();
            this.UI_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UI_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_trackbar
            // 
            this.UI_trackbar.Location = new System.Drawing.Point(43, 73);
            this.UI_trackbar.Maximum = 3000;
            this.UI_trackbar.Minimum = 100;
            this.UI_trackbar.Name = "UI_trackbar";
            this.UI_trackbar.Size = new System.Drawing.Size(412, 45);
            this.UI_trackbar.TabIndex = 0;
            this.UI_trackbar.TickFrequency = 100;
            this.UI_trackbar.Value = 100;
            // 
            // UI_generatebutton
            // 
            this.UI_generatebutton.Location = new System.Drawing.Point(57, 209);
            this.UI_generatebutton.Name = "UI_generatebutton";
            this.UI_generatebutton.Size = new System.Drawing.Size(75, 23);
            this.UI_generatebutton.TabIndex = 1;
            this.UI_generatebutton.Text = "Generate";
            this.UI_generatebutton.UseVisualStyleBackColor = true;
            this.UI_generatebutton.Click += new System.EventHandler(this.UI_generatebutton_Click);
            // 
            // UI_fill_color
            // 
            this.UI_fill_color.Location = new System.Drawing.Point(195, 209);
            this.UI_fill_color.Name = "UI_fill_color";
            this.UI_fill_color.Size = new System.Drawing.Size(75, 23);
            this.UI_fill_color.TabIndex = 2;
            this.UI_fill_color.Text = "Fill Color";
            this.UI_fill_color.UseVisualStyleBackColor = true;
            this.UI_fill_color.Click += new System.EventHandler(this.UI_fill_color_Click);
            // 
            // UI_fillcolor
            // 
            this.UI_fillcolor.Location = new System.Drawing.Point(326, 209);
            this.UI_fillcolor.Name = "UI_fillcolor";
            this.UI_fillcolor.Size = new System.Drawing.Size(75, 23);
            this.UI_fillcolor.TabIndex = 3;
            this.UI_fillcolor.Text = "Fill";
            this.UI_fillcolor.UseVisualStyleBackColor = true;
            this.UI_fillcolor.Click += new System.EventHandler(this.UI_fillcolor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of Blocks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fill Color";
            // 
            // UI_colordialog
            // 
            this.UI_colordialog.FullOpen = true;
            // 
            // UI_picturebox
            // 
            this.UI_picturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UI_picturebox.Location = new System.Drawing.Point(207, 145);
            this.UI_picturebox.Name = "UI_picturebox";
            this.UI_picturebox.Size = new System.Drawing.Size(54, 36);
            this.UI_picturebox.TabIndex = 6;
            this.UI_picturebox.TabStop = false;
            // 
            // UI_100
            // 
            this.UI_100.AutoSize = true;
            this.UI_100.Location = new System.Drawing.Point(40, 105);
            this.UI_100.Name = "UI_100";
            this.UI_100.Size = new System.Drawing.Size(25, 13);
            this.UI_100.TabIndex = 7;
            this.UI_100.Text = "100";
            // 
            // UI_3000
            // 
            this.UI_3000.AutoSize = true;
            this.UI_3000.Location = new System.Drawing.Point(420, 105);
            this.UI_3000.Name = "UI_3000";
            this.UI_3000.Size = new System.Drawing.Size(31, 13);
            this.UI_3000.TabIndex = 8;
            this.UI_3000.Text = "3000";
            // 
            // UI_timer
            // 
            this.UI_timer.Tick += new System.EventHandler(this.UI_timer_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 261);
            this.Controls.Add(this.UI_3000);
            this.Controls.Add(this.UI_100);
            this.Controls.Add(this.UI_picturebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_fillcolor);
            this.Controls.Add(this.UI_fill_color);
            this.Controls.Add(this.UI_generatebutton);
            this.Controls.Add(this.UI_trackbar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UI_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar UI_trackbar;
        private System.Windows.Forms.Button UI_generatebutton;
        private System.Windows.Forms.Button UI_fill_color;
        private System.Windows.Forms.Button UI_fillcolor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog UI_colordialog;
        private System.Windows.Forms.PictureBox UI_picturebox;
        private System.Windows.Forms.Label UI_100;
        private System.Windows.Forms.Label UI_3000;
        private System.Windows.Forms.Timer UI_timer;
    }
}

