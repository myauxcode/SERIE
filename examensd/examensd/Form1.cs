using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examensd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public static double examensd(double x1, double a, double b, double vim, double m)
        {
            Boolean ban = true;
            double i = 0;
            double c = 0;
            double i2 = -1;
            double termino;
            double vi = 2;
            double s = 0;
            double bas = 2;

            vim = vim / m;

            do
            {
                i = i + 1;
                vi = vi + (i - 1);

                c = a - b;//0
                a = b;
                b = c;

                vim = vim * m;

                i2 = i2 + 1;

                termino = Math.Pow(((x1 + c) / (Math.Cos(vim) + Math.Pow(bas, i2))), (1 / vi));



                if (ban == true)
                {

                    s = s - termino;
                }
                else
                {

                    s = s + termino;
                }
                ban = !ban;



            } while (!(c == 0));


            return s;

        }


        public static string examensdt(double x1, double a, double b, double vim, double m)
        {
            Boolean ban = true;
            double i = 0;
            double c = 0;
            double i2 = -1;
            string termino = "";
            double vi = 2;
            string s = "";
            double bas = 2;

            vim = vim / m;

            do
            {
                i = i + 1;
                vi = vi + (i - 1);

                c = a - b;//0
                a = b;
                b = c;

                vim = vim * m;

                i2 = i2 + 1;

                termino = "Math.Pow(((x1 + " + c + ") / (Math.Cos(" + vim + ") + Math.Pow(2, " + i2 + "))),  (1 / " + vi + "))";




                if (ban == true)
                {
                    //restar
                    s = s + "     -     " + termino;
                }
                else
                {
                    //sumar
                    s = s + "      +   " + termino;
                }
                ban = !ban; // codigo para pinponear



            } while (!(c == 0));


            return s;

        }
        private void examenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox6.Text = string.Concat(examensd(double.Parse(textBox1.Text), double.Parse(textBox2.Text), double.Parse(textBox3.Text), double.Parse(textBox4.Text), double.Parse(textBox5.Text)));
            textBox7.Text = string.Concat(examensdt(double.Parse(textBox1.Text), double.Parse(textBox2.Text), double.Parse(textBox3.Text), double.Parse(textBox4.Text), double.Parse(textBox5.Text)));


        }
    }
}
