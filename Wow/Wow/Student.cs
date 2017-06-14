using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wow
{
    class Student
    {
        //Property
        public int StudentID;
        public string Name;
        public int Grade;
        public int Score;
        public static int PassScore=60;


        //Method
        public Student(int studentID, string name, int grade)
        {
            
            Grade = grade;
            Name = name;
            StudentID = studentID;
        }
        public Student(int studentID, string name)
        {

  
            Name = name;
            StudentID = studentID;
        }

        public string Say()
        {
            return "I am " + Name + "\nI am year " + Grade+ " student!"+"\n My studentID is: "+ StudentID;
        }

        public string Talk(int sgrade, string sname)
        {
            return Grade + "year" + Name + "say hi to year "+ sgrade + " " + sname;

        }

        public void Upgrade()
        {

            Grade++;
        }

        public bool isPass()
        {
            if (Score >= PassScore)
            {
                return true;
            }
            else
            {
                return false;

            }
        }


    }
}
