using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string showString;               // stores the string that's displayed
        public decimal displayValue;            // stores the decimal value that's used to 
        private bool newNum;                    // used to indicate if a new value was entered
        private bool isDecimalSelected;         // used to indicate if a decimal period was used

        private Calculator cal = new Calculator();      // create an instance of the Calculator class

        // clears the text box of data
        private void btnClear_Click(object sender, EventArgs e)
        {
            cal.Clear();                        // calls the clear method in the Calculator class
            showString = "";
            displayValue = 0;
            txtResult.Text = displayValue.ToString();
            newNum = true;
            isDecimalSelected = false;
        }

        // captures the numbers the user clicks on
        private void btn_Click(object sender, EventArgs e)
        {
            
            Button num = (Button)sender;        // creates an object of the button
            
            if (newNum)
            {
                showString = "";
                newNum = false;
            }

            showString += num.Text;          // adds the number to string variable displayString
            displayValue = Convert.ToDecimal(showString);
            txtResult.Text = displayValue.ToString();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            /**
             * Test to see if user enters an appropiate calculation.
             * If the user tries to divide any number by zero, the catch statement
             * will have the text box display an error message. 
             */ 
            try
            {
                if (newNum)
                    cal.Equals();
                else
                    cal.Equals(displayValue);
                displayValue = cal.CurrentValue;
                txtResult.Text = displayValue.ToString();
                newNum = true;
                isDecimalSelected = false;
            }
            catch (DivideByZeroException)
            {
                displayValue = 0;
                txtResult.Text = "Error";
                newNum = true;
                isDecimalSelected = false;
            }
        }

        // removes the last number entered into the textbox
        private void btnBack_Click(object sender, EventArgs e)
        {
            //
            if (showString.Length > 1)
            {
                showString = showString.Substring(0, showString.Length - 1);
                displayValue = Convert.ToDecimal(showString);
                txtResult.Text = displayValue.ToString();
            }
            else
            {
                showString = "";
                displayValue = 0;
                txtResult.Text = displayValue.ToString();
            }

        }

        // gets the square root of the number in the textbox
        private void btnSquare_Click(object sender, EventArgs e)
        {
            Double squareRoot = Double.Parse(txtResult.Text);
            squareRoot = Math.Sqrt(squareRoot);
            txtResult.Text = System.Convert.ToString(squareRoot);
        }

        // gets the reciprocal of the number in the textbox
        private void btn1X_Click(object sender, EventArgs e)
        {
            Double x;
            x = Convert.ToDouble(1.0 / Convert.ToDouble(txtResult.Text));
            txtResult.Text = System.Convert.ToString(x);
        }

        // adds a decimal to the number in the textbox
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (newNum)
            {
                showString = "0";
                newNum = false;
            }
            if (!isDecimalSelected)
            {
                showString += ".";
                displayValue = Convert.ToDecimal(showString);
                txtResult.Text = displayValue.ToString();
                isDecimalSelected = true;
            }
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            cal.Add(displayValue);                      // calls the Add method in the Calculator class
            newNum = true;                            
            isDecimalSelected = false;
            displayValue = cal.CurrentValue;
            txtResult.Text = displayValue.ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            cal.Subtract(displayValue);                 // calls the Subtract method in the Calculator class
            newNum = true;
            isDecimalSelected = false;
            displayValue = cal.CurrentValue;
            txtResult.Text = displayValue.ToString();
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            cal.Multiply(displayValue);                 // calls the Multiply method in the Calculator class
            newNum = true;
            isDecimalSelected = false;
            displayValue = cal.CurrentValue;
            txtResult.Text = displayValue.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            cal.Divide(displayValue);                   // calls the Divide method in the Calculator class
            newNum = true;
            isDecimalSelected = false;
            displayValue = cal.CurrentValue;
            txtResult.Text = displayValue.ToString();
        }

        private void btnPosNeg_Click(object sender, EventArgs e)
        {
            displayValue = -displayValue;               // assigns the displayValue to a negative value
            txtResult.Text = displayValue.ToString();
        }
    }
}
