using System;
using System.Windows.Forms;

namespace calculator_interface
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        string action = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        private void Action_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            num1 = Convert.ToDouble(textBox1.Text);
            action = btn.Text;
            textBox1.Text = "";
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            double num2 = Convert.ToDouble(textBox1.Text);
            double result = 0;

            if (action == "+") result = num1 + num2;
            if (action == "-") result = num1 - num2;
            if (action == "*") result = num1 * num2;
            if (action == "/") result = num1 / num2;

            textBox1.Text = result.ToString();
        }
    }
}
