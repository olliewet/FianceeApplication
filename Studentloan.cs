using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fianceeapp
{
    public partial class Studentloan : Form
    {
        public Studentloan()
        {
            InitializeComponent();
            
        }
        float studentloan, monthly, term, weekly;

        //Method sourced from Microsoft website
        private void ResetTextbox(Control control)
        {
            foreach (Control c in control.Controls)
            {
                var box = c as TextBox;
                if (box != null)
                {
                    box.Text = string.Empty;
                }

                this.ResetTextbox(c);
            }
        }
        private void Reset_btn_Click(object sender, EventArgs e)
        {
            this.ResetTextbox(this);
        }

        private void Ext_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home H = new Home();
            H.ShowDialog();
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            //Very unefficent, used for testing          
            StreamWriter sw = new StreamWriter("D:\\test.txt");
            sw.WriteLine("User 1");
            sw.Write(month_tb.Text);
            sw.WriteLine( weekly_tb.Text);            
            sw.Close();
        }

        private void Studentloan_Load(object sender, EventArgs e)
        {

        }

        private void Cal_btn_Click(object sender, EventArgs e)
        {
            try
            {
                studentloan = Convert.ToInt16(yearly_tb.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter a Number!"); 
            }

            try
            {
                term_tb.Text = Convert.ToString(term);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter a Number!");
            }

            try
            {
                month_tb.Text = Convert.ToString(monthly);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter a Number!");
            }

            try
            {
                weekly_tb.Text = Convert.ToString(weekly);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter a Number!");
            }

            term = studentloan / 3;
            monthly = studentloan / 12;
            weekly = studentloan / 52;
                             
        }
       
               
            
    private void Yearly_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
