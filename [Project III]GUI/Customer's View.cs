using _Project_III_GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Project_III_GUI
{
    public partial class Customer_s_View : Form
    {
        public Customer_s_View()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e) // back button
        {
            LoginPage Home = new LoginPage();
            Home.Show();
            Visible = false;
        }

        private void guna2Button3_Click(object sender, EventArgs e) // home button
        {
            DialogResult iOpen;
            iOpen = MessageBox.Show("You want to go back to the login page?", "Ordering System", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (iOpen == DialogResult.Yes)
            {
                LoginPage Home = new LoginPage();
                Home.Show();
                Visible = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Mainmenu Mainmenu = new Mainmenu("TableA1");
            Mainmenu.Show();
            Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Mainmenu Mainmenu = new Mainmenu("TableA2");
            Mainmenu.Show();
            Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Mainmenu Mainmenu = new Mainmenu("TableA3");
            Mainmenu.Show();
            Visible = false;
        }
        private void label5_Click(object sender, EventArgs e)
        {
            Mainmenu Mainmenu = new Mainmenu("TableA4");
            Mainmenu.Show();
            Visible = false;
        }
        private void label6_Click(object sender, EventArgs e)
        {
            Mainmenu Mainmenu = new Mainmenu("TableB1");
            Mainmenu.Show();
            Visible = false;
        }
        private void label7_Click(object sender, EventArgs e)
        {
            Mainmenu Mainmenu = new Mainmenu("TableC1");
            Mainmenu.Show();
            Visible = false;
        }
        private void label8_Click(object sender, EventArgs e)
        {
            Mainmenu Mainmenu = new Mainmenu("TableA5");
            Mainmenu.Show();
            Visible = false;
        }
        private void label9_Click(object sender, EventArgs e)
        {
            Mainmenu Mainmenu = new Mainmenu("TableB2");
            Mainmenu.Show();
            Visible = false;
        }
        private void label10_Click(object sender, EventArgs e)
        {
            Mainmenu Mainmenu = new Mainmenu("TableC2");
            Mainmenu.Show();
            Visible = false;
        }
        private void label11_Click(object sender, EventArgs e)
        {
            Mainmenu Mainmenu = new Mainmenu("TableA6");
            Mainmenu.Show();
            Visible = false;
        }
        private void label12_Click(object sender, EventArgs e)
        {
            Mainmenu Mainmenu = new Mainmenu("TableB3");
            Mainmenu.Show();
            Visible = false;
        }
        private void label13_Click(object sender, EventArgs e)
        {
            Mainmenu Mainmenu = new Mainmenu("TableC3");
            Mainmenu.Show();
            Visible = false;
        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }
    }
}
