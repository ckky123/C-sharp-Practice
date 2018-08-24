using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypePractice
{
    public class GradeBook
    {

        public string Name { set; get; }

        public int Add(int num1, int num2)
        {
            int total = num1 + num2;
            return total;
        }
    }
}
