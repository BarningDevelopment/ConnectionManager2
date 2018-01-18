using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleWifi;
using SimpleWifi.Win32;
using System;
using System.Collections.Generic;

using System.ComponentModel;
using System.Linq;
using System.Text;

using System.Threading;
using System.Threading.Tasks;



namespace ConnectionManager2
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
            Application.Run(new welcome());
        }
    }
}
