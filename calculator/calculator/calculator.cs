namespace calculator
{
    public partial class calculator : Form
    {
        bool newOperation = true;
        double firstvalue;
        double secondvalue;
        double result = 0.0;
        string operation = "";

        public calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (newOperation)
            {
                textBox1.Clear();
                newOperation = false;
            }
            if (btn.Text == ",")
            {
                var val = textBox1.Text.IndexOf(',');
                if (val != -1)
                {
                    return;
                }
            }
            textBox1.Text += btn.Text;
        }

        private void ButtonActionResult(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)) return;

            secondvalue = Convert.ToDouble(textBox1.Text);
            switch (operation)
            {
                case "+":
                    result = firstvalue + secondvalue;
                    break;
                case "-":
                    result = firstvalue - secondvalue;
                    break;
                case "/":
                    result = firstvalue / secondvalue;
                    break;
                case "*":
                    result = firstvalue * secondvalue;
                    break;
                case "%":
                    result = firstvalue % secondvalue;
                    break;
                case "^":
                    result = Math.Pow(firstvalue, secondvalue);
                    break;
                default:
                    return;
            }

            textBox1.Text = result.ToString();
            newOperation = true;
        }

        private void ButtonActionOperation(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)) return;

            Button btn = (Button)sender;
            firstvalue = Convert.ToDouble(textBox1.Text);
            operation = btn.Text;
            newOperation = true;
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            firstvalue = 0.0;
            secondvalue = 0.0;
            result = 0.0;
            operation = "";
            textBox1.Text = "0";
            newOperation = true;
        }

        private void calculator_Load(object sender, EventArgs e)
        {
        }
    }
}
