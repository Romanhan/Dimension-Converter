using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dimension_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inTickness = textBox1.Text;
            string inLength = textBox4.Text;

            double listTickness = 0;
            double listLenght = 0;
            double resultD = 0;

            try
            {
                listTickness = Convert.ToDouble(inTickness);
                listLenght = Convert.ToDouble(inLength);
                resultD = listLenght / 3.1415 + listTickness;
                textBox7.Text = resultD.ToString();
            }
            catch (Exception err)
            {
                textBox1.Text = "";
                textBox4.Text = "";
                Console.WriteLine("{0} Exception caoght.", err); ;
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inTickness = textBox2.Text;
            string inDiam = textBox5.Text;

            double listTickness = 0;
            double listDiam = 0;
            double resultL = 0;

            try
            {
                listTickness = Convert.ToDouble(inTickness);
                listDiam = Convert.ToDouble(inDiam);
                resultL = (listDiam - listTickness) * 3.1415;
                textBox8.Text = resultL.ToString();
            }
            catch (Exception err)
            {
                textBox2.Text = "";
                textBox5.Text = "";
                Console.WriteLine("{0} Exception caoght.", err); ;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string inTickness = textBox3.Text;
            string inLD = textBox6.Text;

            double listTickness = 0;
            double listLD = 0;
            double resultL = 0;

            try
            {
                listTickness = Convert.ToDouble(inTickness);
                listLD = Convert.ToDouble(inLD);
                resultL = ((listLD / 3.1415) - listTickness) * 3.1415;
                textBox9.Text = resultL.ToString();
            }
            catch (Exception err)
            {
                textBox3.Text = "";
                textBox6.Text = "";
                Console.WriteLine("{0} Exception caoght.", err); ;
            }
        }
    }
}
