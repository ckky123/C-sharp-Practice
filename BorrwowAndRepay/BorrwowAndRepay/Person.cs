using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorrwowAndRepay
{
    class Person
    {
        public String Name;
        public int Money;
        public int MoneyBorrowed;

        public Person(String name, int money)
        {
            this.Name = name;
            this.Money = money;

        }

        public void Borrow(Person lender, int money)
        {
            if (lender.Money<= money)
            {
                MessageBox.Show("the person doesn't have enought money!");
            }
            else
            {
                lender.Money -= money;
                this.Money += money;
                this.MoneyBorrowed += money;
            }

           
        }

        public void Repay(Person lender, int money)
        {
            if (money <= Money && MoneyBorrowed!=0)
            {
                this.Money -= money;
                lender.Money += money;
                this.MoneyBorrowed -= money;

            }
            else if (money <= Money && MoneyBorrowed ==0)
            {
                MessageBox.Show("you already repaid all the money you borrowed!");

            }else if (money <= Money && MoneyBorrowed < money)
            {
                MessageBox.Show("you repaid too much!");
            }
            else 
            {
                MessageBox.Show("you don't have enough money!");
            }

        }
    }
}
