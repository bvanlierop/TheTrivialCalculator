using System;
using System.Windows.Forms;
using CalculatorApp;

namespace WinformsUI
{
    public partial class CalculatorMainForm : Form
    {
        public CalculatorMainForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Calculator c = new Calculator();
            // Capture scenario: what if the user enters non integers, do validation...
            c.FirstArgument = int.Parse(txtFirst.Text);
            c.SecondArgument = int.Parse(txtSecond.Text);
            txtResult.Text = c.Add().ToString();
        }
    }
}
