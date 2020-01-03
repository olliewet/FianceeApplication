namespace fianceeapp
{
    partial class Tips
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
            this.ext_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ext_btn);
            this.panel1.Location = new System.Drawing.Point(3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 347);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // ext_btn
            // 
            this.ext_btn.FlatAppearance.BorderSize = 0;
            this.ext_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ext_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ext_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ext_btn.Image = global::fianceeapp.Properties.Resources.exit_26px;
            this.ext_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ext_btn.Location = new System.Drawing.Point(3, 36);
            this.ext_btn.Name = "ext_btn";
            this.ext_btn.Size = new System.Drawing.Size(111, 32);
            this.ext_btn.TabIndex = 13;
            this.ext_btn.Text = "Exit";
            this.ext_btn.UseVisualStyleBackColor = true;
            this.ext_btn.Click += new System.EventHandler(this.Ext_btn_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::fianceeapp.Properties.Resources.home_26px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 37);
            this.button1.TabIndex = 15;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Tips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(802, 342);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tips";
            this.Text = "Tips";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ext_btn;
        private System.Windows.Forms.Button button1;
    }
}