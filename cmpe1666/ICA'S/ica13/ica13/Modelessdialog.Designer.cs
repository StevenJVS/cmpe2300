namespace ica13
{
    partial class Modelessdialog
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
            this.Ui_red = new System.Windows.Forms.TrackBar();
            this.UI_green = new System.Windows.Forms.TrackBar();
            this.Ui_blue = new System.Windows.Forms.TrackBar();
            this.UI_opacity = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ui_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ui_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_opacity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ui_red
            // 
            this.Ui_red.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Ui_red.Location = new System.Drawing.Point(6, 19);
            this.Ui_red.Maximum = 255;
            this.Ui_red.Name = "Ui_red";
            this.Ui_red.Size = new System.Drawing.Size(770, 45);
            this.Ui_red.TabIndex = 0;
            this.Ui_red.TickFrequency = 5;
            this.Ui_red.Scroll += new System.EventHandler(this.UI_track);
            // 
            // UI_green
            // 
            this.UI_green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UI_green.Location = new System.Drawing.Point(6, 85);
            this.UI_green.Maximum = 255;
            this.UI_green.Name = "UI_green";
            this.UI_green.Size = new System.Drawing.Size(770, 45);
            this.UI_green.TabIndex = 1;
            this.UI_green.TickFrequency = 5;
            this.UI_green.Scroll += new System.EventHandler(this.UI_track);
            // 
            // Ui_blue
            // 
            this.Ui_blue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Ui_blue.Location = new System.Drawing.Point(6, 154);
            this.Ui_blue.Maximum = 255;
            this.Ui_blue.Name = "Ui_blue";
            this.Ui_blue.Size = new System.Drawing.Size(770, 45);
            this.Ui_blue.TabIndex = 2;
            this.Ui_blue.TickFrequency = 5;
            this.Ui_blue.Scroll += new System.EventHandler(this.UI_track);
            // 
            // UI_opacity
            // 
            this.UI_opacity.Location = new System.Drawing.Point(6, 19);
            this.UI_opacity.Maximum = 100;
            this.UI_opacity.Name = "UI_opacity";
            this.UI_opacity.Size = new System.Drawing.Size(781, 45);
            this.UI_opacity.TabIndex = 3;
            this.UI_opacity.TickFrequency = 5;
            this.UI_opacity.Scroll += new System.EventHandler(this.UI_opacity_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Ui_red);
            this.groupBox1.Controls.Add(this.UI_green);
            this.groupBox1.Controls.Add(this.Ui_blue);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 219);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colour";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UI_opacity);
            this.groupBox2.Location = new System.Drawing.Point(12, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(787, 74);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opacity";
            // 
            // Modelessdialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 351);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Modelessdialog";
            this.Text = "Modelessdialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Modelessdialog_FormClosing);
            this.Load += new System.EventHandler(this.Modelessdialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ui_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ui_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_opacity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar Ui_red;
        private System.Windows.Forms.TrackBar UI_green;
        private System.Windows.Forms.TrackBar Ui_blue;
        private System.Windows.Forms.TrackBar UI_opacity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}