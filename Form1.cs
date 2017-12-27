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

        //Variabile 

        public int cate1=1, cate2=1;
        public bool estePunct = false;
        public double rezultat;
        public double numar1 = 0, numar2 = 0;
        public char operatie = ' ';

        // Initializare Form 1

        public Form1()
        {
            InitializeComponent();
        }

        //Form 1

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            numar1 = 0;
            numar2 = 0;
            operatie = ' ';
            estePunct = false;
        }

        //nothing important
        //general button click
        //when the button with digit nr is clicked, call this method
        private void button_Click(object sender, EventArgs e, int nr)
        {
            if (estePunct == false)
            {
                if (operatie != ' ')
                {
                    numar2 = numar2 * 10 + nr;
                    textBox1.Text += "" + nr;
                }
                else
                {
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "" + nr;
                        numar1 = nr;
                    }
                    else
                    {
                        textBox1.Text += "" + nr;
                        numar1 = numar1 * 10 + nr;
                    }
                }
            }
            else
            {
                if (operatie != ' ')
                {
                    cate2 *= 10;
                    if (numar2 >= 0)
                        numar2 = numar2 * 10 + nr;
                    else
                        numar2 = numar2 * 10 - nr;
                    textBox1.Text += "" + nr;
                }
                else
                {
                    cate1 *= 10;
                    textBox1.Text += "" + nr;
                    if (numar1 >= 0)
                        numar1 = numar1 * 10 + nr;
                    else
                        numar1 = numar1 * 10 - nr;
                }
            }
        }

        // Buton 1

        private void button8_Click(object sender, EventArgs e)
        {
            if (estePunct == false)
            {
                if (operatie != ' ')
                {
                    numar2 = numar2 * 10 + 1;
                    textBox1.Text += "1";
                }
                else
                {
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "1";
                        numar1 = 1;
                    }
                    else
                    {
                        textBox1.Text += "1";
                        numar1 = numar1 * 10 + 1;
                    }
                }
            }
            else
            {
                if (operatie != ' ')
                {
                    cate2 *= 10;
                    if (numar2 >= 0)
                        numar2 = numar2 * 10 + 1;
                    else
                        numar2 = numar2 * 10 - 1;
                    textBox1.Text += "1";
                }
                else
                {
                    cate1 *= 10;
                    textBox1.Text += "1";
                    if (numar1 >= 0)
                        numar1 = numar1 * 10 + 1;
                    else
                        numar1 = numar1 * 10 - 1;
                }
            }
        }

        // Buton 2

        private void button7_Click(object sender, EventArgs e)
        {
            if (estePunct == false)
            {
                if (operatie != ' ')
                {
                    numar2 = numar2 * 10 + 2;
                    textBox1.Text += "2";
                }
                else
                {
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "2";
                        numar1 = 2;
                    }
                    else
                    {
                        textBox1.Text += "2";
                        numar1 = numar1 * 10 + 2;
                    }
                }
            }
            else
            {
                if (operatie != ' ')
                {
                    cate2 *= 10;
                    if (numar2 >= 0)
                        numar2 = numar2 * 10 + 2;
                    else
                        numar2 = numar2 * 10 - 2;
                    textBox1.Text += "2";
                }
                else
                {
                    cate1 *= 10;
                    textBox1.Text += "2";
                    if (numar1 >= 0)
                        numar1 = numar1 * 10 + 2;
                    else
                        numar1 = numar1 * 10 - 2;
                }
            }
        }

        // Buton 3

        private void button6_Click(object sender, EventArgs e)
        {
            if (estePunct == false)
            {
                if (operatie != ' ')
                {
                    numar2 = numar2 * 10 + 3;
                    textBox1.Text += "3";
                }
                else
                {
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "3";
                        numar1 = 3;
                    }
                    else
                    {
                        textBox1.Text += "3";
                        numar1 = numar1 * 10 + 3;
                    }
                }
            }
            else
            {
                if (operatie != ' ')
                {
                    cate2 *= 10;
                    if (numar2 >= 0)
                        numar2 = numar2 * 10 + 3;
                    else
                        numar2 = numar2 * 10 - 3;
                    textBox1.Text += "3";
                }
                else
                {
                    cate1 *= 10;
                    textBox1.Text += "3";
                    if (numar1 >= 0)
                        numar1 = numar1 * 10 + 3;
                    else
                        numar1 = numar1 * 10 - 3;
                }
            }
        }

        // Buton 4

        private void button12_Click(object sender, EventArgs e)
        {
            if (estePunct == false)
            {
                if (operatie != ' ')
                {
                    numar2 = numar2 * 10 + 4;
                    textBox1.Text += "4";
                }
                else
                {
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "4";
                        numar1 = 4;
                    }
                    else
                    {
                        textBox1.Text += "4";
                        numar1 = numar1 * 10 + 4;
                    }
                }
            }
            else
            {
                if (operatie != ' ')
                {
                    cate2 *= 10;
                    if (numar2 >= 0)
                        numar2 = numar2 * 10 + 4;
                    else
                        numar2 = numar2 * 10 - 4;
                    textBox1.Text += "4";
                }
                else
                {
                    cate1 *= 10;
                    textBox1.Text += "4";
                    if (numar1 >= 0)
                        numar1 = numar1 * 10 + 4;
                    else
                        numar1 = numar1 * 10 - 4;
                }
            }
        }

        // Buton 5

        private void button11_Click(object sender, EventArgs e)
        {
            if (estePunct == false)
            {
                if (operatie != ' ')
                {
                    numar2 = numar2 * 10 + 5;
                    textBox1.Text += "5";
                }
                else
                {
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "5";
                        numar1 = 5;
                    }
                    else
                    {
                        textBox1.Text += "5";
                        numar1 = numar1 * 10 + 5;
                    }
                }
            }
            else
            {
                if (operatie != ' ')
                {
                    cate2 *= 10;
                    if (numar2 >= 0)
                        numar2 = numar2 * 10 + 5;
                    else
                        numar2 = numar2 * 10 - 5;
                    textBox1.Text += "5";
                }
                else
                {
                    cate1 *= 10;
                    textBox1.Text += "5";
                    if (numar1 >= 0)
                        numar1 = numar1 * 10 + 5;
                    else
                        numar1 = numar1 * 10 - 5;
                }
            }
        }

        // Buton 6

        private void button10_Click(object sender, EventArgs e)
        {
            if (estePunct == false)
            {
                if (operatie != ' ')
                {
                    numar2 = numar2 * 10 + 6;
                    textBox1.Text += "6";
                }
                else
                {
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "6";
                        numar1 = 6;
                    }
                    else
                    {
                        textBox1.Text += "6";
                        numar1 = numar1 * 10 + 6;
                    }
                }
            }
            else
            {
                if (operatie != ' ')
                {
                    cate2 *= 10;
                    if (numar2 >= 0)
                        numar2 = numar2 * 10 + 6;
                    else
                        numar2 = numar2 * 10 - 6;
                    textBox1.Text += "6";
                }
                else
                {
                    cate1 *= 10;
                    textBox1.Text += "6";
                    if (numar1 >= 0)
                        numar1 = numar1 * 10 + 6;
                    else
                        numar1 = numar1 * 10 - 6;
                }
            }
        }

        // Buton 7

        private void button16_Click(object sender, EventArgs e)
        {
            if (estePunct == false)
            {
                if (operatie != ' ')
                {
                    numar2 = numar2 * 10 + 7;
                    textBox1.Text += "7";
                }
                else
                {
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "7";
                        numar1 = 7;
                    }
                    else
                    {
                        textBox1.Text += "7";
                        numar1 = numar1 * 10 + 7;
                    }
                }
            }
            else
            {
                if (operatie != ' ')
                {
                    cate2 *= 10;
                    if (numar2 >= 0)
                        numar2 = numar2 * 10 + 7;
                    else
                        numar2 = numar2 * 10 - 7;
                    textBox1.Text += "7";
                }
                else
                {
                    cate1 *= 10;
                    textBox1.Text += "7";
                    if (numar1 >= 0)
                        numar1 = numar1 * 10 + 7;
                    else
                        numar1 = numar1 * 10 - 7;
                }
            }
        }

        // Buton 8

        private void button15_Click(object sender, EventArgs e)
        {
            if (estePunct == false)
            {
                if (operatie != ' ')
                {
                    numar2 = numar2 * 10 + 8;
                    textBox1.Text += "8";
                }
                else
                {
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "8";
                        numar1 = 8;
                    }
                    else
                    {
                        textBox1.Text += "8";
                        numar1 = numar1 * 10 + 8;
                    }
                }
            }
            else
            {
                if (operatie != ' ')
                {
                    cate2 *= 10;
                    if (numar2 >= 0)
                        numar2 = numar2 * 10 + 8;
                    else
                        numar2 = numar2 * 10 - 8;
                    textBox1.Text += "8";
                }
                else
                {
                    cate1 *= 10;
                    textBox1.Text += "8";
                    if (numar1 >= 0)
                        numar1 = numar1 * 10 + 8;
                    else
                        numar1 = numar1 * 10 - 8;
                }
            }
        }

        // Buton 9

        private void button14_Click(object sender, EventArgs e)
        {
            if (estePunct == false)
            {
                if (operatie != ' ')
                {
                    numar2 = numar2 * 10 + 9;
                    textBox1.Text += "9";
                }
                else
                {
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "9";
                        numar1 = 9;
                    }
                    else
                    {
                        textBox1.Text += "9";
                        numar1 = numar1 * 10 + 9;
                    }
                }
            }
            else
            {
                if (operatie != ' ')
                {
                    cate2 *= 10;
                    if (numar2 >= 0)
                        numar2 = numar2 * 10 + 9;
                    else
                        numar2 = numar2 * 10 - 9;
                    textBox1.Text += "9";
                }
                else
                {
                    cate1 *= 10;
                    textBox1.Text += "9";
                    if (numar1 >= 0)
                        numar1 = numar1 * 10 + 9;
                    else
                        numar1 = numar1 * 10 - 9;
                }
            }
        }

        // Buton 0

        private void button1_Click(object sender, EventArgs e)
        {
            if (estePunct == false)
            {
                if (operatie != ' ')
                {
                    numar2 = numar2 * 10 + 0;
                    textBox1.Text += "0";
                }
                else
                {
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "0";
                        numar1 = 0;
                    }
                    else
                    {
                        textBox1.Text += "0";
                        numar1 = numar1 * 10 + 0;
                    }
                }
            }
            else
            {
                if (operatie != ' ')
                {
                    cate2 *= 10;
                    if (numar2 >= 0)
                        numar2 = numar2 * 10 + 0;
                    else
                        numar2 = numar2 * 10 - 0;
                    textBox1.Text += "0";
                }
                else
                {
                    cate1 *= 10;
                    textBox1.Text += "0";
                    if (numar1 >= 0)
                        numar1 = numar1 * 10 + 0;
                    else
                        numar1 = numar1 * 10 - 0;
                }
            }
        }

        // Punct

        private void button2_Click(object sender, EventArgs e)
        {
            if (estePunct == false)
            {
                estePunct = true;
                if (operatie == ' ')
                {
                    //numar1 = numar1 * 1.0;
                    textBox1.Text += ".";
                }
                else
                {
                    //numar2 = numar2 * 1.0;
                    textBox1.Text += ".";
                }
            }
        }

        // Adunare

        private void button4_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.EndsWith("+"))
            {
                estePunct = false;
                numar1 = numar1 / cate1;
                textBox1.Text += "+";
                operatie = '+';
            }
        }

        // Scadere

        private void button5_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.EndsWith("-"))
            {
                estePunct = false;
                numar1 = numar1 / cate1;
                textBox1.Text += "-";
                operatie = '-';
            }
        }

        // Inmultire

        private void button9_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.EndsWith("x"))
            {
                estePunct = false;
                numar1 = numar1 / cate1;
                textBox1.Text += "x";
                operatie = 'x';
            }
        }

        // Impartire

        private void button13_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.EndsWith("/"))
            {
                estePunct = false;
                numar1 = numar1 / cate1;
                textBox1.Text += "/";
                operatie = '/';
            }
        }

        // Buton C

        private void button17_Click(object sender, EventArgs e)
        {
            estePunct = false;
            cate1 = 1;
            cate2 = 1;
            textBox1.Text = "0";
            rezultat = 0;
            operatie = ' ';
            numar1 = 0;
            numar2 = 0;
        }

        // Egal

        private void button3_Click(object sender, EventArgs e)
        {

            if (operatie == '+')
            {
                if (estePunct == true)
                {
                    numar2 = numar2 / cate2;
                }

                rezultat = numar1 + numar2;
            }
            else if (operatie == '-')
            {
                if (estePunct == true)
                {
                    numar2 = numar2 / cate2;
                }

                rezultat = numar1 - numar2;
            }
            else if (operatie == 'x')
            {
                if (estePunct == true)
                {
                    numar2 = numar2 / cate2;
                }

                rezultat = numar1 * numar2;
            }
            else if (operatie == '/')
            {
                if (estePunct == true)
                {
                    numar2 = numar2 / cate2;
                }

                rezultat = numar1 / numar2;
            }

            estePunct = false;

            cate1 = 1;
            cate2 = 1;

            numar1 = rezultat;
            numar2 = 0;

            operatie = ' ';
            textBox1.Text = rezultat.ToString();

        }
    }
}
