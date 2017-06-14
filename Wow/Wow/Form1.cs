using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wow
{
    public partial class Form1 : Form
    {
        private int times = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number, zero;
            number = 20;
            zero = 110;
            bool a = true;
            bool b = false;
            string c = "adfasdf";
            string d = "100";
            var cd = number + zero + d;
            MessageBox.Show("Number: " + cd);
        }

        private void button2_Click(object sender, EventArgs e)
        {
         Student s=new Student(10201,"Wendy");
         Student s2 = new Student(10202, "Chris",2);
         MessageBox.Show(s.Say());
         MessageBox.Show(s2.Say());

            int c = 
                Math

            MessageBox.Show("" + c);
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            times = 0;
            labelWendy.Text = "you already click" + times;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            int r =(int)Chooser.Value;
            string result = "";

            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    result += "*";


                }
                result += "\r\n";

            }
            MessageBox.Show(result);
        }
    }
}