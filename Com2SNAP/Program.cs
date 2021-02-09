using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ASCOM.com2snap
{
    static class Program
    {
        /// Main 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
