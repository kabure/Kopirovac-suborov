using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kopirovac_suborov
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static OknoMain oknoMain;
        public static OknoOPrograme okno; 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new OknoMain());
            //Application.Run(new OknoOPrograme());
            oknoMain = new OknoMain();
             Application.Run(oknoMain);
            
        }
    }
}
