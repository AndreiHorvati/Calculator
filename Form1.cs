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
            button_Click(sender, e, 1);
        }

        // Buton 2

        private void button7_Click(object sender, EventArgs e)
        {
            button_Click(sender, e, 2);
        }

        // Buton 3

        private void button6_Click(object sender, EventArgs e)
        {
            button_Click(sender, e, 3);
        }

        // Buton 4

        private void button12_Click(object sender, EventArgs e)
        {
            button_Click(sender, e, 4);
        }

        // Buton 5

        private void button11_Click(object sender, EventArgs e)
        {
            button_Click(sender, e, 5);
        }

        // Buton 6

        private void button10_Click(object sender, EventArgs e)
        {
            button_Click(sender, e, 6);
        }

        // Buton 7

        private void button16_Click(object sender, EventArgs e)
        {
            button_Click(sender, e, 7);
        }

        // Buton 8

        private void button15_Click(object sender, EventArgs e)
        {
            button_Click(sender, e, 8);
        }

        // Buton 9

        private void button14_Click(object sender, EventArgs e)
        {
            button_Click(sender, e, 9);
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

        //metoda pt operatii
        private void operatii(object sender, EventArgs e, char op)
        {
            if (!textBox1.Text.EndsWith("" + op))
            {
                estePunct = false;
                numar1 = numar1 / cate1;
                textBox1.Text += "" + op;
                operatie = op;
            }
        }

        // Adunare

        private void button4_Click(object sender, EventArgs e)
        {
            operatii(sender, e,'+');
        }

        // Scadere

        private void button5_Click(object sender, EventArgs e)
        {
            operatii(sender, e,'-');
        }

        // Inmultire

        private void button9_Click(object sender, EventArgs e)
        {
            operatii(sender, e,'x');
        }

        // Impartire

        private void button13_Click(object sender, EventArgs e)
        {
            operatii(sender, e,  '/');
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
