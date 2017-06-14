using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorrwowAndRepay
{
    public partial class Form1 : Form
    {
        Person i; 
        Person friend;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = new Person(myNameInput.Text, 1000);
            friend = new Person(FriendNameInput.Text, 10000);
            myNameInput.Enabled = false;
            FriendNameInput.Enabled = false;
            SubmitButton.Enabled = false;

            BorrowButton.Enabled = true;
            RepayButton.Enabled = true;

            BorrowButton.Text = "跟" + friend.Name + "借$1000";
            RepayButton.Text = "跟" + friend.Name + "還$1000";
            myNameLabel.Text= i.Name;
            MyMoneyLabel.Text = i.Money.ToString();
            FriendNameLabel.Text = friend.Name;
            FriendNameMoneyLabel.Text = friend.Money.ToString();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void BorrowButton_Click(object sender, EventArgs e)
        {
             i.Borrow(friend, 1000);
             MyMoneyLabel.Text = i.Money.ToString();
             FriendNameMoneyLabel.Text = friend.Money.ToString();
        }
        private void RepayButton_Click(object sender, EventArgs e)
        {
            i.Repay(friend, 1000);
            MyMoneyLabel.Text = i.Money.ToString();
            FriendNameMoneyLabel.Text = friend.Money.ToString();
        }


    }
}
