namespace fianceeapp
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tips_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Month_Page = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.tips_button);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Month_Page);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 55);
            this.panel1.TabIndex = 1;
            // 
            // tips_button
            // 
            this.tips_button.FlatAppearance.BorderSize = 0;
            this.tips_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tips_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tips_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tips_button.Image = global::fianceeapp.Properties.Resources.info_50px;
            this.tips_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tips_button.Location = new System.Drawing.Point(441, 4);
            this.tips_button.Name = "tips_button";
            this.tips_button.Size = new System.Drawing.Size(153, 49);
            this.tips_button.TabIndex = 4;
            this.tips_button.Text = "Tips";
            this.tips_button.UseVisualStyleBackColor = true;
            this.tips_button.Click += new System.EventHandler(this.Tips_button_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::fianceeapp.Properties.Resources.exit_26px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(676, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Month_Page
            // 
            this.Month_Page.FlatAppearance.BorderSize = 0;
            this.Month_Page.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Month_Page.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Month_Page.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Month_Page.Image = global::fianceeapp.Properties.Resources.money;
            this.Month_Page.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Month_Page.Location = new System.Drawing.Point(206, 12);
            this.Month_Page.Name = "Month_Page";
            this.Month_Page.Size = new System.Drawing.Size(288, 37);
            this.Month_Page.TabIndex = 0;
            this.Month_Page.Text = "Money Saving Calculator ";
            this.Month_Page.UseVisualStyleBackColor = true;
            this.Month_Page.Click += new System.EventHandler(this.Month_Page_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = global::fianceeapp.Properties.Resources.student;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Student Loan Calculator ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(821, 406);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "v";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Month_Page;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button tips_button;
    }
}

