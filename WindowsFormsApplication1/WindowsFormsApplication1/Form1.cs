using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtinput.ScrollBars = ScrollBars.Both;
            txtoutput.ScrollBars = ScrollBars.Both;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnhello_Click(object sender, EventArgs e)
          
        {
            if (lblshow.Text.Equals(""))
            {
                lblshow.Text = "hi";
                lblshow.Font = new Font(lblshow.Font.FontFamily,50);
                this.lblshow.BackColor = System.Drawing.Color.YellowGreen;
                this.lblshow.ForeColor = System.Drawing.Color.DarkBlue;
                this.BackColor = System.Drawing.Color.DarkGreen;
            }
            else
            {
                lblshow.Text = "";
                this.lblshow.BackColor = DefaultBackColor;
                this.BackColor = DefaultBackColor;
            }


            String input = txtinput.Text;
            txtinput.Text = "";

            txtoutput.Text = input;


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            txtoutput.Font = fontDialog1.Font;
        }

        private void Color_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            txtoutput.ForeColor = colorDialog1.Color;
        }
    }
}
