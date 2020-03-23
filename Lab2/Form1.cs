using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2._5
{
    public partial class Form1 : Form
    {
        string nr1 = "";
        string nr2 = "0";
        string sign = "";
        string total = "";
        bool egal = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // .
            if (nr2.IndexOf('.') == -1)
            {
                nr2 += ".";
                textBox1.Text = total + nr2;
            }
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // =
            calculate("=");
            egal = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // +
            if (sign == "")
                sign = "+";
            calculate("+");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // -
            if (sign == "")
                sign = "-";
            calculate("-");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // *
            if (sign == "")
                sign = "*";
            calculate("*");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // /
            if (sign == "")
                sign = "/";
            calculate("/");
        }

        private void calculate(string semn)
        {
            if (nr2 != "")
            {
                if (nr1 == "")
                {
                    nr1 = nr2;
                }
                else
                {
                    if (semn != "=" && egal == true)
                        egal = false;
                    else
                        switch (sign)
                        {
                            case "+":
                                nr1 = (Convert.ToDouble(nr1) + Convert.ToDouble(nr2)).ToString();
                                break;
                            case "-":
                                nr1 = (Convert.ToDouble(nr1) - Convert.ToDouble(nr2)).ToString();
                                break;
                            case "*":
                                nr1 = (Convert.ToDouble(nr1) * Convert.ToDouble(nr2)).ToString();
                                break;
                            case "/":
                                nr1 = (Convert.ToDouble(nr1) / Convert.ToDouble(nr2)).ToString();
                                break;
                            default:
                                break;
                        }
                    if (semn != "=")
                        sign = semn;
                }

                if (semn != "=")
                {
                    nr2 = "0";
                    total = nr1 + "\n" + semn + " ";
                    textBox1.Text = total + nr2;
                }
                else
                {
                    total = nr1;
                    textBox1.Text = total;
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // <-
            if (egal == false)
            {
                if (nr2.Length > 1)
                    nr2 = nr2.Remove(nr2.Length - 1);
                else
                    nr2 = "0";
                textBox1.Text = total + nr2;
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // C
            nr1 = "";
            nr2 = "0";
            sign = "";
            total = "";
            textBox1.Text = total + nr2;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string cif = "0";
            if (nr2.Length <= 15)
            {
                if (nr2 == "0")
                    nr2 = cif;
                else
                    nr2 += cif;
                textBox1.Text = total + nr2;
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            string cif = "1";
            if (nr2.Length <= 15)
            {
                if (nr2 == "0")
                    nr2 = cif;
                else
                    nr2 += cif;
                textBox1.Text = total + nr2;
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            string cif = "2";
            if (nr2.Length <= 15)
            {
                if (nr2 == "0")
                    nr2 = cif;
                else
                    nr2 += cif;
                textBox1.Text = total + nr2;
            }
        }
        private void three_Click(object sender, EventArgs e)
        {
            string cif = "3";
            if (nr2.Length <= 15)
            {
                if (nr2 == "0")
                    nr2 = cif;
                else
                    nr2 += cif;
                textBox1.Text = total + nr2;
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            string cif = "4";
            if (nr2.Length <= 15)
            {
                if (nr2 == "0")
                    nr2 = cif;
                else
                    nr2 += cif;
                textBox1.Text = total + nr2;
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            string cif = "5";
            if (nr2.Length <= 15)
            {
                if (nr2 == "0")
                    nr2 = cif;
                else
                    nr2 += cif;
                textBox1.Text = total + nr2;
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            string cif = "6";
            if (nr2.Length <= 15)
            {
                if (nr2 == "0")
                    nr2 = cif;
                else
                    nr2 += cif;
                textBox1.Text = total + nr2;
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            string cif = "7";
            if (nr2.Length <= 15)
            {
                if (nr2 == "0")
                    nr2 = cif;
                else
                    nr2 += cif;
                textBox1.Text = total + nr2;
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            string cif = "8";
            if (nr2.Length <= 15)
            {
                if (nr2 == "0")
                    nr2 = cif;
                else
                    nr2 += cif;
                textBox1.Text = total + nr2;
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            string cif = "9";
            if (nr2.Length <= 15)
            {
                if (nr2 == "0")
                    nr2 = cif;
                else
                    nr2 += cif;
                textBox1.Text = total + nr2;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case (96):
                case (48):
                    button15_Click(sender, e);
                    break;
                case (97):
                case (49):
                    one_Click(sender, e);
                    break;
                case (98):
                case (50):
                    two_Click(sender, e);
                    break;
                case (99):
                case (51):
                    three_Click(sender, e);
                    break;
                case (100):
                case (52):
                    four_Click(sender, e);
                    break;
                case (101):
                case (53):
                    five_Click(sender, e);
                    break;
                case (102):
                case (54):
                    six_Click(sender, e);
                    break;
                case (103):
                case (55):
                    seven_Click(sender, e);
                    break;
                case (104):
                case (56):
                    eight_Click(sender, e);
                    break;
                case (105):
                case (57):
                    nine_Click(sender, e);
                    break;

                case (190):
                    button1_Click_1(sender, e);
                    break;
                case (13):
                    button14_Click(sender, e);
                    break;
                case (107):
                case (187):
                    button1_Click(sender, e);
                    break;
                case (109):
                case (189):
                    button2_Click(sender, e);
                    break;
                case (111):
                case (191):
                    button3_Click(sender, e);
                    break;
                case (106):
                    button4_Click(sender, e);
                    break;
                case (27):
                    button3_Click_1(sender, e);
                    break;
                case (8):
                    button2_Click_1(sender, e);
                    break;
                default:
                    break;

            }
            // Console.WriteLine(e.KeyValue);
        }

        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {
            button14_Click(sender, e);
        }
    }
}
