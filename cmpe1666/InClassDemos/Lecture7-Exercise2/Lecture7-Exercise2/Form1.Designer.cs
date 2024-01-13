namespace Lecture7_Exercise2
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
            this.Ui_ChooseFont_Btn = new System.Windows.Forms.Button();
            this.UI_ChooseColor_Btn = new System.Windows.Forms.Button();
            this.UI_Display_Lbl = new System.Windows.Forms.Label();
            this.UI_Font_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Color_Tbx = new System.Windows.Forms.TextBox();
            this.UI_TextFont_Lbl = new System.Windows.Forms.Label();
            this.UI_TextColor_Lbl = new System.Windows.Forms.Label();
            this.UI_TextFont_Dlg = new System.Windows.Forms.FontDialog();
            this.UI_TextColor_Dlg = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // Ui_ChooseFont_Btn
            // 
            this.Ui_ChooseFont_Btn.Location = new System.Drawing.Point(149, 90);
            this.Ui_ChooseFont_Btn.Name = "Ui_ChooseFont_Btn";
            this.Ui_ChooseFont_Btn.Size = new System.Drawing.Size(144, 42);
            this.Ui_ChooseFont_Btn.TabIndex = 0;
            this.Ui_ChooseFont_Btn.Text = "Choose Font";
            this.Ui_ChooseFont_Btn.UseVisualStyleBackColor = true;
            this.Ui_ChooseFont_Btn.Click += new System.EventHandler(this.Ui_ChooseFont_Btn_Click);
            // 
            // UI_ChooseColor_Btn
            // 
            this.UI_ChooseColor_Btn.Location = new System.Drawing.Point(347, 93);
            this.UI_ChooseColor_Btn.Name = "UI_ChooseColor_Btn";
            this.UI_ChooseColor_Btn.Size = new System.Drawing.Size(141, 36);
            this.UI_ChooseColor_Btn.TabIndex = 1;
            this.UI_ChooseColor_Btn.Text = "Choose Color";
            this.UI_ChooseColor_Btn.UseVisualStyleBackColor = true;
            this.UI_ChooseColor_Btn.Click += new System.EventHandler(this.UI_ChooseColor_Btn_Click);
            // 
            // UI_Display_Lbl
            // 
            this.UI_Display_Lbl.AutoSize = true;
            this.UI_Display_Lbl.Location = new System.Drawing.Point(146, 186);
            this.UI_Display_Lbl.Name = "UI_Display_Lbl";
            this.UI_Display_Lbl.Size = new System.Drawing.Size(84, 13);
            this.UI_Display_Lbl.TabIndex = 2;
            this.UI_Display_Lbl.Text = "This is the Label";
            // 
            // UI_Font_Tbx
            // 
            this.UI_Font_Tbx.Location = new System.Drawing.Point(211, 236);
            this.UI_Font_Tbx.Name = "UI_Font_Tbx";
            this.UI_Font_Tbx.Size = new System.Drawing.Size(337, 20);
            this.UI_Font_Tbx.TabIndex = 3;
            // 
            // UI_Color_Tbx
            // 
            this.UI_Color_Tbx.Location = new System.Drawing.Point(211, 275);
            this.UI_Color_Tbx.Name = "UI_Color_Tbx";
            this.UI_Color_Tbx.Size = new System.Drawing.Size(337, 20);
            this.UI_Color_Tbx.TabIndex = 4;
            // 
            // UI_TextFont_Lbl
            // 
            this.UI_TextFont_Lbl.AutoSize = true;
            this.UI_TextFont_Lbl.Location = new System.Drawing.Point(134, 236);
            this.UI_TextFont_Lbl.Name = "UI_TextFont_Lbl";
            this.UI_TextFont_Lbl.Size = new System.Drawing.Size(52, 13);
            this.UI_TextFont_Lbl.TabIndex = 5;
            this.UI_TextFont_Lbl.Text = "Text Font";
            // 
            // UI_TextColor_Lbl
            // 
            this.UI_TextColor_Lbl.AutoSize = true;
            this.UI_TextColor_Lbl.Location = new System.Drawing.Point(134, 278);
            this.UI_TextColor_Lbl.Name = "UI_TextColor_Lbl";
            this.UI_TextColor_Lbl.Size = new System.Drawing.Size(55, 13);
            this.UI_TextColor_Lbl.TabIndex = 6;
            this.UI_TextColor_Lbl.Text = "Text Color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_TextColor_Lbl);
            this.Controls.Add(this.UI_TextFont_Lbl);
            this.Controls.Add(this.UI_Color_Tbx);
            this.Controls.Add(this.UI_Font_Tbx);
            this.Controls.Add(this.UI_Display_Lbl);
            this.Controls.Add(this.UI_ChooseColor_Btn);
            this.Controls.Add(this.Ui_ChooseFont_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ui_ChooseFont_Btn;
        private System.Windows.Forms.Button UI_ChooseColor_Btn;
        private System.Windows.Forms.Label UI_Display_Lbl;
        private System.Windows.Forms.TextBox UI_Font_Tbx;
        private System.Windows.Forms.TextBox UI_Color_Tbx;
        private System.Windows.Forms.Label UI_TextFont_Lbl;
        private System.Windows.Forms.Label UI_TextColor_Lbl;
        private System.Windows.Forms.FontDialog UI_TextFont_Dlg;
        private System.Windows.Forms.ColorDialog UI_TextColor_Dlg;
    }
}

