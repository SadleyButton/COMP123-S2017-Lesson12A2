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
 * Description: SplashForm for the Calculator application
 * Version 0.1
 */

namespace COMP123_S2017_Lesson12A2
{
    public partial class SplashForm : Form
    {
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
            CalculatorForm calulateForm = new CalculatorForm();
            calulateForm.Show();
            this.Hide();
            calulateForm.Enabled = false;
        }
    }
}
