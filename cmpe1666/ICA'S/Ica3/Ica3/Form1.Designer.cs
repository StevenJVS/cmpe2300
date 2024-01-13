namespace Ica3
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
            this.UI_label = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.UI_start = new System.Windows.Forms.Button();
            this.UI_stop = new System.Windows.Forms.Button();
            this.UI_Reset = new System.Windows.Forms.Button();
            this.UI_split = new System.Windows.Forms.Button();
            this.UI_timer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.UI_label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_label
            // 
            this.UI_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_label.AutoSize = true;
            this.UI_label.Location = new System.Drawing.Point(254, 15);
            this.UI_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UI_label.Name = "UI_label";
            this.UI_label.Size = new System.Drawing.Size(0, 13);
            this.UI_label.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.Location = new System.Drawing.Point(5, 67);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(196, 264);
            this.listBox1.TabIndex = 4;
            // 
            // UI_start
            // 
            this.UI_start.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UI_start.Location = new System.Drawing.Point(205, 67);
            this.UI_start.Margin = new System.Windows.Forms.Padding(2);
            this.UI_start.Name = "UI_start";
            this.UI_start.Size = new System.Drawing.Size(56, 19);
            this.UI_start.TabIndex = 0;
            this.UI_start.Text = "Start";
            this.UI_start.UseVisualStyleBackColor = true;
            this.UI_start.Click += new System.EventHandler(this.UI_start_Click);
            // 
            // UI_stop
            // 
            this.UI_stop.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UI_stop.Location = new System.Drawing.Point(205, 91);
            this.UI_stop.Margin = new System.Windows.Forms.Padding(2);
            this.UI_stop.Name = "UI_stop";
            this.UI_stop.Size = new System.Drawing.Size(56, 19);
            this.UI_stop.TabIndex = 2;
            this.UI_stop.Text = "Stop";
            this.UI_stop.UseVisualStyleBackColor = true;
            this.UI_stop.Click += new System.EventHandler(this.UI_stop_Click);
            // 
            // UI_Reset
            // 
            this.UI_Reset.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UI_Reset.Location = new System.Drawing.Point(205, 114);
            this.UI_Reset.Margin = new System.Windows.Forms.Padding(2);
            this.UI_Reset.Name = "UI_Reset";
            this.UI_Reset.Size = new System.Drawing.Size(56, 19);
            this.UI_Reset.TabIndex = 3;
            this.UI_Reset.Text = "Reset";
            this.UI_Reset.UseVisualStyleBackColor = true;
            this.UI_Reset.Click += new System.EventHandler(this.UI_Reset_Click);
            // 
            // UI_split
            // 
            this.UI_split.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_split.Location = new System.Drawing.Point(205, 312);
            this.UI_split.Margin = new System.Windows.Forms.Padding(2);
            this.UI_split.Name = "UI_split";
            this.UI_split.Size = new System.Drawing.Size(56, 19);
            this.UI_split.TabIndex = 1;
            this.UI_split.Text = "Split";
            this.UI_split.UseVisualStyleBackColor = true;
            this.UI_split.Click += new System.EventHandler(this.UI_split_Click);
            // 
            // UI_timer
            // 
            this.UI_timer.Enabled = true;
            this.UI_timer.Interval = 20;
            this.UI_timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UI_label1
            // 
            this.UI_label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UI_label1.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_label1.Location = new System.Drawing.Point(5, 9);
            this.UI_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UI_label1.Name = "UI_label1";
            this.UI_label1.Size = new System.Drawing.Size(256, 52);
            this.UI_label1.TabIndex = 6;
            this.UI_label1.Text = "00:00:00:00";
            this.UI_label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 341);
            this.Controls.Add(this.UI_label1);
            this.Controls.Add(this.UI_split);
            this.Controls.Add(this.UI_Reset);
            this.Controls.Add(this.UI_stop);
            this.Controls.Add(this.UI_start);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.UI_label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(280, 380);
            this.Name = "Form1";
            this.Text = "1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_label;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button UI_start;
        private System.Windows.Forms.Button UI_stop;
        private System.Windows.Forms.Button UI_Reset;
        private System.Windows.Forms.Button UI_split;
        private System.Windows.Forms.Timer UI_timer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label UI_label1;
    }
}

