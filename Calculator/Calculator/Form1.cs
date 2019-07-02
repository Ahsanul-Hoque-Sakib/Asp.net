using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double value1 = 0;
        String Operation = "";
        bool isoperationperformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || isoperationperformed)
            {
                textBox.Clear();
            }
            isoperationperformed = false;
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!textBox.Text.Contains(".")){
                    textBox.Text = textBox.Text + button.Text;
                }
            }
            else
            {
                textBox.Text = textBox.Text + button.Text;
            }

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (value1 != 0)
            {
                button17.PerformClick();
                Operation = button.Text;
                label.Text = value1 + " " + Operation;
                isoperationperformed = true;
            }
            else
            {
                Operation = button.Text;
                value1 = Double.Parse(textBox.Text);
                label.Text =value1+Operation;
                isoperationperformed = true;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            value1 = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Double value2 = Double.Parse(textBox.Text);
            switch (Operation)
            {
                case "+":
                    
                    textBox.Text = (value1 + Double.Parse(textBox.Text)).ToString();
                   // label.Text = value1 + "+" + textBox.Text;
                    break;

                case "-":
                    textBox.Text = (value1 - Double.Parse(textBox.Text)).ToString();
                    break;

                case "*":
                    textBox.Text = (value1 * Double.Parse(textBox.Text)).ToString();
                    break;

                case "/":
                    try
                    {
                        textBox.Text = (value1 / Double.Parse(textBox.Text)).ToString();
                    }
                    catch(Exception)
                    {
                        textBox.Text = "SyntaxError";
                    }
                    
                    break;

                default:
                    break;
            }

            value1 = Double.Parse(textBox.Text);
            label.Text=label.Text+value2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
