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
 * Date: 08/03/2017
 * Student Number: 300280496
 * Description: Added the Form closing event handler.
 * Version 0.2
 */

namespace COMP123_S2017_Lesson12A2
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// This is the event handler for the form closing event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
