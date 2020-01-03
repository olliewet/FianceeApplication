﻿namespace fianceeapp
{
    partial class Monthly
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
            this.Cal_Button = new System.Windows.Forms.Button();
            this.me_lab = new System.Windows.Forms.Label();
            this.result_lab = new System.Windows.Forms.Label();
            this.Earnings_TB = new System.Windows.Forms.TextBox();
            this.result_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wp_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.welcome_lb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.month_lb = new System.Windows.Forms.ListBox();
            this.reset_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cal_Button
            // 
            this.Cal_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cal_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cal_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cal_Button.Location = new System.Drawing.Point(254, 325);
            this.Cal_Button.Name = "Cal_Button";
            this.Cal_Button.Size = new System.Drawing.Size(267, 25);
            this.Cal_Button.TabIndex = 0;
            this.Cal_Button.Text = "Calculate";
            this.Cal_Button.UseVisualStyleBackColor = false;
            this.Cal_Button.Click += new System.EventHandler(this.Cal_Button_Click);
            // 
            // me_lab
            // 
            this.me_lab.AutoSize = true;
            this.me_lab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.me_lab.Location = new System.Drawing.Point(145, 88);
            this.me_lab.Name = "me_lab";
            this.me_lab.Size = new System.Drawing.Size(100, 13);
            this.me_lab.TabIndex = 1;
            this.me_lab.Text = "Monthly Earnings";
            // 
            // result_lab
            // 
            this.result_lab.AutoSize = true;
            this.result_lab.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.result_lab.Location = new System.Drawing.Point(160, 270);
            this.result_lab.Name = "result_lab";
            this.result_lab.Size = new System.Drawing.Size(86, 13);
            this.result_lab.TabIndex = 2;
            this.result_lab.Text = "Daily Spending";
            // 
            // Earnings_TB
            // 
            this.Earnings_TB.BackColor = System.Drawing.Color.White;
            this.Earnings_TB.Location = new System.Drawing.Point(254, 88);
            this.Earnings_TB.Name = "Earnings_TB";
            this.Earnings_TB.Size = new System.Drawing.Size(266, 22);
            this.Earnings_TB.TabIndex = 3;
            // 
            // result_TB
            // 
            this.result_TB.Location = new System.Drawing.Point(254, 267);
            this.result_TB.Name = "result_TB";
            this.result_TB.Size = new System.Drawing.Size(266, 22);
            this.result_TB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(208, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Month";
            // 
            // wp_TB
            // 
            this.wp_TB.Location = new System.Drawing.Point(254, 299);
            this.wp_TB.Name = "wp_TB";
            this.wp_TB.Size = new System.Drawing.Size(266, 22);
            this.wp_TB.TabIndex = 7;
            this.wp_TB.TextChanged += new System.EventHandler(this.Wp_TB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(145, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Weekly Spending";
            // 
            // welcome_lb
            // 
            this.welcome_lb.AutoSize = true;
            this.welcome_lb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.welcome_lb.Location = new System.Drawing.Point(204, 44);
            this.welcome_lb.Name = "welcome_lb";
            this.welcome_lb.Size = new System.Drawing.Size(297, 13);
            this.welcome_lb.TabIndex = 9;
            this.welcome_lb.Text = "Welcome to the Daily and Weekly Spending Calculator !";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(145, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(409, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Please Enter your monthly earnings for a certain month below in the text box";
            // 
            // month_lb
            // 
            this.month_lb.FormattingEnabled = true;
            this.month_lb.Location = new System.Drawing.Point(254, 114);
            this.month_lb.Name = "month_lb";
            this.month_lb.Size = new System.Drawing.Size(266, 147);
            this.month_lb.TabIndex = 11;
            this.month_lb.SelectedIndexChanged += new System.EventHandler(this.Month_lb_SelectedIndexChanged);
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(343, 356);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.reset_btn.Size = new System.Drawing.Size(87, 23);
            this.reset_btn.TabIndex = 12;
            this.reset_btn.Text = "Reset ";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::fianceeapp.Properties.Resources.home_26px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(5, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit_btn.Image = global::fianceeapp.Properties.Resources.exit_26px;
            this.exit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit_btn.Location = new System.Drawing.Point(3, 88);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(119, 39);
            this.exit_btn.TabIndex = 13;
            this.exit_btn.Text = "Exit ";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 383);
            this.panel1.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::fianceeapp.Properties.Resources.save_32px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 39);
            this.button2.TabIndex = 15;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Monthly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(588, 383);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.month_lb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.welcome_lb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wp_TB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result_TB);
            this.Controls.Add(this.Earnings_TB);
            this.Controls.Add(this.result_lab);
            this.Controls.Add(this.me_lab);
            this.Controls.Add(this.Cal_Button);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Monthly";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Monthly_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cal_Button;
        private System.Windows.Forms.Label me_lab;
        private System.Windows.Forms.Label result_lab;
        private System.Windows.Forms.TextBox Earnings_TB;
        private System.Windows.Forms.TextBox result_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox wp_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label welcome_lb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox month_lb;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}