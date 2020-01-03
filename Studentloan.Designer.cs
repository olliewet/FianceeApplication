namespace fianceeapp
{
    partial class Studentloan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yearly_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.term_tb = new System.Windows.Forms.TextBox();
            this.month_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.weekly_tb = new System.Windows.Forms.TextBox();
            this.cal_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ext_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(296, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Student Loan Page!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(144, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(503, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "This calculator can be used to work out much your student loan will last you duri" +
    "ng your year at university ";
            // 
            // yearly_tb
            // 
            this.yearly_tb.Location = new System.Drawing.Point(299, 94);
            this.yearly_tb.Name = "yearly_tb";
            this.yearly_tb.Size = new System.Drawing.Size(206, 20);
            this.yearly_tb.TabIndex = 2;
            this.yearly_tb.TextChanged += new System.EventHandler(this.Yearly_tb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(152, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Student loan yearly amount :";
            // 
            // term_tb
            // 
            this.term_tb.Location = new System.Drawing.Point(299, 121);
            this.term_tb.Name = "term_tb";
            this.term_tb.Size = new System.Drawing.Size(206, 20);
            this.term_tb.TabIndex = 4;
            // 
            // month_tb
            // 
            this.month_tb.Location = new System.Drawing.Point(299, 148);
            this.month_tb.Name = "month_tb";
            this.month_tb.Size = new System.Drawing.Size(206, 20);
            this.month_tb.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(161, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Average amount per term :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(195, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Monthly Spending :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(195, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Weekly Spending : ";
            // 
            // weekly_tb
            // 
            this.weekly_tb.Location = new System.Drawing.Point(299, 179);
            this.weekly_tb.Name = "weekly_tb";
            this.weekly_tb.Size = new System.Drawing.Size(206, 20);
            this.weekly_tb.TabIndex = 9;
            // 
            // cal_btn
            // 
            this.cal_btn.Location = new System.Drawing.Point(299, 205);
            this.cal_btn.Name = "cal_btn";
            this.cal_btn.Size = new System.Drawing.Size(206, 23);
            this.cal_btn.TabIndex = 10;
            this.cal_btn.Text = "Calculate";
            this.cal_btn.UseVisualStyleBackColor = true;
            this.cal_btn.Click += new System.EventHandler(this.Cal_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reset_btn.Location = new System.Drawing.Point(366, 234);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(75, 23);
            this.reset_btn.TabIndex = 11;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.Save);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ext_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 311);
            this.panel1.TabIndex = 14;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Transparent;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Save.Image = global::fianceeapp.Properties.Resources.save_32px;
            this.Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save.Location = new System.Drawing.Point(12, 87);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(123, 23);
            this.Save.TabIndex = 15;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::fianceeapp.Properties.Resources.home_26px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(15, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ext_btn
            // 
            this.ext_btn.FlatAppearance.BorderSize = 0;
            this.ext_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ext_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ext_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ext_btn.Image = global::fianceeapp.Properties.Resources.exit_26px;
            this.ext_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ext_btn.Location = new System.Drawing.Point(15, 121);
            this.ext_btn.Name = "ext_btn";
            this.ext_btn.Size = new System.Drawing.Size(120, 32);
            this.ext_btn.TabIndex = 12;
            this.ext_btn.Text = "Exit";
            this.ext_btn.UseVisualStyleBackColor = true;
            this.ext_btn.Click += new System.EventHandler(this.Ext_btn_Click);
            // 
            // Studentloan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(650, 311);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.cal_btn);
            this.Controls.Add(this.weekly_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.month_tb);
            this.Controls.Add(this.term_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yearly_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Studentloan";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Studentloan_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yearly_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox term_tb;
        private System.Windows.Forms.TextBox month_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox weekly_tb;
        private System.Windows.Forms.Button cal_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button ext_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Save;
    }
}