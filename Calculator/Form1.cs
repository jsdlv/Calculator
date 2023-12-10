namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        bool commaPressed = false;
        private double firstValue = 0.0;
        private double secondValue = 0.0;
        private bool isSecondValueSet = false;
        private double result = 0.0;
        private string currentOperator = "";
        private double currentValue;
        private double percents;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    btn0_Click(sender, e);
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    btn1_Click(sender, e);
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    btn2_Click(sender, e);
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    btn3_Click(sender, e);
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    btn4_Click(sender, e);
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    btn5_Click(sender, e);
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    btn6_Click(sender, e);
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    btn7_Click(sender, e);
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    btn8_Click(sender, e);
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    btn9_Click(sender, e);
                    break;
                case Keys.Oemcomma:
                case Keys.OemPeriod:
                case Keys.Decimal:
                    btnComma_Click(sender, e);
                    break;
                case Keys.Back:
                    btnBackspace_Click(sender, e);
                    break;
                case Keys.Enter:
                    btnEquals_Click(sender, e);
                    break;
                case Keys.Escape:
                    btnCE_Click(sender, e);
                    break;
                case Keys.Delete:
                    btnC_Click(sender, e);
                    break;
                case Keys.Add:
                case Keys.Oemplus:
                    btnPlus_Click(sender, e);
                    break;
                case Keys.OemMinus:
                case Keys.Subtract:
                    btnMinus_Click(sender, e);
                    break;
                case Keys.Multiply:
                    btnTimes_Click(sender, e);
                    break;
                case Keys.Divide:
                    btnDivide_Click(sender, e);
                    break;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                display.Text = "0";
                return;
            }
            display.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                display.Text = "1";
                return;
            }
            display.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                display.Text = "2";
                return;
            }
            display.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                display.Text = "3";
                return;
            }
            display.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                display.Text = "4";
                return;
            }
            display.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                display.Text = "5";
                return;
            }
            display.Text += "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                display.Text = "6";
                return;
            }
            display.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                display.Text = "7";
                return;
            }
            display.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                display.Text = "8";
                return;
            }
            display.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                display.Text = "9";
                return;
            }
            display.Text += "9";
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if (!commaPressed)
            {
                display.Text += ".";
                commaPressed = true;
            }
        }
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (display.Text.Length > 0)
            {
                display.Text = display.Text.Remove(display.Text.Length - 1);
                if (display.Text.Length == 0)
                {
                    display.Text = "0";
                }

                if (!display.Text.Contains(',') && !display.Text.Contains('.'))
                {
                    commaPressed = false;
                }
            }
        }

        // Operators
        private void btnPlus_Click(object sender, EventArgs e)
        {
            firstValue = double.Parse(display.Text);
            currentOperator = "+";
            previous.Text = firstValue.ToString() + currentOperator;
            display.Text = "0";
            commaPressed = false;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            firstValue = double.Parse(display.Text);
            currentOperator = "-";
            previous.Text = firstValue.ToString() + currentOperator;
            display.Text = "0";
            commaPressed = false;
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            firstValue = double.Parse(display.Text);
            currentOperator = "*";
            previous.Text = firstValue.ToString() + currentOperator;
            display.Text = "0";
            commaPressed = false;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            firstValue = double.Parse(display.Text);
            currentOperator = "/";
            previous.Text = firstValue.ToString() + currentOperator;
            display.Text = "0";
            commaPressed = false;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (!isSecondValueSet)
            {
                secondValue = double.Parse(display.Text);
                isSecondValueSet = true;
            }

            switch (currentOperator)
            {
                case "+":
                    result = firstValue + secondValue;
                    previous.Text = firstValue + currentOperator + secondValue.ToString() + "=";
                    firstValue = result;
                    display.Text = result.ToString();
                    commaPressed = false;
                    break;
                case "-":
                    result = firstValue - secondValue;
                    previous.Text = firstValue + currentOperator + secondValue.ToString() + "=";
                    firstValue = result;
                    display.Text = result.ToString();
                    commaPressed = false;
                    break;
                case "*":
                    result = firstValue * secondValue;
                    previous.Text = firstValue + currentOperator + secondValue.ToString() + "=";
                    firstValue = result;
                    display.Text = result.ToString();
                    commaPressed = false;
                    break;
                case "/":
                    result = firstValue / secondValue;
                    previous.Text = firstValue + currentOperator + secondValue.ToString() + "=";
                    firstValue = result;
                    display.Text = result.ToString();
                    commaPressed = false;
                    break;
            }
            isSecondValueSet = false;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            commaPressed = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            firstValue = 0.0;
            secondValue = 0.0;
            display.Text = "0";
            previous.Text = string.Empty;
            isSecondValueSet = false;
            commaPressed = false;
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            currentValue = double.Parse(display.Text);

            display.Text = (-currentValue).ToString();

            if (isSecondValueSet)
            {
                secondValue = -currentValue;
            }

        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            firstValue = double.Parse(display.Text);
            result = Math.Sqrt(firstValue);
            display.Text = result.ToString();
            previous.Text = "√(" + firstValue + ")";
            commaPressed = false;
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (!isSecondValueSet)
            {
                secondValue = double.Parse(display.Text);
                isSecondValueSet = true;
            }

            percents = (firstValue * secondValue) / 100;
            previous.Text = firstValue + currentOperator + percents + "%=";
            result = firstValue + percents;
            display.Text = result.ToString();
            commaPressed = false;
        }

        private void btnOneDivadedByX_Click(object sender, EventArgs e)
        {
            firstValue = double.Parse(display.Text);
            result = 1 / firstValue;
            previous.Text = "1/" + firstValue + "=";
            display.Text = result.ToString();
            commaPressed = false;
        }
    }
}
