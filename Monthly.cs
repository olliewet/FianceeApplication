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
    public partial class Monthly : Form
    {
        public Monthly()
        {
            
            InitializeComponent();

            //Inserts the months into item box as items 
            month_lb.Items.Insert(0, "January");
            month_lb.Items.Insert(1, "February");
            month_lb.Items.Insert(2, "March");
            month_lb.Items.Insert(3, "April");
            month_lb.Items.Insert(4, "May");
            month_lb.Items.Insert(5, "June");
            month_lb.Items.Insert(6, "July");
            month_lb.Items.Insert(7, "August");
            month_lb.Items.Insert(8, "September");
            month_lb.Items.Insert(9, "October");
            month_lb.Items.Insert(10, "November");
            month_lb.Items.Insert(11, "December");

        }

        //Orginally had variables as ints, caused errors 
        float earnings, daily, month;
         

        private void Monthly_Load(object sender, EventArgs e)
        {

        }

        private void Wp_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            this.ResetTextbox(this);
        }

        private void Month_lb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Exit_btn_Click(object sender, EventArgs e)
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

        private void Button2_Click(object sender, EventArgs e)
        {
            //Very unefficent, used for testing          
            StreamWriter sw = new StreamWriter("D:\\test.txt");
            sw.WriteLine("User 1");
            sw.WriteLine(result_TB.Text);
            sw.WriteLine(wp_TB.Text);
            sw.Close();
        }

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
        private void Cal_Button_Click(object sender, EventArgs e)
        {
            try
            {
                earnings = Convert.ToInt16(Earnings_TB.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please Enter a Correct Number!");
            }
      
            if (month_lb.SelectedItem.ToString() == "January")
            {
                month = earnings / 4; 
                daily = earnings / 31;
                wp_TB.Text = month.ToString();
                result_TB.Text = daily.ToString();
            }
            else if (month_lb.SelectedItem.ToString() == "February")
            {
                month = earnings / 4;
                daily = earnings / 28;
                result_TB.Text = daily.ToString();

                wp_TB.Text = month.ToString();
            }
            else if 
            (month_lb.SelectedItem.ToString() == "March")
            {
                month = earnings / 4;
                daily = earnings / 31;
                result_TB.Text = daily.ToString();

                wp_TB.Text = month.ToString();
            }
            else if
            (month_lb.SelectedItem.ToString() == "April")
            {
                month = earnings / 4;
                daily = earnings / 30;
                result_TB.Text = daily.ToString();

                wp_TB.Text = month.ToString();
            }
            else if 
            (month_lb.SelectedItem.ToString() == "May")
            {
                month = earnings / 4;
                daily = earnings / 31;
                result_TB.Text = daily.ToString();

                wp_TB.Text = month.ToString();
            }
            else if
           (month_lb.SelectedItem.ToString() == "June")
            {
                month = earnings / 4;
                daily = earnings / 30;
                result_TB.Text = daily.ToString();

                wp_TB.Text = month.ToString();
            }
            else if
           (month_lb.SelectedItem.ToString() == "July")
            {
                month = earnings / 4;
                daily = earnings / 31;
                result_TB.Text = daily.ToString();

                wp_TB.Text = month.ToString();
            }
            else if
           (month_lb.SelectedItem.ToString() == "August")
            {
                month = earnings / 4;
                daily = earnings / 31;
                result_TB.Text = daily.ToString();

                wp_TB.Text = month.ToString();
            }
            else if
           (month_lb.SelectedItem.ToString() == "September")
            {
                month = earnings / 4;
                daily = earnings / 30;
                result_TB.Text = daily.ToString();

                wp_TB.Text = month.ToString();
            }
            else if
          (month_lb.SelectedItem.ToString() == "October")
            {
                month = earnings / 4;
                daily = earnings / 31;
                result_TB.Text = daily.ToString();

                wp_TB.Text = month.ToString();
            }
            else if
          (month_lb.SelectedItem.ToString() == "November")
            {
                month = earnings / 4;
                daily = earnings / 30;
                result_TB.Text = daily.ToString();

                wp_TB.Text = month.ToString();
            }
            else if
          (month_lb.SelectedItem.ToString() == "December")
            {
                month = earnings / 4;
                daily = earnings / 31;
                result_TB.Text = daily.ToString();

                wp_TB.Text = month.ToString();
            }
            else
            {
                MessageBox.Show("Please Enter A Correct Month!");
            }

        }
    }
}
