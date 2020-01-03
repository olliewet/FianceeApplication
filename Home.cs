using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fianceeapp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Month_Page_Click(object sender, EventArgs e)
        {
            //Button for navigating to Monthly page
            this.Hide();
            //Hides the form 
            Monthly M = new Monthly();
            //Creates a new instance of the monthly form 
            M.ShowDialog();
            //Shows the form of the newly created monthly form
            this.Close();
            //closes current form
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Button for navigating to Monthly page
            this.Hide();
            //Hides the form
            Studentloan S = new Studentloan();
            //Creates a new instance of the student loan form 
            S.ShowDialog();
            //Shows the form of the newly created student loan form
            this.Close();
            //closes current form
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Closes the program
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Tips_button_Click(object sender, EventArgs e)
        {
            //Button for navigating to Monthly page
            this.Hide();
            //Hides the form           
            Tips T = new Tips();
            //Creates a new instance of the monthly form 
            T.ShowDialog();
            //Shows the form of the newly created monthly form
            this.Close();
            //closes current form
        }
    }
}
