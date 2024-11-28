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
    
    public partial class Chef_s_View : Form
    {
        
        public Chef_s_View()
        {
            InitializeComponent();
        }

        public void UpdateLabel(string newText)
        {
            label2.Text = newText;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            TableA1ChefView tablea1 = new TableA1ChefView("TableA1");
            tablea1.Show();
            Visible = false;
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

        private void label3_Click(object sender, EventArgs e)
        {
            TableA2ChefView tablea2 = new TableA2ChefView();
            tablea2.Show();
            Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            TableA3ChefView tablea3 = new TableA3ChefView();
            tablea3.Show();
            Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            TableA4ChefView tablea4 = new TableA4ChefView();
            tablea4.Show();
            Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            TableA5ChefView tablea5 = new TableA5ChefView();
            tablea5.Show();
            Visible = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            TableA6ChefView tablea6 = new TableA6ChefView();
            tablea6.Show();
            Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            TableB1ChefView tableb1 = new TableB1ChefView();
            tableb1.Show();
            Visible = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            TableB2ChefView tableb2 = new TableB2ChefView();
            tableb2.Show();
            Visible = false;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            TableB3ChefView tableb3 = new TableB3ChefView();
            tableb3.Show();
            Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            TableC1ChefView tablec1 = new TableC1ChefView();
            tablec1.Show();
            Visible = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            TableC2ChefView tablec2 = new TableC2ChefView();
            tablec2.Show();
            Visible = false;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            TableC3ChefView tablec3 = new TableC3ChefView();
            tablec3.Show();
            Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

