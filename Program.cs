using System;
using System.Text;
using System.Windows.Forms;

namespace Eve_Settings_Manager
{
    public static class Program
    {
        public static StringBuilder Logger = new StringBuilder();

       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
