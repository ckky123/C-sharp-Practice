using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student1
{
    class User
    {
        private String Username;
        private String Password;
        private int HP;

        public int hp
        {
            get { return HP; }//call when read hp
            set { //call when input value
                if (value < 0)
                {
                    HP = 0;
                }
                else
                {
                    HP = value;
                }

            }
        }

  

        public User(string UserName, string Password)
        {
            this.Username = UserName;
            this.Password = Password;
            this.HP = 20;
        }

        public bool comparePassword(string targetPassword)
        {
            if (this.Password == targetPassword)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public string getUsername()
        {
            return Username;
        }

        public void reset()
        {
            Password = "";
        }
    }
}
