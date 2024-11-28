using System;
using System.IO;
using System.Text.Json; // For Json text file
using System.Collections.Generic;
// This using directive allows you to access types in the System.Collections.Generic namespace,
// which includes the List<T> class used later in the code.
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using TheArtOfDevHtmlRenderer.Adapters;


namespace _Project_III_GUI
{
    public partial class Mainmenu : Form
    {
        public string tableOrder;

        public Mainmenu(string table)
        {
            InitializeComponent();

            tableOrder = table;
        }

        private void Mainmenu_Load(object sender, EventArgs e)
        {
            label5.Text = tableOrder;
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            IncrementQuantity(TxtBox1);
        }





        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e) // Price item 1
        {
        }


        private void guna2TextBox2_TextChanged(object sender, EventArgs e) // Description item 1
        {


        }

        private void guna2Button5_Click(object sender, EventArgs e) // Increment 1
        {
            IncrementQuantity(TxtBox2);
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e) // Quantity item 1
        {

        }

        private void ButtonMinus1_Click(object sender, EventArgs e) // Decrement 1
        {
            DecrementQuantity(TxtBox1);
        }

        private int IncrementQuantity(Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            // Get the current value from the GunaTextBox
            int currentValue = int.Parse(textBox.Text);

            // Increment the value
            currentValue++;

            // Update the GunaTextBox with the new value
            textBox.Text = currentValue.ToString();

            return currentValue;
        }

        private int DecrementQuantity(Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            // Get the current value from the GunaTextBox
            int currentValue = int.Parse(textBox.Text);

            // Decrement the value, but ensure it doesn't go below 0
            currentValue = Math.Max(0, currentValue - 1);

            // Update the GunaTextBox with the new value
            textBox.Text = currentValue.ToString();

            return currentValue;
        }

        private string GetDescription(Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            // Get the current value from the GunaTextBox
            string description = textBox.Text;

            // Return the description
            return description;
        }

        private float GetPrice(Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            // Try to parse the current value from the GunaTextBox
            float price;
            bool success = float.TryParse(textBox.Text, out price);

            // If the parse operation was not successful, handle the error
            if (!success)
            {
                // For example, you can set a default price
                price = 0.0f;
                // Or you can show an error message
                Console.WriteLine("Error: The price is not a valid number.");
            }

            // Return the price
            return price;
        }


        private void ButtonMinus2_Click(object sender, EventArgs e)
        {
            DecrementQuantity(TxtBox2);
        }

        private void ButtonPlus3_Click(object sender, EventArgs e)
        {
            IncrementQuantity(TxtBox3);
        }

        private void ButtonMinus3_Click(object sender, EventArgs e)
        {
            DecrementQuantity(TxtBox3);
        }

        private void ButtonPlus4_Click(object sender, EventArgs e)
        {
            IncrementQuantity(TxtBox4);
        }

        private void ButtomMinus4_Click(object sender, EventArgs e)
        {
            DecrementQuantity(TxtBox4);
        }

        private void ButtonPlus5_Click(object sender, EventArgs e)
        {
            IncrementQuantity(TxtBox5);
        }

        private void ButtonMinus5_Click(object sender, EventArgs e)
        {
            DecrementQuantity(TxtBox5);
        }

        private void ButtonPlus6_Click(object sender, EventArgs e)
        {
            IncrementQuantity(TxtBox6);
        }

        private void ButtonMinus6_Click(object sender, EventArgs e)
        {
            DecrementQuantity(TxtBox6);
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            DecrementQuantity(TxtBox7);
        }

        private void ButtonPlus7_Click(object sender, EventArgs e)
        {
            IncrementQuantity(TxtBox7);
        }

        private void ButtonPlus8_Click(object sender, EventArgs e)
        {
            IncrementQuantity(TxtBox8);
        }

        private void ButtonMinus8_Click(object sender, EventArgs e)
        {
            DecrementQuantity(TxtBox8);
        }

        private void TxtBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button18_Click(object sender, EventArgs e) // Send button
        {
            ProcessItem(TxtBox1, guna2TextBox2, guna2TextBox1);
            ProcessItem(TxtBox2, guna2TextBox5, guna2TextBox6);
            ProcessItem(TxtBox3, guna2TextBox8, guna2TextBox9);
            ProcessItem(TxtBox4, guna2TextBox11, guna2TextBox12);
            ProcessItem(TxtBox5, guna2TextBox14, guna2TextBox15);
            ProcessItem(TxtBox6, guna2TextBox17, guna2TextBox18);
            ProcessItem(TxtBox7, guna2TextBox20, guna2TextBox21);
            ProcessItem(TxtBox8, guna2TextBox23, guna2TextBox24);

            DialogResult iOpen;
            iOpen = MessageBox.Show("Your Order has been sent. ", "Ordering System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ProcessItem(Guna.UI2.WinForms.Guna2TextBox quantityTextBox, Guna.UI2.WinForms.Guna2TextBox descriptionTextBox, Guna.UI2.WinForms.Guna2TextBox priceTextBox)
        {
            Order orderFile = new Order(tableOrder);
            int quantity = int.Parse(quantityTextBox.Text);
            if (quantity > 0)
            {
                string description = GetDescription(descriptionTextBox);
                float price = GetPrice(priceTextBox);

                // Now you can use description, price, and quantity
                // For example, you can print them:
                orderFile.AddItem(description, price, quantity);
            }
            orderFile.SaveToFile();
        }

        private void guna2Button2_Click_2(object sender, EventArgs e) // back button
        {

            Customer_s_View Customer = new Customer_s_View();
            Customer.Show();
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

        // Inside the current page class
        private Waiter_s_View Waiter_s_view = new Waiter_s_View();

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Waiter_s_view.UpdateLabel("A1 !");
            Waiter_s_view.Show();
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            DialogResult iOpen;
            iOpen = MessageBox.Show("Request has been sent to the waiter to inform you the status of food... ", "Ordering System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (iOpen == DialogResult.OK)
            {

                Waiter_s_view.UpdateLabel("A1 !");
                Waiter_s_view.Show();
            }
        }

        private void guna2TextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

