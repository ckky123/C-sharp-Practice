using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Student1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            int[] a= new int[10];
            Student[] students = new Student[3];
            students[0]= new Student(001,"Wendy");
            students[1] = new Student(002, "Winnie");
            students[2] = new Student(003, "Willy");
            for (int i = 0; i < students.Length; i++)
            {
                MessageBox.Show("Student ID: " + students[i].StudentID + "\nStudent Name: "+students[i].Name+ "\nlength:" + students.Length);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserButton.Text = "User's Button";
            User user = new User("Wendy", "123");
            String result = "";
            
            if (user.comparePassword(userName.Text))
            {
                user.hp = 200;
                result = "password correct!"+ user.getUsername()+"\nyour HP is : "+user.hp;
                button2.Enabled = true;
                

            }
            else
            {
                result = "password incorrect!";
            }
            MessageBox.Show(result);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            villager v1 = new villager("a");
            MessageBox.Show(""+v1.Talk()+ "\nIam NPC1 \nmy HP is: "+ v1.GetHP());
            //Monster m1= new Monster("monster1");
            Monster m2 = new Monster("monster2");
            //m1.Attack(v1);
            //m1.Attack(m2);
            MessageBox.Show("" + v1.Talk() + "\nNPC1 was attacked \nmy HP is: " + v1.GetHP());
            
            //MessageBox.Show("I am monster2\nmy HP is:" + m2.GetHP());


        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void MagicButton_Click(object sender, EventArgs e)
        {
            Player p= new Player("Magician", 50);
            Monster m = new Slime();
            villager v = new villager("NPC");
            Slime s=new Slime();
            //MessageBox.Show("Slime HP is:" + m.attack());
            string message = v.attack(p);
            MessageBox.Show(m.ReportPosition());
            MessageBox.Show(message);
        }

        private void MathButton_Click(object sender, EventArgs e)
        {
            double r = 2.0;
            
            double area = Math.PI*r*r;
            MessageBox.Show(""+area);
        }

        private void BoardButton_Click(object sender, EventArgs e)
        {
            int[,] A= new int[,]{{1,2}, {3,4} };
            int[,] B = new int[,] {{ 1, 2 }, { 3, 4 }};
            string result = "";
            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    result += "" + A[x, y];
                }
                result += "\n";

            }
            MessageBox.Show(result);
        }

        /*private int[,] add(int[,] a, int[,] b)
        {
        }

        private int[,] substract(int[,] a, int[,] b)
        {
        }
        private int[,] multiply(int[,] a, int[,] b)
        {
        }*/
    }
}
