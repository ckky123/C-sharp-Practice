using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (catBox.Image == Properties.Resources.cat2)
            {
                catBox.Image = Properties.Resources.cat1;

            }
            else 
            {
                catBox.Image = Properties.Resources.cat2;
            }

        }
    }
}
