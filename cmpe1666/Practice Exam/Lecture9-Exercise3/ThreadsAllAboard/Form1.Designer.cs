
namespace Lecture9Exercise3
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
            this.lbFlights = new System.Windows.Forms.ListBox();
            this.btnCommission = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFlights
            // 
            this.lbFlights.FormattingEnabled = true;
            this.lbFlights.Location = new System.Drawing.Point(13, 13);
            this.lbFlights.Name = "lbFlights";
            this.lbFlights.Size = new System.Drawing.Size(324, 407);
            this.lbFlights.TabIndex = 0;
            // 
            // btnCommission
            // 
            this.btnCommission.Location = new System.Drawing.Point(344, 13);
            this.btnCommission.Name = "btnCommission";
            this.btnCommission.Size = new System.Drawing.Size(124, 23);
            this.btnCommission.TabIndex = 1;
            this.btnCommission.Text = "Commission Flights";
            this.btnCommission.UseVisualStyleBackColor = true;
            this.btnCommission.Click += new System.EventHandler(this.btnCommission_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 436);
            this.Controls.Add(this.btnCommission);
            this.Controls.Add(this.lbFlights);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbFlights;
        private System.Windows.Forms.Button btnCommission;
    }
}

