using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;  // ADVANCED DEBUGGING UTILITY
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * Name: Bradley Sutton
 * Date: 08/03/2017
 * Student Number: 300280496
 * Description: This is the Calculator Form using Windows Forms
 * Version 0.4 - Added the private _clear method that resets the calculator
 *             - Refactored the CalculatorButton_Click event
 */

namespace COMP123_S2017_Lesson12A2
{
    public partial class CalculatorForm : Form
    {
        //PRIVATE INSTANCE VARIABLE
        private bool _isDecimalClicked;

        //PUBLIC PROPERTIES
        private bool IsDecimnalClicked
        {
            get
            { return this._isDecimalClicked; }

            set
            { this._isDecimalClicked = IsDecimnalClicked; }
        }


        //CONSTRUCTORS
        public CalculatorForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// This is the event handler for the form closing event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorForm_FormClosing(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is a shared event handler for the Calculator Buttons, not including Operator Buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            //Button buttonClicked = (Button)sender;
            Button buttonClicked = sender as Button; // downcasting

            if ((buttonClicked.Text == ".") && (this.IsDecimnalClicked))
            {
                return;
            }

            if (buttonClicked.Text == ".")
            {
                this.IsDecimnalClicked = true;
            }

            if(ResultTextBox.Text == "0")
            {
                ResultTextBox.Text = buttonClicked.Text;
            }
            else
            {
                ResultTextBox.Text += buttonClicked.Text;
            }

            //Debug.WriteLine("Calculator Button Clicked");  // Debug statement to view the casting from buttons
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button operatorClicked = sender as Button;

            switch (operatorClicked.Text)
            {
                case "C":

                default:
                    break;
            }
        }

        /// <summary>
        /// This is the event handler for the Form's "Load" event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            this.IsDecimnalClicked = false;
        }
        
        private void _clear()
        {
            this.IsDecimnalClicked = false;
            this.ResultTextBox.Clear();
            this.ResultTextBox.Text = "0";
        }
    }
}
