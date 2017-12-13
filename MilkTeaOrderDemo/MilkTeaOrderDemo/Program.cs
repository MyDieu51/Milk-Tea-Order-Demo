using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaOrderDemo
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
            DialogResult result;
            using (var loginform = new LoginForm())
                result = loginform.ShowDialog();
            if (result == DialogResult.OK)
                Application.Run(new MainForm());
        }
    }
}
