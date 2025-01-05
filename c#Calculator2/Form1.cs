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
            option = "+";
            num1 = double.Parse(textDisplay.Text);
            //textDisplay.Text = textDisplay.Text + bPlus.Text;

            textDisplay.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = double.Parse(textDisplay.Text);

            textDisplay.Clear();
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
            textDisplay.Text = textDisplay.Text + bDecimal.Text;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            textDisplay.Clear();
            num1 = 0;
            num2 = 0;
            result = 0;
        }

        private void bMinus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = double.Parse(textDisplay.Text);

            textDisplay.Clear();
        }

        private void bDivide_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = double.Parse(textDisplay.Text);

            textDisplay.Clear();
        }

        private void bModulo_Click(object sender, EventArgs e)
        {
            option = "%";
            num1 = double.Parse(textDisplay.Text);

            textDisplay.Clear();
        }

        private void bPower_Click(object sender, EventArgs e)
        {
            option = "^";
            num1 = double.Parse(textDisplay.Text);

            textDisplay.Clear();
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
