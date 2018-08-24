using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReferenceTypePractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypePractice.Tests
{
    [TestClass()]
    public class GradeBookTests
    {
        [TestMethod()]
        public void Add_Are_Equal()
        {
            //Arrange

            int num1 = 5;
            int num2 = num1;

            num1 = 10;

            //Act

            //Assert
            Assert.AreNotEqual(num1, num2);

        }

        [TestMethod()]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            grades = new float[5];
            grades[1] = 89.1f;
        }

        [TestMethod()]
        public void UppercaseString()
        {
            string name = "sccot";
            name = name.ToUpper();

            Assert.AreEqual("SCCOT", name);
        }



        [TestMethod()]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2015, 1, 1);
            date = date.AddDays(1);
            Assert.AreEqual(2, date.Day);
        }


        [TestMethod()]
        public void Add_Returns_Total_Of_Two_Numbers_Add()
        {
            //Arrange
            var target = new GradeBook();
            GradeBook num1 = new GradeBook();
            GradeBook num2 = num1;

            //Act


            //Assert
            Assert.AreSame(num1, num2);

        }

        [TestMethod()]
        public void StringCompare_Return_True_If_Two_String_Are_Equal()
        {
            //Arrange
            string name1 = "ABC";
            string name2 = "abc";

            //Act


            //Assert
            Assert.IsTrue( string.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase));

        }




        [TestMethod()]
        public void PassbyValueForValueType()
        {
            //Arrange
            int x;

            Increment(out x);
            
            //Act


            //Assert
            Assert.AreEqual(47, x);

        }

        private int Increment(out int n) {
            int k = 10;
            n = 46;
            return n++;
        }

        [TestMethod()]
        public void PassbyValueForReferenceType()
        {
            //Arrange
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookName(ref book2);

            //Act


            //Assert
            Assert.AreEqual(book2.Name, "A GradBook");

        }

        private void GiveBookName(ref GradeBook book) {
            book = new GradeBook();
            book.Name = "A GradBook";
        }

    }
}