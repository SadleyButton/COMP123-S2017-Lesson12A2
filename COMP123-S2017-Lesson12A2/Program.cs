using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * Name: Bradley Sutton
 * Created: 08/03/2017
 * Modified: August 08, 2017
 * Student Number: 300280496
 * Description: Changed CalculatorForm to Spashform startup
 * Version 0.2 
 */

namespace COMP123_S2017_Lesson12A2
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
            Application.Run(new SplashForm());
        }
    }
}
