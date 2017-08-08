using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * Name: Bradley Sutton
 * Created: 08/08/2017
 * Student Number: 300280496
 * Description: Refactored the "Tick" event handler
 * Version 0.2
 */

namespace COMP123_S2017_Lesson12A2
{
    public partial class SplashForm : Form
    {
        //PROPERTIES
        public CalculatorForm CalculatorForm
        {
            get { return Program.calculatorForm; }
        }
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the "Tick" event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            this.CalculatorForm.Show();
            this.Hide();
            SplashTimer.Enabled = false;
        }
    }
}
