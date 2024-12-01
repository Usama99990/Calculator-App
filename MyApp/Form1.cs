using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class Calculator : Form
    {
        int i = 0;
        double fNumber=0, sNumber=0, res=0;
        string op="";
        public Calculator()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void n1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";

        }

        private void n2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";

        }

        private void n3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";

        }

        private void n4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";

        }

        private void n5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";

        }

        private void n6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";

        }

        private void n8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";

        }

        private void n0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";

        }

        private void nPoint_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";

        }

        private void nEquals_Click(object sender, EventArgs e)
        {
            sNumber = Convert.ToDouble(textBox1.Text);
            i = 1;
            switch(op)
            {
                case "+":
                    res = fNumber + sNumber;
                    textBox1.Text = Convert.ToString(res);
                    break;
                case "-":
                    res = fNumber - sNumber;
                    textBox1.Text = Convert.ToString(res);
                    break;
                case "*":
                    res = fNumber * sNumber;
                    textBox1.Text = Convert.ToString(res);
                    break;
                case "/":
                    if (sNumber==0)
                    {
                        textBox1.Text = "Math Error!";
                    }
                    else
                    {
                        res = fNumber / sNumber;
                        textBox1.Text = Convert.ToString(res);
                    }
                    break;
            }
        }

        private void nSubtract_Click(object sender, EventArgs e)
        {
            op = "-";
            fNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void nMultiply_Click(object sender, EventArgs e)
        {
            op = "";
            fNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "*";
        }

        private void nDivide_Click(object sender, EventArgs e)
        {
            op = "";
            fNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "/";
        }

        private void nClear_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "0";
            textBox1.Text = "";

        }

        private void nAdd_Click(object sender, EventArgs e)
        {
            op = "+";
            fNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";

        }
    }
}
