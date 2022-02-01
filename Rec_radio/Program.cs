using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Rec_radio
{
    static class Program
    {

        public static Form1 OLD;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
