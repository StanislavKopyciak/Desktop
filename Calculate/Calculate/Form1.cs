using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {
        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal Result = 0.0m;
        private string operators = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "+":
                    valueSecond = decimal.Parse(txtBox.Text);
                    Result = valueFirst + valueSecond;
                    txtBox.Text = Result.ToString();
                    break;
                case "-":
                    valueSecond = decimal.Parse(txtBox.Text);
                    Result = valueFirst - valueSecond;
                    txtBox.Text = Result.ToString();
                    break;
                case "/":
                    valueSecond = decimal.Parse(txtBox.Text);
                    Result = valueFirst / valueSecond;
                    txtBox.Text = Result.ToString();
                    break;
                case "*":
                    valueSecond = decimal.Parse(txtBox.Text);
                    Result = valueFirst * valueSecond;
                    txtBox.Text = Result.ToString();
                    break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "4";
            }
            else
            {
                txtBox.Text += "4";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "1";
            }
            else
            {
                txtBox.Text += "1";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "2";
            }
            else
            {
                txtBox.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "7";
            }
            else
            {
                txtBox.Text += "7";
            }
        }

        private void Number0_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "0";
            }
            else
            {
                txtBox.Text += "0";
            }
        }

        private void Number3_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "3";
            }
            else
            {
                txtBox.Text += "3";
            }
        }

        private void Number5_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "5";
            }
            else
            {
                txtBox.Text += "5";
            }
        }

        private void Number6_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "6";
            }
            else
            {
                txtBox.Text += "6";
            }
        }

        private void Number8_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "8";
            }
            else
            {
                txtBox.Text += "8";
            }
        }

        private void Number9_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "9";
            }
            else
            {
                txtBox.Text += "9";
            }
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            if (!txtBox.Text.Contains("."))
            {
                txtBox.Text += ".";
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(txtBox.Text);
            txtBox.Clear();
            operators = "+";
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(txtBox.Text);
            txtBox.Clear();
            operators = "-";
        }

        private void Dilem_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(txtBox.Text);
            txtBox.Clear();
            operators = "/";
        }

        private void Mnozh_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(txtBox.Text);
            txtBox.Clear();
            operators = "*";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
        valueFirst = 0.0m;
        valueSecond = 0.0m;
        txtBox.Text = "0";
    }
    }
}
