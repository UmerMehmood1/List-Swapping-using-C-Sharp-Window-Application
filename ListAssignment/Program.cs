using ListAssignment;
using System;
using System.Windows.Forms;

namespace GroceryListApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1();
            form1.Form1_Load();
            Application.Run(form1);
        }
    }
}
