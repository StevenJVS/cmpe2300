namespace Lecture10Exercise9
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
            this.UI_CustID_Label = new System.Windows.Forms.Label();
            this.UI_CustID_txtBox = new System.Windows.Forms.TextBox();
            this.UI_AmtDue_Label = new System.Windows.Forms.Label();
            this.UI_Amount_txtBox = new System.Windows.Forms.TextBox();
            this.UI_AddToFront_btn = new System.Windows.Forms.Button();
            this.UI_AddToRear_btn = new System.Windows.Forms.Button();
            this.UI_DisplaySelectedCust_btn = new System.Windows.Forms.Button();
            this.UI_AllCustInfo_Label = new System.Windows.Forms.Label();
            this.UI_SelectedCustInfo_Label = new System.Windows.Forms.Label();
            this.UI_AllCust_LB = new System.Windows.Forms.ListBox();
            this.UI_SelectedCust_LB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // UI_CustID_Label
            // 
            this.UI_CustID_Label.AutoSize = true;
            this.UI_CustID_Label.Location = new System.Drawing.Point(440, 138);
            this.UI_CustID_Label.Name = "UI_CustID_Label";
            this.UI_CustID_Label.Size = new System.Drawing.Size(186, 32);
            this.UI_CustID_Label.TabIndex = 1;
            this.UI_CustID_Label.Text = "Customer ID: ";
            // 
            // UI_CustID_txtBox
            // 
            this.UI_CustID_txtBox.Location = new System.Drawing.Point(632, 132);
            this.UI_CustID_txtBox.Name = "UI_CustID_txtBox";
            this.UI_CustID_txtBox.Size = new System.Drawing.Size(379, 38);
            this.UI_CustID_txtBox.TabIndex = 2;
            // 
            // UI_AmtDue_Label
            // 
            this.UI_AmtDue_Label.AutoSize = true;
            this.UI_AmtDue_Label.Location = new System.Drawing.Point(439, 237);
            this.UI_AmtDue_Label.Name = "UI_AmtDue_Label";
            this.UI_AmtDue_Label.Size = new System.Drawing.Size(187, 32);
            this.UI_AmtDue_Label.TabIndex = 3;
            this.UI_AmtDue_Label.Text = "Amount Due: ";
            // 
            // UI_Amount_txtBox
            // 
            this.UI_Amount_txtBox.Location = new System.Drawing.Point(633, 231);
            this.UI_Amount_txtBox.Name = "UI_Amount_txtBox";
            this.UI_Amount_txtBox.Size = new System.Drawing.Size(379, 38);
            this.UI_Amount_txtBox.TabIndex = 4;
            // 
            // UI_AddToFront_btn
            // 
            this.UI_AddToFront_btn.Location = new System.Drawing.Point(632, 330);
            this.UI_AddToFront_btn.Name = "UI_AddToFront_btn";
            this.UI_AddToFront_btn.Size = new System.Drawing.Size(319, 78);
            this.UI_AddToFront_btn.TabIndex = 5;
            this.UI_AddToFront_btn.Text = "Add To Front";
            this.UI_AddToFront_btn.UseVisualStyleBackColor = true;
            this.UI_AddToFront_btn.Click += new System.EventHandler(this.UI_AddToFront_btn_Click);
            // 
            // UI_AddToRear_btn
            // 
            this.UI_AddToRear_btn.Location = new System.Drawing.Point(632, 469);
            this.UI_AddToRear_btn.Name = "UI_AddToRear_btn";
            this.UI_AddToRear_btn.Size = new System.Drawing.Size(319, 78);
            this.UI_AddToRear_btn.TabIndex = 6;
            this.UI_AddToRear_btn.Text = "Add To Rear";
            this.UI_AddToRear_btn.UseVisualStyleBackColor = true;
            this.UI_AddToRear_btn.Click += new System.EventHandler(this.UI_AddToRear_btn_Click);
            // 
            // UI_DisplaySelectedCust_btn
            // 
            this.UI_DisplaySelectedCust_btn.Location = new System.Drawing.Point(1195, 633);
            this.UI_DisplaySelectedCust_btn.Name = "UI_DisplaySelectedCust_btn";
            this.UI_DisplaySelectedCust_btn.Size = new System.Drawing.Size(319, 113);
            this.UI_DisplaySelectedCust_btn.TabIndex = 8;
            this.UI_DisplaySelectedCust_btn.Text = "Display Selected Customers";
            this.UI_DisplaySelectedCust_btn.UseVisualStyleBackColor = true;
            this.UI_DisplaySelectedCust_btn.Click += new System.EventHandler(this.UI_DisplaySelectedCust_btn_Click);
            // 
            // UI_AllCustInfo_Label
            // 
            this.UI_AllCustInfo_Label.AutoSize = true;
            this.UI_AllCustInfo_Label.Location = new System.Drawing.Point(92, 58);
            this.UI_AllCustInfo_Label.Name = "UI_AllCustInfo_Label";
            this.UI_AllCustInfo_Label.Size = new System.Drawing.Size(245, 32);
            this.UI_AllCustInfo_Label.TabIndex = 9;
            this.UI_AllCustInfo_Label.Text = "All Customers Info";
            // 
            // UI_SelectedCustInfo_Label
            // 
            this.UI_SelectedCustInfo_Label.AutoSize = true;
            this.UI_SelectedCustInfo_Label.Location = new System.Drawing.Point(1192, 58);
            this.UI_SelectedCustInfo_Label.Name = "UI_SelectedCustInfo_Label";
            this.UI_SelectedCustInfo_Label.Size = new System.Drawing.Size(324, 32);
            this.UI_SelectedCustInfo_Label.TabIndex = 10;
            this.UI_SelectedCustInfo_Label.Text = "Selected Customers Info";
            // 
            // UI_AllCust_LB
            // 
            this.UI_AllCust_LB.FormattingEnabled = true;
            this.UI_AllCust_LB.ItemHeight = 31;
            this.UI_AllCust_LB.Location = new System.Drawing.Point(22, 119);
            this.UI_AllCust_LB.Name = "UI_AllCust_LB";
            this.UI_AllCust_LB.Size = new System.Drawing.Size(384, 469);
            this.UI_AllCust_LB.TabIndex = 11;
            // 
            // UI_SelectedCust_LB
            // 
            this.UI_SelectedCust_LB.FormattingEnabled = true;
            this.UI_SelectedCust_LB.ItemHeight = 31;
            this.UI_SelectedCust_LB.Location = new System.Drawing.Point(1162, 119);
            this.UI_SelectedCust_LB.Name = "UI_SelectedCust_LB";
            this.UI_SelectedCust_LB.Size = new System.Drawing.Size(384, 469);
            this.UI_SelectedCust_LB.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 770);
            this.Controls.Add(this.UI_SelectedCust_LB);
            this.Controls.Add(this.UI_AllCust_LB);
            this.Controls.Add(this.UI_SelectedCustInfo_Label);
            this.Controls.Add(this.UI_AllCustInfo_Label);
            this.Controls.Add(this.UI_DisplaySelectedCust_btn);
            this.Controls.Add(this.UI_AddToRear_btn);
            this.Controls.Add(this.UI_AddToFront_btn);
            this.Controls.Add(this.UI_Amount_txtBox);
            this.Controls.Add(this.UI_AmtDue_Label);
            this.Controls.Add(this.UI_CustID_txtBox);
            this.Controls.Add(this.UI_CustID_Label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label UI_CustID_Label;
        private System.Windows.Forms.TextBox UI_CustID_txtBox;
        private System.Windows.Forms.Label UI_AmtDue_Label;
        private System.Windows.Forms.TextBox UI_Amount_txtBox;
        private System.Windows.Forms.Button UI_AddToFront_btn;
        private System.Windows.Forms.Button UI_AddToRear_btn;
        private System.Windows.Forms.Button UI_DisplaySelectedCust_btn;
        private System.Windows.Forms.Label UI_AllCustInfo_Label;
        private System.Windows.Forms.Label UI_SelectedCustInfo_Label;
        private System.Windows.Forms.ListBox UI_AllCust_LB;
        private System.Windows.Forms.ListBox UI_SelectedCust_LB;
    }
}

