using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace _Project_III_GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginPage());
            // Application.Run(new LoginPage()); 
            //Application.Run(new Waiter_s_View());
            //Application.Run(new TableA1ChefView());
            //Application.Run(new TableA1());
            // Application.Run(new TableA2());
            //Application.Run(new OrderCart());
            // Billing system

            TableA1 tableA1 = new TableA1("TableA1");
            TableA1ChefView TableA1chefView = new TableA1ChefView("TableA1");
            Waiter_s_View Waiter_s_View = new Waiter_s_View();
            Chef_s_View Chef_s_View = new Chef_s_View();

        }
    }
}
