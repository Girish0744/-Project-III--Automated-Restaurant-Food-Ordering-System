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
    public partial class TableA2 : Form
    {
        Order tableOrder = new Order("TableA2");
        public TableA2()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
             
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
        }


        // Function to set the visibility of a box in the TableLayoutPanel
        private void SetBoxVisibility(int row, int column, bool isVisible)
        {
            Control box = tableLayoutPanel2.GetControlFromPosition(column, row);

            if (box != null)
            {
                box.Visible = isVisible;
            }
        }

        private void ExampleUsage()
        {
            SetBoxVisibility(0, 1, true);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button2_Click(object sender, EventArgs e) // back button
        {
            Waiter_s_View Waiter = new Waiter_s_View();
            Waiter.Show();
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
    }
}


