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

        #region Numerical button events
        private void btnZero_Click(object sender, EventArgs e)
        {
            UpdateNumber(btnZero.Text);
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            UpdateNumber(btnOne.Text);
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            UpdateNumber(btnTwo.Text);
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            UpdateNumber(btnThree.Text);
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            UpdateNumber(btnFour.Text);
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            UpdateNumber(btnFive.Text);
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            UpdateNumber(btnSix.Text);
        }
        private void btnSeven_Click(object sender, EventArgs e)
        {
            UpdateNumber(btnSeven.Text);
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            UpdateNumber(btnEight.Text);
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            UpdateNumber(btnNine.Text);
        }
        #endregion

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            UpdateNumber(btnDecimal.Text);
        }

        private void UpdateNumber(string numberString)
        {
            txtResults.Text += numberString.Replace("&",String.Empty);
            calcController.InsertNumber(calcController.GetNumber(txtResults.Text));
        }

        private void btnChangeSign_Click(object sender, EventArgs e)
        {
            calcController.setNumberSign(!calcController.IsNumberPositive());
            txtResults.Text = calcController.GetNumber().ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            calcController.Divide(calcController.GetNumber(txtResults.Text)).ToString();
            txtResults.Text = String.Empty;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            calcController.Multiply(calcController.GetNumber(txtResults.Text)).ToString();
            txtResults.Text = String.Empty;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            calcController.Subtract(calcController.GetNumber(txtResults.Text)).ToString();
            txtResults.Text = String.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            calcController.Add(calcController.GetNumber(txtResults.Text)).ToString();
            txtResults.Text = String.Empty;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            txtResults.Text = calcController.Calculate().ToString();
        }
    }
}
