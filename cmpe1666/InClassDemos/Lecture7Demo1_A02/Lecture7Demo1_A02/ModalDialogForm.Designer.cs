namespace Lecture7Demo1_A02
{
    partial class ModalDialogForm
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
            this.UI_OK_Btn = new System.Windows.Forms.Button();
            this.UI_Cancel_Btn = new System.Windows.Forms.Button();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_OK_Btn
            // 
            this.UI_OK_Btn.Location = new System.Drawing.Point(105, 192);
            this.UI_OK_Btn.Name = "UI_OK_Btn";
            this.UI_OK_Btn.Size = new System.Drawing.Size(93, 50);
            this.UI_OK_Btn.TabIndex = 0;
            this.UI_OK_Btn.Text = "OK";
            this.UI_OK_Btn.UseVisualStyleBackColor = true;
            this.UI_OK_Btn.Click += new System.EventHandler(this.UI_OK_Btn_Click);
            // 
            // UI_Cancel_Btn
            // 
            this.UI_Cancel_Btn.Location = new System.Drawing.Point(382, 192);
            this.UI_Cancel_Btn.Name = "UI_Cancel_Btn";
            this.UI_Cancel_Btn.Size = new System.Drawing.Size(93, 50);
            this.UI_Cancel_Btn.TabIndex = 1;
            this.UI_Cancel_Btn.Text = "Cancel";
            this.UI_Cancel_Btn.UseVisualStyleBackColor = true;
            this.UI_Cancel_Btn.Click += new System.EventHandler(this.UI_Cancel_Btn_Click);
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(203, 85);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(214, 20);
            this.tbxInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name: ";
            // 
            // ModalDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 313);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.UI_Cancel_Btn);
            this.Controls.Add(this.UI_OK_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModalDialogForm";
            this.Text = "ModalDialogForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_OK_Btn;
        private System.Windows.Forms.Button UI_Cancel_Btn;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Label label1;
    }
}