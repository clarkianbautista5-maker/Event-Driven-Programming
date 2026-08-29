using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class frmCalculator : Form
    {
        private CalculatorClass cal;

        double num1, num2;
        public frmCalculator()
        {
            InitializeComponent();
            cal = new CalculatorClass();
        }
        
        private void btnEqual_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtBoxInput1.Text);
            num2 = Convert.ToDouble(txtBoxInput2.Text);

            switch (cbOperator.SelectedItem.ToString())
            {
                case "+":
                    cal.CalculateEvent += cal.GetSum;
                    break;
                case "-":
                    cal.CalculateEvent += cal.GetDifference;
                    break;
                case "*":
                    cal.CalculateEvent += cal.GetProduct;
                    break;
                case "/":
                    cal.CalculateEvent += cal.GetQuotient;
                    break;

            }

            var total = cal.Calculate(num1, num2);
            lblDisplayTotal.Text = total.ToString();

            cal.CalculateEvent -= cal.GetSum;
            cal.CalculateEvent -= cal.GetDifference;
            cal.CalculateEvent -= cal.GetProduct;
            cal.CalculateEvent -= cal.GetQuotient;
        }

    }
}
