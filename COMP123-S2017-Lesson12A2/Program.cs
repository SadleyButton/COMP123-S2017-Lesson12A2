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
 * Description: Refactored Main to instantiate CalculatorForm object after Enabling Visual Styles.
 * Version 0.3
 */

namespace COMP123_S2017_Lesson12A2
{
    public static class Program
    {
        //FORM INSTANTIATION
        public static CalculatorForm calculatorForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            calculatorForm = new CalculatorForm();

            Application.Run(new SplashForm());

        }
    }
}
