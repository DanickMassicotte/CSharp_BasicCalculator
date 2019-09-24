// ------------------------------------------------------------------------------------------------
// FILE NAME:   Form1.cs
// DATE:        2019-09-23
// AUTHOR:      Danick Massicotte
// ------------------------------------------------------------------------------------------------
// CONTEXT:     BasicCalculator
// ------------------------------------------------------------------------------------------------
// DESCRIPTION: A beginner's pretty bad basic calculator. Attempt at beginner-ish C# practice and
//              learning a little bit of Windows Forms. Can only do one operation at the time;
//              will be improved on in another practice exercise... Yeah, probably.
// ------------------------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        private float firstNumber;
        private float secondNumber;
        private char operation;

        public Form1()
        {
            InitializeComponent();
        }

        // There is so much repetition with both the number buttons and operation buttons, there
        // has to be a better way... Will figure it out at some point, I'm sure.
        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "0")
                txtResult.Text += '0';
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Text = "1";
            else
                if (txtResult.Text.Length < 12)
                    txtResult.Text += '1';
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Text = "2";
            else
                if (txtResult.Text.Length < 12)
                    txtResult.Text += '2';
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Text = "3";
            else
                if (txtResult.Text.Length < 12)
                    txtResult.Text += '3';
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Text = "4";
            else
                if (txtResult.Text.Length < 12)
                    txtResult.Text += '4';
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Text = "5";
            else
                if (txtResult.Text.Length < 12)
                    txtResult.Text += '5';
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Text = "6";
            else
                if (txtResult.Text.Length < 12)
                    txtResult.Text += '6';
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Text = "7";
            else
                if (txtResult.Text.Length < 12)
                    txtResult.Text += '7';
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Text = "8";
            else
                if (txtResult.Text.Length < 12)
                    txtResult.Text += '8';
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Text = "9";
            else
                if (txtResult.Text.Length < 12)
                    txtResult.Text += '9';
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            bool dotAllowed = !txtResult.Text.Contains('.');

            if (dotAllowed)
                txtResult.Text += '.';
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            operation = '+';
            firstNumber = float.Parse(txtResult.Text);
            txtResult.Text = "0";
        }

        private void btnDiff_Click(object sender, EventArgs e)
        {
            operation = '-';
            firstNumber = float.Parse(txtResult.Text);
            txtResult.Text = "0";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operation = '*';
            firstNumber = float.Parse(txtResult.Text);
            txtResult.Text = "0";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operation = '/';
            firstNumber = float.Parse(txtResult.Text);
            txtResult.Text = "0";
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            operation = '^';
            firstNumber = float.Parse(txtResult.Text);
            txtResult.Text = "0";
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            operation = '%';
            firstNumber = float.Parse(txtResult.Text);
            txtResult.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            secondNumber = float.Parse(txtResult.Text);

            switch (operation)
            {
                case '+': txtResult.Text = (firstNumber + secondNumber).ToString();
                    break;

                case '-': txtResult.Text = (firstNumber - secondNumber).ToString();
                    break;

                case '*': txtResult.Text = (firstNumber * secondNumber).ToString();
                    break;

                case '/': txtResult.Text = (firstNumber / secondNumber).ToString();
                    break;

                case '^':
                    float result;

                    if (secondNumber == 0)
                        result = 1;

                    else if (secondNumber > 0)
                    {
                        result = firstNumber;

                        for (int i = 1; i < secondNumber; ++i)
                            result *= firstNumber;
                    }

                    // No negatives on the basic calculator though
                    else
                    {
                        result = 1;

                        for (int i = -1; i > secondNumber; --i)
                            result /= firstNumber;
                    }

                    txtResult.Text = result.ToString();
                    break;

                case '%': txtResult.Text = (firstNumber % secondNumber).ToString();
                    break;
            }

            firstNumber = 0;
            secondNumber = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            operation = ' ';
            txtResult.Text = "0";
        }
    }
}
