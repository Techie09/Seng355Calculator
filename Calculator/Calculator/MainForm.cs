using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public CalculatorController calcController;
        public MainForm()
        {
            InitializeComponent();
            calcController = new CalculatorController();
        }

        #region Numerical buttons event
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btnNumber = (sender as Button);
            txtResults.Text = calcController.UpdateNumber(btnNumber.Text.Replace("&", String.Empty)).ToString();
        }
        #endregion

        private void btnChangeSign_Click(object sender, EventArgs e)
        {
            calcController.UpdateNumber(txtResults.Text);

            //Updates number based on current sign
            calcController.setNumberSign(!calcController.IsNumberPositive());

            //sets text to updated number
            txtResults.Text = calcController.GetNumber().ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtResults.Text = calcController.Divide().ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtResults.Text = calcController.Multiply().ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            txtResults.Text = calcController.Subtract().ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtResults.Text = calcController.Add().ToString();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            txtResults.Text = calcController.Calculate().ToString();
        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            calcController.Clear();
            txtResults.Text = String.Empty;
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            switch(e.KeyChar)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '.':
                case (char)Keys.NumPad0:
                case (char)Keys.NumPad1:
                case (char)Keys.NumPad2:
                case (char)Keys.NumPad3:
                case (char)Keys.NumPad4:
                case (char)Keys.NumPad5:
                case (char)Keys.NumPad6:
                case (char)Keys.NumPad7:
                case (char)Keys.NumPad8:
                case (char)Keys.NumPad9:
                case (char)Keys.Decimal:
                case (char)Keys.OemPeriod:
                    txtResults.Text = calcController.UpdateNumber(e.KeyChar.ToString()).ToString();
                    break;
                case '/':
                case (char)Keys.Divide:
                    btnDivide_Click(sender, e);
                    calcController.UpdateSign(Signs.Divide);
                    break;
                case '+':
                case (char)Keys.Add:
                    btnAdd_Click(sender, e);
                    calcController.UpdateSign(Signs.Add);
                    break;
                case '-':
                case (char)Keys.Subtract:
                    btnSubtract_Click(sender, e);
                    calcController.UpdateSign(Signs.Subtract);
                    break;
                case '*':
                case (char)Keys.Multiply:
                    btnMultiply_Click(sender, e);
                    calcController.UpdateSign(Signs.Multiply);
                    break;
                case '=':
                case (char)Keys.Enter:
                    btnEquals_Click(sender, e);
                    break;
                default:
                    e.Handled = false;
                    break;
            }
        }
    }
}
