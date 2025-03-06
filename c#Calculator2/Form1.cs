using System.Drawing.Text;

namespace c_Calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String calTotal;
        double num1;
        double num2;
        String option;
        double result;
        bool isResultDisplayed;

        private void button1_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + b1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + b2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + b3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (isResultDisplayed)
                {
                    num1 = result;
                    isResultDisplayed = false;
                }
                else
                {
                    num1 = double.Parse(textDisplay.Text);
                }
                option = "+";
                textDisplay.Clear();
            }
            catch (FormatException ex)
            {
                textDisplay.Clear();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (isResultDisplayed)
                {
                    num1 = result;
                    isResultDisplayed = false;
                }
                else
                {
                    num1 = double.Parse(textDisplay.Text);
                }
                option = "*";
                textDisplay.Clear();
            }
            catch (FormatException ex)
            {
                textDisplay.Clear();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + b8.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + b4.Text;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + b5.Text;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + b6.Text;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + b7.Text;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + b9.Text;
        }

        private void b10_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + b10.Text;
        }

        private void bDecimal_Click(object sender, EventArgs e)
        {
            if (!textDisplay.Text.Contains("."))
            {
                textDisplay.Text += bDecimal.Text;
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            textDisplay.Clear();
            num1 = 0;
            num2 = 0;
            result = 0;
            isResultDisplayed = false;
        }

        private void bMinus_Click(object sender, EventArgs e)
        {
            try
            {
                if (isResultDisplayed)
                {
                    num1 = result;
                    isResultDisplayed = false;
                }
                else
                {
                    num1 = double.Parse(textDisplay.Text);
                }
                option = "-";
                textDisplay.Clear();
            }
            catch (FormatException ex)
            {
                textDisplay.Clear();
            }
        }

        private void bDivide_Click(object sender, EventArgs e)
        {
            try
            {
                if (isResultDisplayed)
                {
                    num1 = result;
                    isResultDisplayed = false;
                }
                else
                {
                    num1 = double.Parse(textDisplay.Text);
                }
                option = "/";
                textDisplay.Clear();
            }
            catch (FormatException ex)
            {
                textDisplay.Clear();
            }
        }

        private void bModulo_Click(object sender, EventArgs e)
        {
            try
            {
                if (isResultDisplayed)
                {
                    num1 = result;
                    isResultDisplayed = false;
                }
                else
                {
                    num1 = double.Parse(textDisplay.Text);
                }
                option = "%";
                textDisplay.Clear();
            }
            catch (FormatException ex)
            {
                textDisplay.Clear();
            }
        }

        private void bPower_Click(object sender, EventArgs e)
        {
            try
            {
                if (isResultDisplayed)
                {
                    num1 = result;
                    isResultDisplayed = false;
                }
                else
                {
                    num1 = double.Parse(textDisplay.Text);
                }
                option = "^";
                textDisplay.Clear();
            }
            catch (FormatException ex)
            {
                textDisplay.Clear();
            }
        }

        private void bEqual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textDisplay.Text);

            switch (option)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero!", "Math Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    result = num1 / num2;
                    break;
                case "%":
                    result = num1 % num2;
                    break;
                case "^":
                    result = Math.Pow(num1, num2);
                    break;
                default:
                    MessageBox.Show("Put the correct Operator!", "Operator Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            textDisplay.Text = result + "";
            isResultDisplayed = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Back: bClear_Click(this, EventArgs.Empty); e.SuppressKeyPress = true; break;
                case Keys.Add: button4_Click(this, EventArgs.Empty); e.SuppressKeyPress = true; break;
                case Keys.Subtract: bMinus_Click(this, EventArgs.Empty); e.SuppressKeyPress = true; break;
                case Keys.Multiply: button7_Click(this, EventArgs.Empty); e.SuppressKeyPress = true; break;
                case Keys.Divide: bDivide_Click(this, EventArgs.Empty); e.SuppressKeyPress = true; break;
                case Keys.Oem5: bModulo_Click(this, EventArgs.Empty); e.SuppressKeyPress = true; break;
                case Keys.Oem6: bPower_Click(this, EventArgs.Empty); e.SuppressKeyPress = true; break;
                case Keys.Enter: bEqual_Click(this, EventArgs.Empty); e.SuppressKeyPress = true; break;
                default: break;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isResultDisplayed)
            {
                textDisplay.Clear();
                isResultDisplayed = false;
            }
            char[] allowKeys = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '.' };
            if (allowKeys.Contains(e.KeyChar))
            {
                textDisplay.Text += e.KeyChar.ToString();
                e.Handled = true;
            }
            else
                e.Handled = true;
        }
    }
}