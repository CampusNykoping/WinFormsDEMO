namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        double firstNumber;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            updateDisplay("1");
        }

        private void updateDisplay(string sNumber)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = sNumber;
            }
            else
            {
                textBox1.Text = textBox1.Text + sNumber;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            updateDisplay("2");
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            updateDisplay("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            updateDisplay("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            updateDisplay("5");
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            updateDisplay("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            updateDisplay("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            updateDisplay("8");
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            updateDisplay("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            updateDisplay("0");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            operation = "+";
            textBox1.Text = "0";
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            operation = "-";
            textBox1.Text = "0";
        }
        private void btnMultply_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            operation = "*";
            textBox1.Text = "0";
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            operation = "/";
            textBox1.Text = "0";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            double secondNumber;
            double result;

            secondNumber = double.Parse(textBox1.Text);

            if (operation == "+")
            {
                result = firstNumber + secondNumber;
                textBox1.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (operation == "-")
            {
                result = firstNumber - secondNumber;
                textBox1.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (operation == "*")
            {
                result = firstNumber * secondNumber;
                textBox1.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (operation == "/")
            {
                if (secondNumber == 0)
                {
                    textBox1.Text = "Divide by zero error";
                }
                else
                {
                    result = firstNumber / secondNumber;
                    textBox1.Text = Convert.ToString(result);
                    firstNumber = result;
                }
            }
        }
    }
}