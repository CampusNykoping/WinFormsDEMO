﻿namespace WinFormsApp
{
    partial class MinKalkylator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbTal1 = new System.Windows.Forms.TextBox();
            this.tbTal2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbTal1
            // 
            this.tbTal1.Location = new System.Drawing.Point(186, 48);
            this.tbTal1.Name = "tbTal1";
            this.tbTal1.Size = new System.Drawing.Size(125, 27);
            this.tbTal1.TabIndex = 0;
            // 
            // tbTal2
            // 
            this.tbTal2.Location = new System.Drawing.Point(186, 108);
            this.tbTal2.Name = "tbTal2";
            this.tbTal2.Size = new System.Drawing.Size(125, 27);
            this.tbTal2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Addera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tal 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tal 2";
            // 
            // MinKalkylator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 266);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbTal2);
            this.Controls.Add(this.tbTal1);
            this.Name = "MinKalkylator";
            this.Text = "Min kalkylator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbTal1;
        private TextBox tbTal2;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}